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
    public class HAPerformer
    {
        [Key]
        public int PerformerID { get; set; }
        [Required(ErrorMessage = "Performer Name is a required field.")]
        [StringLength(50, ErrorMessage = "Performer name maximum size 50 characters")]
        public string PerformerName { get; set; }
        [Required(ErrorMessage = "Active is a required field.")]
        public string Active_YN { get; set; }       
    }
}
