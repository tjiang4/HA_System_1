using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Engine;
using Engine.BLL;
using Engine.DAL;
using Engine.Entities;

public partial class Admin_ManagePerformer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LookupPerformerButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PerformerDropDown.Text))
        {
           
        }
        else
        {
            try
            {
                HAPerformer info;
                PerformerController systemmgr = new PerformerController();
                info = systemmgr.PerformerByPerformerID(int.Parse(PerformerDropDown.Text));
                PerformerIDTextBox.Text = info.PerformerID.ToString();
                PerformerNameTextBox.Text = info.PerformerName.ToString();

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

    protected void AddPerformerButton_Click(object sender, EventArgs e)
    {
        CreatePerformer();
    }

    public void CreatePerformer()
    {
        MessageUserControl.TryRun(() =>
            {
            HAPerformer performer = new HAPerformer()
            {
                PerformerName = PerformerNameTextBox.Text,
                Active_YN = ActiveDropDown.Text
            };

            var controller = new PerformerController();
            performer.PerformerID = int.Parse(controller.Performers_Add(performer));
            PerformerIDTextBox.Text = performer.PerformerID.ToString();
            }, "Success", "Performer has been created.");
    }

    public void UpdatePerformer()
    {
        MessageUserControl.TryRun(() =>
        {
        HAPerformer performer = new HAPerformer()
        {
            PerformerID = int.Parse(PerformerIDTextBox.Text),
            PerformerName = PerformerNameTextBox.Text,
            Active_YN = ActiveDropDown.Text
        };

        var controller = new PerformerController();
        controller.Performers_Update(performer);
        }, "Success", "Performer has been updated.");
    }

    protected void UpdatePerformerButton_Click(object sender, EventArgs e)
    {
        UpdatePerformer();
    }
}