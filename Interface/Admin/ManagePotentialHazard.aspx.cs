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

public partial class Admin_ManagePotentialHazard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LookupPotentialHazardButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PotentialHazardsDropDown.Text))
        {
            
        }
        else
        {
            try
            {
                HAPotentialHazard info;
                PotentialHazardController systemmgr = new PotentialHazardController();
                info = systemmgr.PotentialHazardByPotentialHazardID(int.Parse(PotentialHazardsDropDown.Text));
                PotentialHazardIDTextBox.Text = info.PotentialHazardID.ToString();
                PotentialHazardNameTextBox.Text = info.PotentialHazardName.ToString();
                DefinationTextBox.Text = info.Defination.ToString();
                SchoolTextBox.Text = info.School.ToString();
              
            }
            catch (Exception ex)
            {
                
            }
        }
    }

    protected void AddPotentialHazardButton_Click(object sender, EventArgs e)
    {
        CreatePotentialHazard();
    }

    public void CreatePotentialHazard()
    {
         MessageUserControl.TryRun(() =>
        {
        HAPotentialHazard potentialhazard = new HAPotentialHazard()
        {
            PotentialHazardName = PotentialHazardNameTextBox.Text,
            Defination = DefinationTextBox.Text,
            School = SchoolTextBox.Text
        };

        var controller = new PotentialHazardController();
        potentialhazard.PotentialHazardID = int.Parse(controller.PotentialHazards_Add(potentialhazard));
        }, "Success", "Potential Hazard has been created.");
    }

    public void UpdatePotentialHazard()
    {

            MessageUserControl.TryRun(() =>
            {
            HAPotentialHazard potentialhazard = new HAPotentialHazard()
            {
                PotentialHazardID = int.Parse(PotentialHazardIDTextBox.Text),
                PotentialHazardName = PotentialHazardNameTextBox.Text,
                Defination = DefinationTextBox.Text,
                School = SchoolTextBox.Text
                
            };

            var controller = new PotentialHazardController();
            controller.PotentialHazards_Update(potentialhazard);
            }, "Success", "Performer has been updated.");
 
    }

    protected void UpdatePotentialHazardButton_Click(object sender, EventArgs e)
    {
        UpdatePotentialHazard();
    }
}