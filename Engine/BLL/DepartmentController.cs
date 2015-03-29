using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Engine;
using Engine.Entities;
using Engine.DAL;
using System.ComponentModel;
#endregion

namespace Engine.BLL
{
    [DataObject]
    public class DepartmentController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Department> Department_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.Departments.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Department DepartmentByDepartmentCode(string DepartmentCode)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.Departments.Find(DepartmentCode);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string Departments_Add(Department item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.DepartmentName) || string.IsNullOrEmpty(item.DepartmentCode))
                {
                    errors.Add("Department fields cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to add department.", errors);
               
                var added = context.Departments.Add(item);
                context.SaveChanges();
                return added.DepartmentCode;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Departments_Update(Department item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.DepartmentName))
                {
                    errors.Add("Department fields cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to update department.", errors);

                var attached = context.Departments.Attach(item);
                var matchingWithExistingValues = context.Entry<Department>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
