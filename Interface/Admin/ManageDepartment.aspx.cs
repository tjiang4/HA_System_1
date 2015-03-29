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

public partial class Admin_ManageDepartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void LookupDepartmentButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(DepartmentsDropDown.Text))
        {
           
        }
        else
        {
            try
            {
                Department info;
                DepartmentController systemmgr = new DepartmentController();
                info = systemmgr.DepartmentByDepartmentCode(DepartmentsDropDown.Text);
                DepartmentCodeTextBox.Text = info.DepartmentCode.ToString();
                DepartmentNameTextBox.Text = info.DepartmentName.ToString();

                char activeInactive = Convert.ToChar(info.Active_YN);

               if (activeInactive == 'Y')
               {
                   // take char Y
                   ActiveDropDown.SelectedValue = "Y";
               }
               else
               {
                   // take char N
                   ActiveDropDown.SelectedValue = "N";
               }
               
                   
           }            
            catch (Exception ex)
            {
               
            }
        }
    }

    protected void AddDepartmentButton_Click(object sender, EventArgs e)
    {
       
            CreateDepartment();
    }

    public void CreateDepartment()
    {
        MessageUserControl.TryRun(() =>
        {
        Department department = new Department()
            {
                DepartmentCode = DepartmentCodeTextBox.Text,
                DepartmentName = DepartmentNameTextBox.Text,
                Active_YN = ActiveDropDown.Text
            };

                var controller = new DepartmentController();
                department.DepartmentCode = controller.Departments_Add(department);
                DepartmentCodeTextBox.Text = department.DepartmentCode.ToString();

        }, "Success", "Department has been created.");
    }

    public void UpdateDepartment()
    {
        MessageUserControl.TryRun(() =>
        {
        Department department = new Department()
        {
            DepartmentCode = DepartmentCodeTextBox.Text,
            DepartmentName = DepartmentNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new DepartmentController();
        controller.Departments_Update(department);
        }, "Success", "Department has been updated.");
    }

    protected void UpdateDepartmentButton_Click(object sender, EventArgs e)
    {
        UpdateDepartment();
    }
}