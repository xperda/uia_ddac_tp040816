using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIA
{
    // Code reference from http://www.c-sharpcorner.com/UploadFile/47548d/simple-insert-select-update-and-delete-in-Asp-Net-using-mysq/
    public partial class Reservation : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ToString());
        SqlDataAdapter da;
        DataTable dt;
        string username;

        protected void Page_Load(object sender, EventArgs e)
        {
            username = Session["user"].ToString();
            BindGridView();
        }

        private void BindGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "SELECT * FROM [flight]";
                da = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                da.Fill(dt);
                reservationGrid.DataSource = dt;
                reservationGrid.DataBind();

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

        protected void reservationGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                GridViewRow row = reservationGrid.SelectedRow;
                int flightID;
                int.TryParse(row.Cells[1].Text,out flightID);
                conn.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO [reservation]([username],[fullname],[passportNo],[flightID],[timeofDepature],[timeofArrival],[destination])");
                query.AppendLine("SELECT u.[username],u.[fullname],u.[passportNo],f.[flightID],f.[timeofDepature],f.[timeofArrival],f.[destination]");
                query.AppendLine("FROM [user] u , [flight] f ");
                query.AppendLine("WHERE u.username =@username and f.flightID =@flightID;");

   
                SqlCommand cmd = new SqlCommand(query.ToString(),conn);
                cmd.Parameters.AddWithValue("@username",username);
                cmd.Parameters.AddWithValue("@flightID",flightID);
                
                cmd.ExecuteNonQuery();

                
                    labeldisplay.Text = "Flight " + flightID + " has been reserved";
                    labeldisplay.Visible = true;
                    cmd.Dispose();
               
            }
            catch (SqlException ex)
            {
                Console.Write(ex.ToString());
                labeldisplay.Text = "Failed to Make Reservation";
                labeldisplay.Visible = true;
            }
            finally
            {
                conn.Close();
                
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Members.aspx");
        }

    }

   
}