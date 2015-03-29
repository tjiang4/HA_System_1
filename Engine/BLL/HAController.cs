using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Engine.Entities;
using Engine.DAL;
using System.ComponentModel;
using Engine.Entities.DTOs;
#endregion

namespace Engine.BLL
{
    [DataObject]
    public class HAController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HA> LoadAuthority(string email)
        {
            using (var context = new AdminContext())
            {
                var data = from od in context.Employees
                           where od.Email == email
                           select new HA()
                           {
                               FirstName = od.FirstName,
                               LastName = od.LastName
                           };

                return data.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HA> List_ControlMeasures()
        {
            using (var context = new AdminContext())
            {
                var data = from od in context.HAAdministrativeHazards
                           from en in context.HAEngineeringHazards
                           from oh in context.HAOtherHazards
                           select new HA()
                           {
                               AdministrativeHazardID = od.AdministrativeHazardID,
                               AdministrativeHazardName = od.AdministrativeHazardName

                           };

                return data.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<HA> DepartmentByAuthority(string email)
        {
            using (AdminContext context = new AdminContext())
            {
                var data = from od in context.Employees
                           where od.Email == email
                           select new HA()
                           {
                               DepartmentCode = od.DepartmentCode

                           };

                return data.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HazardAssessment HAByHAID(int HazardAssessmentID)
        {
            using (AdminContext context = new AdminContext())
            {
                return context.HazardAssessments.Find(HazardAssessmentID);
            }
        }


        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string HA_Add(HazardAssessment item)
        {
            using (AdminContext context = new AdminContext())
            {
                var added = context.HazardAssessments.Add(item);
                context.SaveChanges();
                return added.HazardAssessmentID.ToString();
            }
        }
    }
}
