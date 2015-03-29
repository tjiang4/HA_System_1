using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HazardAssessment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreationDateLabel.Text = Convert.ToString(DateTime.Today);

        cookieLabel.Text = User.Identity.Name;

        //if (User.Identity.IsAuthenticated)
        //{
        //    cookieLabel.Text = "Home page for " + User.Identity.Name;
        //}
        //else
        //{
        //    cookieLabel.Text = "Home page for guest user.";
        //}

    }
  
}