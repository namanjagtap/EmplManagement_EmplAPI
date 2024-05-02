using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmplManagement.Model.DTO
{
    public class EmployeeDTO
    {
        public int EmplID { get; set; } = 0;
        [Required]
        [MaxLength(50)]
        public string EmplName { get; set; }
        public DateOnly DOB { get; set; }
        public DateOnly DOJ { get; set; }
        public string BloodGroup { get; set; }
        public long Phone { get; set; }
        public int ExperienceYears { get; set; }
        public DateOnly CareerStartDate { get; set; }
        public DateOnly InterviewedDate { get; set; }
        public string PreviousCompany { get; set; }
        public double CTC { get; set; }
        public string WorkMode { get; set; }
    }
}
