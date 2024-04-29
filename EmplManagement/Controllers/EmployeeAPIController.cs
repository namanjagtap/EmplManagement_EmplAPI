using EmplManagement.Data;
using EmplManagement.Model;
using EmplManagement.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EmplManagement.Controllers
{
    [Route("api/EmployeeAPI")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public EmployeeAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            return Ok(_db.Employees.ToList());
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
        [HttpPost("{id:int}", Name = "CreateEmployee")]
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
            if(employeeDTO.EmplID > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
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
                CTC = employeeDTO.CTC
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
    }
}
