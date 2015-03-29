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
    public class SearchHAFormByEnvironmentController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HAEnvironment> Environment_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAEnvironments.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HazardAssessment HAFormByEnvironmentId(int EnvironmentId)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HazardAssessments.Find(EnvironmentId);
            }
        }
    }
}
