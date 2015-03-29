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
    public class PotentialHazardController
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
        public HAPotentialHazard PotentialHazardByPotentialHazardID(int PotentialHazardID)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAPotentialHazards.Find(PotentialHazardID);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string PotentialHazards_Add(HAPotentialHazard item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.PotentialHazardName) || string.IsNullOrEmpty(item.Defination) || string.IsNullOrEmpty(item.School))
                {
                    errors.Add("Fields cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to add potential hazard", errors);

                var added = context.HAPotentialHazards.Add(item);
                context.SaveChanges();
                return added.PotentialHazardID.ToString();
            }
        }

    
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void PotentialHazards_Update(HAPotentialHazard item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.PotentialHazardName) || string.IsNullOrEmpty(item.Defination) || string.IsNullOrEmpty(item.School))
                {
                    errors.Add("Fields cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to update potential hazard", errors);

                var attached = context.HAPotentialHazards.Attach(item);
                var matchingWithExistingValues = context.Entry<HAPotentialHazard>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
