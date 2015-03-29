using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Engine;
using Engine.BLL;
using Engine.DAL;
using Engine.Entities;

public partial class Admin_ManageEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LookupEmployeeButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(EmployeesDropDown.Text))
        {
           
        }
        else
        {
            try
            {
                Employee info;
                EmployeeController systemmgr = new EmployeeController();
                info = systemmgr.EmployeeByEmployeeID(int.Parse(EmployeesDropDown.Text));
                EmployeeIDTextBox.Text = info.EmployeeID.ToString();
                EmployeeFirstNameTextBox.Text = info.FirstName.ToString();
                EmployeeLastNameTextBox.Text = info.LastName.ToString();
                string logLev = Convert.ToString(info.LogLev);

                if (logLev == "CHAEHA")
                {
                    // take CHAEHA
                    LoginLevDropDown.SelectedValue = "CHAEHA";
                }
                else if (logLev == "ADM")
                {
                    // take ADM
                    LoginLevDropDown.SelectedValue = "ADM";
                }
                else
                {
                    LoginLevDropDown.SelectedValue = "VO";
                }

                EmailTextBox.Text = info.Email.ToString();
                PasswordTextBox.Text = info.Password.ToString();
                EmployeeTypeTextBox.Text = info.EmployeeType.ToString();
                DepartmentDropDown.Text = info.DepartmentCode.ToString();


            }
            catch (Exception ex)
            {
                
            }
        }
    }

    public void UpdateEmployee()
    {
        MessageUserControl.TryRun(() =>
        {
        Employee employee = new Employee()
        {
            EmployeeID = Convert.ToInt32(EmployeeIDTextBox.Text),
            FirstName = EmployeeFirstNameTextBox.Text,
            LastName = EmployeeLastNameTextBox.Text,
            LogLev = LoginLevDropDown.Text,
            Email = EmailTextBox.Text,
            Password = PasswordTextBox.Text,
            EmployeeType = EmployeeTypeTextBox.Text,
            DepartmentCode = DepartmentDropDown.Text         
                      
        };

        var controller = new EmployeeController();
        controller.Employees_Update(employee);
        }, "Success", "Employee has been updated.");
    }

    protected void UpdateEmployeeButton_Click(object sender, EventArgs e)
    {
        UpdateEmployee();
    }
}