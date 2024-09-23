using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testwork.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes EmployeeCode auto-generated
        public int EmployeeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public bool Gender { get; set; } // Assuming bool for Male/Female

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [Required]
        public float BasicSalary { get; set; }
    }
}
