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
        DataSet dt;
        // Code reference from http://www.c-sharpcorner.com/UploadFile/47548d/simple-insert-select-update-and-delete-in-Asp-Net-using-mysq/
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [flight]",conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataSet();
                da.Fill(dt);
                flightGrid.DataSource = dt;
                flightGrid.DataBind();

            }
            catch (SqlException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

    }
}