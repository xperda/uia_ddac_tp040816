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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ToString());
        SqlDataReader dr;
  
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
     
            try
            {
                
                if (tbfullname.Text == String.Empty && tbpassword.Text == String.Empty && tbfullname.Text == String.Empty && tbpassport.Text == String.Empty)
                {
                    Label5.Visible = true;
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO [user] ([username], [password],[fullname],[passportNo]) VALUES(@username, @password,@fullname,@passportNo);", con);
                    cmd.Parameters.AddWithValue("@username", tbusername.Text);
                    cmd.Parameters.AddWithValue("@password", tbpassword.Text);
                    cmd.Parameters.AddWithValue("@fullname", tbfullname.Text);
                    cmd.Parameters.AddWithValue("@passportNo", tbpassport.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    Label5.Text = "User succesfully registered";
                    Label5.Visible = true;


                    Response.Redirect("Login.aspx");
                }
            }
            catch (SqlException ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            finally{
                con.Close();
            }

        }
    }
}