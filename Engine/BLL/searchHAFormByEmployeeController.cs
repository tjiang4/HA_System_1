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
    public class SearchHAFormByEmployeeController
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
        public HazardAssessment HAFormByEmployeeId(int EmployeeId)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HazardAssessments.Find(EmployeeId);
            }
        }
    }
}
