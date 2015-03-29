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
    public class SearchHAFormByDepartmentController
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
        public HazardAssessment HAFormByDepartmentCode(string DepartmentCode)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HazardAssessments.Find(DepartmentCode);
            }
        }
    }
}
