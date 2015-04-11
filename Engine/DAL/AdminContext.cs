using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

#region Additional Namespaces
using Engine.BLL;
using Engine.Entities;
using System.Data.Entity;
#endregion

namespace Engine.DAL
{
    internal class AdminContext : DbContext
    {

        public AdminContext()
            : base("name=HazardAssessmentDB")
        {
            Database.SetInitializer<AdminContext>(null);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<HAEnvironment> HAEnvironments { get; set; }
        public DbSet<HAFocusArea> HAFocusAreas { get; set; }
        public DbSet<HAPerformer> HAPerformers { get; set; }
        public DbSet<HATask> HATasks { get; set; }
        public DbSet<HazardAssessment> HazardAssessments { get; set; }
        public DbSet<HAPotentialHazard> HAPotentialHazards { get; set; }
        public DbSet<HAAdministrativeHazard> HAAdministrativeHazards { get; set; }
        public DbSet<HAEngineeringHazard> HAEngineeringHazards { get; set; }
        public DbSet<HAOtherHazard> HAOtherHazards { get; set; }
        public DbSet<HAssessments> HAssessment { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //insert context
        }
    }
}
