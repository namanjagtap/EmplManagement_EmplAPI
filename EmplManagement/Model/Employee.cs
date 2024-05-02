using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmplManagement.Model
{
    public class Employee
    {
        [Key]
        public int EmplID { get; set; }
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