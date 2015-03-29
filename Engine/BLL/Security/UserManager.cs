using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Entities.Security;
using Engine.DAL;
using Engine.DAL.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace eToolsSystem.BLL.Security
{

    public class UserManager : UserManager<ApplicationUser>
    {
        #region Constants
        private const string STR_DEFAULT_PASSWORD = "Pa$$word1";
        /// <summary>Requires FirstName and LastName</summary>
        private const string STR_USERNAME_FORMAT = "{0}";
        /// <summary>Requires UserName</summary>
        private const string STR_EMAIL_FORMAT = "{0}@eTools.tba";
        private const string STR_WEBMASTER_USERNAME = "Webmaster";
        #endregion

        public UserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }

        public void AddDefaultUsers()
        {
            using (var context = new AdminContext())
            {
                var employee = from data in context.Employees
                               select data;
                foreach (var person in employee)
                {
                    // Check if they exist
                    if (!Users.Any(u => u.EmployeeID.HasValue && u.EmployeeID.Value == person.EmployeeID))
                    {
                        string email = string.Format(STR_EMAIL_FORMAT, person.Email);
                        var appUser = new ApplicationUser()
                        {
                            Email = email,
                            EmployeeID = person.EmployeeID
                        };
                        // NOTE: The following needs to use the this keyword in order to have access to the extension method
                        //       Create(ApplicationUser user, string password)
                        this.Create(appUser, STR_DEFAULT_PASSWORD);
                    }
                }
                // Add a web  master user
                if (!Users.Any(u => u.Email.Equals(STR_EMAIL_FORMAT)))
                {
                    var webMasterAccount = new ApplicationUser()
                    {
                        Email = string.Format(STR_EMAIL_FORMAT)
                    };
                    this.Create(webMasterAccount, STR_DEFAULT_PASSWORD);
                }
            }
        }
    }
}
