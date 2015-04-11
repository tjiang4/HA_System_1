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
    public class Archive
    {
        [Key]
        public int HazardAssessmentID { get; set; }
        public int FocusAreaID { get; set; }
        public string TaskName { get; set; }
        public DateTime? SignOffDate { get; set; }
        //public string ApprovedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string FocusAreaName { get; set; }
        public string PotentialHazardName { get; set; }
        //public string School { get; set; }
        public string EnvironmentName { get; set; }
        public string EmployeeType { get; set; }
        public string TaskAssessedName { get; set; }
        public string DepartmentName { get; set; }
        public string ControlMeasureName { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Comments { get; set; }
        
    }
}
