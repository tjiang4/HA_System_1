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
    public class HAEngineeringHazard
    {
        [Key]
        public int EngineeringHazardID { get; set; }
        [Required(ErrorMessage = "Engineering Hazard Name is a required field.")]
        [StringLength(50, ErrorMessage = "Engineering Hazard Name maximum size 50 characters")]
        public string EngineeringHazardName { get; set; }
        public string InPlace { get; set; }
        public string Required { get; set; }
        public string NotApplicable { get; set; }
        public int HazardAssessmentID { get; set; }

    }
}
