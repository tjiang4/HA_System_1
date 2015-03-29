﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Entities.Security;
using Engine.DAL;
using Engine.DAL.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;


namespace Engine.BLL.Security
{
    public class RoleManager : RoleManager<IdentityRole>
    {
        public RoleManager()
            : base(new RoleStore<IdentityRole>(new ApplicationDbContext()))
        {
        }

        public void AddDefaultRoles()
        {
            foreach (string roleName in SecurityRoles.DefaultSecurityRoles)
            {
                // Check if it exists
                if (!Roles.Any(r => r.Name == roleName))
                {
                    this.Create(new IdentityRole(roleName));
                }
            }
        }
    }
}
