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
    public class EnvironController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HAEnvironment> Environ_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAEnvironments.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HAEnvironment EnvironmentByEnvironmentID(int EnvironmentID)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAEnvironments.Find(EnvironmentID);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string Environment_Add(HAEnvironment item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.EnvironmentName))
                {
                    errors.Add("Environment name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to add environment.", errors);

                var added = context.HAEnvironments.Add(item);
                context.SaveChanges();
                return added.EnvironmentID.ToString();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Environs_Update(HAEnvironment item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.EnvironmentName))
                {
                    errors.Add("Environment name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to update environment.", errors);

                var attached = context.HAEnvironments.Attach(item);
                var matchingWithExistingValues = context.Entry<HAEnvironment>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
