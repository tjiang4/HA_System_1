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
    public class SearchHAFormByPotentialHazardController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HAPotentialHazard> PotentialHazard_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAPotentialHazards.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HazardAssessment HAFormByPotentialHazardId(int PotentialHazardId)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HazardAssessments.Find(PotentialHazardId);
            }
        }
    }
}
