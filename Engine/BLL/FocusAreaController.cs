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
    public class FocusAreaController
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
        public HAFocusArea FocusAreaByFocusAreaID (int FocusAreaID)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HAFocusAreas.Find(FocusAreaID);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string FocusAreas_Add(HAFocusArea item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.FocusAreaName))
                {
                    errors.Add("Focus area name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to add focus area.", errors);

                var added = context.HAFocusAreas.Add(item);
                context.SaveChanges();
                return added.FocusAreaID.ToString();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void FocusAreas_Update(HAFocusArea item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.FocusAreaName))
                {
                    errors.Add("Focus area name cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to update focus area.", errors);

                var attached = context.HAFocusAreas.Attach(item);
                var matchingWithExistingValues = context.Entry<HAFocusArea>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
