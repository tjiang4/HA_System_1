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
    public class HAOtherHazard
    {
        [Key]
        public int OtherHazardID { get; set; }
        [Required(ErrorMessage = "Other Hazard Name is a required field.")]
        [StringLength(50, ErrorMessage = "Other Hazard Name maximum size 50 characters")]
        public string OtherHazardName { get; set; }
        public string Yes { get; set; }
        public string No { get; set; }
        public int HazardAssessmentID { get; set; }

    }
}
