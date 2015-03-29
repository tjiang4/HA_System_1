using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Engine.Entities;
using Engine.DAL;
using System.ComponentModel;
using Engine.Entities.DTOs;
#endregion

namespace Engine.BLL
{  

    public class SearchArchive
    {   
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Archive> SearchHAByFocusArea(int focusareaID)
        {
            using (var context = new AdminContext())
            {
                var data = from haf in context.HAFocusAreas 
                           where haf.FocusAreaID == focusareaID
                           join od in context.HazardAssessments
                           on haf.FocusAreaID equals od.FocusAreaID 
                           into fo
                           from h in fo
                           select new Archive()
                           {
                               FocusAreaName = haf.FocusAreaName,
                               TaskName = h.TaskName,
                               SignOffDate = h.SignOffDate,
                               CreatorFirstName = h.CreatorFirstName,
                               CreatorLastName = h.CreatorLastName,
                               ApprovedBy = h.ApprovedBy
                               
                                                               
                           };

                return data.ToList();
            }
        }
    }
}
