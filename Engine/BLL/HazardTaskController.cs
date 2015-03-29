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
    public class HazardTaskController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HATask> HazardTask_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HATasks.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HATask HazardTaskByTaskID(int TaskID)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HATasks.Find(TaskID);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string Tasks_Add(HATask item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.TaskName))
                {
                    errors.Add("Task name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to add hazard task.", errors);

                var added = context.HATasks.Add(item);
                context.SaveChanges();
                return added.TaskID.ToString();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Tasks_Update(HATask item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.TaskName))
                {
                    errors.Add("Task name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to update hazard task.", errors);

                var attached = context.HATasks.Attach(item);
                var matchingWithExistingValues = context.Entry<HATask>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
