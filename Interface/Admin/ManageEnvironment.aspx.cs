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

public partial class Admin_ManageEnvironment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LookupEnvironmentButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(EnvironmentsDropDown.Text))
        {
           
        }
        else
        {
            try
            {
                HAEnvironment info;
                EnvironController systemmgr = new EnvironController();
                info = systemmgr.EnvironmentByEnvironmentID(int.Parse(EnvironmentsDropDown.Text));
                EnvironmentIDTextBox.Text = info.EnvironmentID.ToString();
                EnvironmentNameTextBox.Text = info.EnvironmentName.ToString();

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

    protected void AddEnvironmentButton_Click(object sender, EventArgs e)
    {
        CreateEnvironment();
    }

    public void CreateEnvironment()
    {
        MessageUserControl.TryRun(() =>
        {
        HAEnvironment environment = new HAEnvironment()
        {
            EnvironmentName = EnvironmentNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new EnvironController();
        environment.EnvironmentID = int.Parse(controller.Environment_Add(environment));
        EnvironmentIDTextBox.Text = environment.EnvironmentID.ToString();
        }, "Success", "Environment has been created.");
    }

    public void UpdateEnvironment()
    {
        MessageUserControl.TryRun(() =>
        {
        HAEnvironment environment = new HAEnvironment()
        {
            EnvironmentID = int.Parse(EnvironmentIDTextBox.Text),
            EnvironmentName = EnvironmentNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new EnvironController();
        controller.Environs_Update(environment);
        }, "Success", "Environment has been updated.");
    }

    protected void UpdateEnvironmentButton_Click(object sender, EventArgs e)
    {
        UpdateEnvironment();
    }
}