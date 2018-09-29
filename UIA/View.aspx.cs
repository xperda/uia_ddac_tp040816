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
    public partial class View : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ToString());
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
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [reservation] WHERE username=@username ;", con);
                cmd.Parameters.AddWithValue("@username",username);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                viewGrid.DataSource = dt;
                viewGrid.DataBind();

            }
            catch (SqlException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

 

        protected void reservation_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try{
               
                con.Open();
                int rID = Convert.ToInt32(viewGrid.DataKeys[e.RowIndex].Value);
               SqlCommand cmd = new SqlCommand("DELETE FROM [reservation] WHERE reservationID=@rID;", con);
                cmd.Parameters.AddWithValue("@rID", rID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                viewGrid.EditIndex= -1;
                BindGridView();

                labeldisplay.Text = "Reservation with ID " + rID + " has been cancel";
                labeldisplay.Visible = true;
                
            }
            catch (SqlException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Members.aspx");
        }
    }
}