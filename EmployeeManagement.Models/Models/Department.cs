using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Models
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
    }
}
