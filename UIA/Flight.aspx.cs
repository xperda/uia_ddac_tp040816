using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIA
{
    public partial class Flight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected Flight()
        {
            DataTable dbt = new DataTable("Flights");
            dbt.Columns.Add("FlightID");
            dbt.Columns.Add("DepatureTime");
            dbt.Columns.Add("ArrivalTime");
            dbt.Columns.Add("Destination");
            dbt.Columns.Add("Status");

            flightView.DataSource = dbt;
            flightView.DataBind();

        }
    }
}