using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace Engine.Entities
{
    public class Employee
    {
        public string FullName
        {
            get
            {
                return string.Format("{0},{1}", FirstName, LastName);
            }
        }

        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "First Name is a required field.")]
        [StringLength(50, ErrorMessage = "First name maximum size 50 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is a required field.")]
        [StringLength(50, ErrorMessage = "Last name maximum size 50 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "LogLev is a required field.")]
        [StringLength(50, ErrorMessage = "LogLev maximum size 50 characters")]
        public string LogLev { get; set; }
        [StringLength(50, ErrorMessage = "Email maximum size 50 characters")]
        public string Email { get; set; }
        [StringLength(50, ErrorMessage = "Password maximum size 50 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Department Code is a required field.")]
        [StringLength(10, ErrorMessage = "Department Code maximum size 10 characters")]
        public string DepartmentCode { get; set; }
        [StringLength(50, ErrorMessage = "Employee Type maximum size 50 characters")]
        public string EmployeeType { get; set; }
    }
}
