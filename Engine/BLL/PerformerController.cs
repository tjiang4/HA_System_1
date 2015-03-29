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
    public class PerformerController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HAPerformer> Performer_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAPerformers.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HAPerformer PerformerByPerformerID (int PerformerId)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAPerformers.Find(PerformerId);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string Performers_Add(HAPerformer item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.PerformerName))
                {
                    errors.Add("Performer name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to add performer", errors);

                var added = context.HAPerformers.Add(item);
                context.SaveChanges();
                return added.PerformerID.ToString();                              
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Performers_Update(HAPerformer item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.PerformerName))
                {
                    errors.Add("Performer name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to update performer", errors);

                var attached = context.HAPerformers.Attach(item);
                var matchingWithExistingValues = context.Entry<HAPerformer>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
