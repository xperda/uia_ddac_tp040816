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
    //Code reference from https://www.c-sharpcorner.com/UploadFile/009464/how-to-make-a-login-form-using-session-in-Asp-Net-C-Sharp/
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ToString());
        SqlDataAdapter da;
        DataTable dt;
        public string userID;

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
       
            try{
         
                if(userLogin())
                {
                    Session["user"] = tbloginusername.Text;
                    Response.Redirect("Members.aspx");
                    Session.RemoveAll();
                }
                else
                {
                    loginvalid.Visible = true;

                }
                


               
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected bool userLogin()
        {
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] WHERE username=@username AND password=@password",con);
            cmd.Parameters.AddWithValue("@username", tbloginusername.Text);
            cmd.Parameters.AddWithValue("@password", tbloginpassword.Text);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Open();

            if (dt.Rows.Count > 0)
            {
               
                return true;
            }
            else
            {
                return false;
            }
   
        }
    }
}