using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using Interface;
using Engine;
using Engine.BLL;
using Engine.DAL;
using Engine.Entities;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        var manager = new UserManager();
        var user = new ApplicationUser() { UserName = UserName.Text };
        IdentityResult result = manager.Create(user, Password.Text);
        if (result.Succeeded)
        {
            CreateEmployee();
            IdentityHelper.SignIn(manager, user, isPersistent: false);
            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        }
        else
        {
            ErrorMessage.Text = result.Errors.FirstOrDefault();
        }
    }



    public void CreateEmployee()
    {
        Employee employee = new Employee()
        {
            FirstName = EmployeeFirstNameTextBox.Text,
            LastName = EmployeeLastNameTextBox.Text,
            LogLev = LoginLevDropDown.Text,
            Email = UserName.Text,
            Password = Password.Text,
            EmployeeType = EmployeeTypeTextBox.Text,
            DepartmentCode = DepartmentDropDown.Text

            //Active_YN = ActiveDropDown.Text
        };

        var controller = new EmployeeController();
        employee.EmployeeID = int.Parse(controller.Employees_Add(employee));
        EmployeeIDTextBox.Text = employee.EmployeeID.ToString();
    }

}