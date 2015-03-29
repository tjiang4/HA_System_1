using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Engine.Entities;
using Engine.DAL;
using System.ComponentModel;
#endregion

namespace Engine.BLL
{
    [DataObject]
    public class SearchHAFormByFocusAreaController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HAFocusArea> FocusArea_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAFocusAreas.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HazardAssessment HAFormByFocusAreaId(int FocusAreaId)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HazardAssessments.Find(FocusAreaId);
            }
        }
    }
}
