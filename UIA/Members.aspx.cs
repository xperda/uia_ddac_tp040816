using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIA
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblusernamedisplay.Text = "Welcome " +Session["user"].ToString();
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("Reservation.aspx");
           
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
          
                Response.Redirect("View.aspx");
          
           
        }

        protected void btnFlight_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Flight.aspx");
          
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Default.aspx");
        }
    }
}