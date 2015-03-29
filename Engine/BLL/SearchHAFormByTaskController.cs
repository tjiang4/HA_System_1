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
    public class SearchHAFormByTaskController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HATask> Task_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HATasks.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HazardAssessment HAFormByTaskId(int TaskId)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HazardAssessments.Find(TaskId);
            }
        }
    }
}
