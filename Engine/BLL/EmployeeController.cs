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
    public class EmployeeController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Employee> Employee_List()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.Employees.ToList();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Employee EmployeeByEmployeeID(int EmployeeID)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.Employees.Find(EmployeeID);
            }
        }


        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string Employees_Add(Employee item)
        {
            using (AdminContext context = new AdminContext())
            {
                var added = context.Employees.Add(item);
                context.SaveChanges();
                return added.EmployeeID.ToString();                
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Employees_Update(Employee item)
        {
            using (AdminContext context = new AdminContext())
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(item.FirstName) || string.IsNullOrEmpty(item.LastName)
                    || string.IsNullOrEmpty(item.LogLev) || string.IsNullOrEmpty(item.Email)
                    || string.IsNullOrEmpty(item.Password) || string.IsNullOrEmpty(item.EmployeeType)
                    || string.IsNullOrEmpty(item.DepartmentCode))
                {
                    errors.Add("Employee fields cannot be left empty.");
                }

                if (errors.Count > 0)
                    throw new BusinessRuleException("Unable to update employee.", errors);

                context.Entry<Employee>(context.Employees.Attach(item)).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }    
    }
}
