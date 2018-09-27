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


        protected void Page_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [reservation]",con);
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
               SqlCommand cmd = new SqlCommand("DELETE FROM [reservation] WHERE reservationID=" + rID + ";", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                viewGrid.EditIndex = -1;
                BindGridView();
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
    }
}