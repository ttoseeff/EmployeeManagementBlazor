using EmployeeManagement.Models.CustomValidators;
using EmployeeManagement.Models.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        [Key]
        public Guid EmployeeId { get; set; }
        [Required(ErrorMessage = "First Name Must be provided.")]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        [EmailDomainValidator(AllowedDomain = "Toseef.com", ErrorMessage = "Domain must be Toseef.com")]
        public string Email { get; set; }
        [CompareProperty("Email", ErrorMessage = "Email and Confirm Email must match.")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public Guid DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        public Department Department { get; set; }
        //[ValidateComplexType]


    }
}
