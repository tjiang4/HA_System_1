using Engine.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Entities;
using Engine.DAL;
using Engine.Entities.Security;

namespace Engine.BLL.Security
{
    [DataObject]
    public class SecurityController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Employee> ListAllEmployees()
        {
            using (AdminContext context = new AdminContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}
