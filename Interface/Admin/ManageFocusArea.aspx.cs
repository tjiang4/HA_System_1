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

public partial class Admin_ManageFocusArea : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LookupFocusAreatButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(FocusAreasDropDown.Text))
        {
           
        }
        else
        {
            try
            {
                HAFocusArea info;
                FocusAreaController systemmgr = new FocusAreaController();
                info = systemmgr.FocusAreaByFocusAreaID(int.Parse(FocusAreasDropDown.Text));
                FocusAreaIDTextBox.Text = info.FocusAreaID.ToString();
                FocusAreaNameTextBox.Text = info.FocusAreaName.ToString();

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

    protected void AddFocusAreaButton_Click(object sender, EventArgs e)
    {
        CreateFocusArea();
    }

    public void CreateFocusArea()
    {
        MessageUserControl.TryRun(() =>
        {
        HAFocusArea focusarea = new HAFocusArea()
        {
            FocusAreaName = FocusAreaNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new FocusAreaController();
        focusarea.FocusAreaID = int.Parse(controller.FocusAreas_Add(focusarea));
        }, "Success", "Focus area has been created.");
    }

    public void UpdateFocusArea()
    {
        MessageUserControl.TryRun(() =>
        {
        HAFocusArea focusarea = new HAFocusArea()
        {
            FocusAreaID = int.Parse(FocusAreaIDTextBox.Text),
            FocusAreaName = FocusAreaNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new FocusAreaController();
        controller.FocusAreas_Update(focusarea);
        }, "Success", "Focus area has been updated.");
    }

    protected void UpdateFocusAreaButton_Click(object sender, EventArgs e)
    {
        UpdateFocusArea();
    }
}