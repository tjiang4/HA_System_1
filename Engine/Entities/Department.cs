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
    public class Department
    {
        [Key]
        [Required(ErrorMessage = "Department Code is a required field.")]
        [StringLength(10, ErrorMessage = "Department Code maximum size 10 characters")]
        public string DepartmentCode { get; set; }
        [Required(ErrorMessage = "Department Name is a required field.")]
        [StringLength(50, ErrorMessage = "Department Name maximum size 50 characters")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Active is a required field.")]
        public string Active_YN { get; set; }
    }
}
