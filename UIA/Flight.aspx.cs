using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIA
{
   

    public partial class Flight : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ToString());
        SqlDataAdapter da;
        DataSet dst;
        // Code reference from https://www.aspsnippets.com/Articles/Display-data-in-GridView-in-ASPNet-from-SQL-Server.aspx
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void flightView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            flightView.PageIndex = e.NewPageIndex;
  
            string query = "SELECT [flightID],[timeofDepature],[timeofArrival],[destination],[status] FROM [dbo].[flight]";
            da = new SqlDataAdapter(query, conn);
            dst = new DataSet();
            da.Fill(dst);
            flightView.DataSource = dst;
            flightView.DataBind();
        } 
    }
}