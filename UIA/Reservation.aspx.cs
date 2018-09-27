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

        protected void lnkReserve_Click(object sender, EventArgs e)
        {
            try
            {
              //  int flightID = Convert.ToInt32(reservationGrid.DataKeys[e.RowIndex].Value);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO [reservation](flightID,timeofDepature,timeofArrival,destination) VALUES (SELECT flightID,timeofDepature,timeofArrival,destination FROM [flights] WHERE flightID =");
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                BindGridView();
            }
            catch (SqlException ex)
            {

                Console.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

protected void reservationGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try {
                conn.Open();
                int flightID = Convert.ToInt32(reservationGrid.DataKeys[e.RowIndex].Value);
                SqlCommand cmd2 = new SqlCommand("DELETE FROM [flights] WHERE flightID ="+flightID);    
                cmd2.ExecuteNonQuery();            
                cmd2.Dispose();
                BindGridView();

            } catch (SqlException ex) {

                Console.Write(ex.ToString());
            } finally {
                conn.Close();
            }

        }
    }

   
}