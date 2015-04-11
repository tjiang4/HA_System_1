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
    public class HAssessments
    {
        [Key]
        public int HazardAssessmentID { get; set; }
        public string TaskName { get; set; }
        
        public int FocusAreaID { get; set; }
        public int EnvironmentID { get; set; }
        public int PotentialHazardsID { get; set; }
        public int TaskID { get; set; }
        public int TaskAssessedID { get; set; }
        
    }
}
