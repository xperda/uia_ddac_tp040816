using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIA
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Response.Redirect("Reservation.aspx");
            }
            else
            {
                lblmsgreserve.Visible = true;
                
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Response.Redirect("View.aspx");
            }
            else
            {
                lblmsgview.Visible = true;
            }
        }

        protected void btnFlight_Click(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Response.Redirect("Flight.aspx");
            }
            else
            {
                lblmsgflight.Visible = true;
            }
        }
    }
}