using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace Engine.Entities.DTOs
{
    public class HA
    {

        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "First Name is a required field.")]
        [StringLength(50, ErrorMessage = "First name maximum size 50 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is a required field.")]
        [StringLength(50, ErrorMessage = "Last name maximum size 50 characters")]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage = "Email maximum size 50 characters")]
        public string Email { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public string DepartmentCode { get; set; }
        [Required(ErrorMessage = "Department Name is a required field.")]
        [StringLength(50, ErrorMessage = "Department Name maximum size 50 characters")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Active is a required field.")]


        public int AdministrativeHazardID { get; set; }
        [Required(ErrorMessage = "Administrative Hazard Name is a required field.")]
        [StringLength(50, ErrorMessage = "Administrative Hazard Name maximum size 50 characters")]
        public string AdministrativeHazardName { get; set; }
        public string InPlace { get; set; }
        public string Required { get; set; }
        public string NotApplicable { get; set; }


        public int EngineeringHazardID { get; set; }
        [Required(ErrorMessage = "Engineering Hazard Name is a required field.")]
        [StringLength(50, ErrorMessage = "Engineering Hazard Name maximum size 50 characters")]
        public string EngineeringHazardName { get; set; }


        public int OtherHazardID { get; set; }
        [Required(ErrorMessage = "Engineering Hazard Name is a required field.")]
        [StringLength(50, ErrorMessage = "Engineering Hazard Name maximum size 50 characters")]
        public string OtherHazardName { get; set; }


    }
}
