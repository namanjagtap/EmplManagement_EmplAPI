using Azure;
using EmplManagement.Data;
using EmplManagement.Model;
using EmplManagement.Model.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmplManagement.Controllers
{
    [Route("api/EmployeeAPI")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _configuration;

        public EmployeeAPIController(ApplicationDbContext db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        [HttpGet]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            string scheme = "https";
            if (!User.HasClaim(c => c.Issuer == $"{scheme}://{_configuration.GetSection("Auth0:domain").Value}/"))
            {
                return Unauthorized("Insufficient scope");
            }

            return Ok(_db.Employees.ToList());
        }

        [HttpGet("count")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<int>> GetTotalEmployee()
        {
            return Ok(_db.Employees.Count());
        }

        [HttpGet("private-scoped")]
        [Authorize("read:messages")]
        public IActionResult scoped()
        {
            return Ok(new
            {
                Message = "Hello From Private Endpoint!"
            });
        }

        [HttpGet("{id:int}", Name = "GetEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<EmployeeDTO> GetEmployee(int id)
        {
            if(id==0)
            {
                return BadRequest();
            }
            var employee = _db.Employees.FirstOrDefault(u => u.EmplID==id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost(Name = "CreateEmployee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<EmployeeDTO> CreateEmployee([FromBody] EmployeeDTO employeeDTO)
        {
            if(_db.Employees.FirstOrDefault(u => u.EmplName.ToLower()==employeeDTO.EmplName.ToLower()) != null)
            {
                return BadRequest();
            }
            if(employeeDTO == null)
            {
                return NotFound();
            }
            Employee model = new()
            {
                EmplID = employeeDTO.EmplID,
                EmplName = employeeDTO.EmplName,
                DOB = employeeDTO.DOB,
                DOJ = employeeDTO.DOJ,
                BloodGroup = employeeDTO.BloodGroup,
                Phone = employeeDTO.Phone,
                ExperienceYears = employeeDTO.ExperienceYears,
                CareerStartDate = employeeDTO.CareerStartDate,
                InterviewedDate = employeeDTO.InterviewedDate,
                PreviousCompany = employeeDTO.PreviousCompany,
                CTC = employeeDTO.CTC,
                WorkMode = employeeDTO.WorkMode,
            };
            _db.Employees.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetEmployee", new { id = model.EmplID }, model);
        }

        [HttpDelete("{id:int}", Name = "DeleteEmployee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteEmployee(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var employee = _db.Employees.FirstOrDefault(u => u.EmplID == id);
            if(employee == null)
            {
                return NotFound();
            }
            _db.Employees.Remove(employee);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateEmployee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateEmployee(int id, [FromBody] EmployeeDTO employeeDTO)
        {
            if(employeeDTO == null || id != employeeDTO.EmplID)
            {
                return BadRequest();
            }
            Employee model = new()
            {
                EmplID = employeeDTO.EmplID,
                EmplName = employeeDTO.EmplName,
                DOB = employeeDTO.DOB,
                DOJ = employeeDTO.DOJ,
                BloodGroup = employeeDTO.BloodGroup,
                Phone = employeeDTO.Phone,
                ExperienceYears = employeeDTO.ExperienceYears,
                CareerStartDate = employeeDTO.CareerStartDate,
                InterviewedDate = employeeDTO.InterviewedDate,
                PreviousCompany = employeeDTO.PreviousCompany,
                CTC = employeeDTO.CTC,
                WorkMode = employeeDTO.WorkMode,
            };
            _db.Employees.Update(model);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialEmployee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePartialEmployee(int id, JsonPatchDocument<EmployeeDTO> patchDTO)
        {
            if(patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var employee = _db.Employees.AsNoTracking().FirstOrDefault(u => u.EmplID == id);
            EmployeeDTO employeeDTO = new()
            {
                EmplID = employee.EmplID,
                EmplName = employee.EmplName,
                DOB = employee.DOB,
                DOJ = employee.DOJ,
                BloodGroup = employee.BloodGroup,
                Phone = employee.Phone,
                ExperienceYears = employee.ExperienceYears,
                CareerStartDate = employee.CareerStartDate,
                InterviewedDate = employee.InterviewedDate,
                PreviousCompany = employee.PreviousCompany,
                CTC = employee.CTC,
                WorkMode = employee.WorkMode,
            };
            if (employee == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(employeeDTO, ModelState);

            Employee model = new()
            {
                EmplID = employeeDTO.EmplID,
                EmplName = employeeDTO.EmplName,
                DOB = employeeDTO.DOB,
                DOJ = employeeDTO.DOJ,
                BloodGroup = employeeDTO.BloodGroup,
                Phone = employeeDTO.Phone,
                ExperienceYears = employeeDTO.ExperienceYears,
                CareerStartDate = employeeDTO.CareerStartDate,
                InterviewedDate = employeeDTO.InterviewedDate,
                PreviousCompany = employeeDTO.PreviousCompany,
                CTC = employeeDTO.CTC,
                WorkMode = employeeDTO.WorkMode
            };
            _db.Employees.Update(model);
            _db.SaveChanges();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
