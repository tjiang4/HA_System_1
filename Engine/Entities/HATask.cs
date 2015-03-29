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
    public class HATask
    {
        [Key]
        public int TaskID { get; set; }
        [Required(ErrorMessage = "Task Name is a required field.")]
        [StringLength(50, ErrorMessage = "Task name maximum size 50 characters")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "Active is a required field.")]
        public string Active_YN { get; set; }       
    }
}
