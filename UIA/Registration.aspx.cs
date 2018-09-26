using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data;

namespace UIA
{
    public partial class Registration : System.Web.UI.Page
    {
    

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ToString());
         
            try
            {
                
                if (tbfullname.Text == String.Empty && tbpassword.Text == String.Empty && tbfullname.Text == String.Empty && tbpassport.Text == String.Empty)
                {
                    Label5.Visible = true;
                }
                else
                {
                    con.Open();
                    SqlCommand query = new SqlCommand("INSERT INTO [dbo].[user] VALUES(@username, @password,@fullname,@passportNo) ", con);
                    query.Parameters.AddWithValue("username", tbusername.Text);
                    query.Parameters.AddWithValue("password", tbpassword.Text);
                    query.Parameters.AddWithValue("fullname", tbfullname.Text);
                    query.Parameters.AddWithValue("passportNo", tbpassport.Text);

                    query.ExecuteNonQuery();

                    Response.Redirect("Login.aspx");
                }
            }
            catch (SqlException ex) 
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}