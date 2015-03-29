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
    public class HAPotentialHazard
    {
        [Key]
        public int PotentialHazardID { get; set; }
        [Required(ErrorMessage = "Potential Hazard Name is a required field.")]
        [StringLength(50, ErrorMessage = "Potential Hazard name maximum size 50 characters")]
        public string PotentialHazardName { get; set; }
        [Required(ErrorMessage = "Defination is a required field.")]
        [StringLength(500, ErrorMessage = "Defination maximum size 500 characters")]
        public string Defination { get; set; }
        [Required(ErrorMessage = "School is a required field.")]
        [StringLength(100, ErrorMessage = "School maximum size 100 characters")]
        public string School { get; set; }
        public int? ExposureLevel { get; set; }
        public int? ProbabilityLevel { get; set; }
        public int? SeverityLevel { get; set; }
        public int? Total { get; set; }
    }
}
