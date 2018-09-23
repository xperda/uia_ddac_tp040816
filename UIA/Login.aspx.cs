using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIA
{
    public partial class Login : Page
    {

        private string connectionString = ConfigurationSettings.AppSettings["connection_string"];
        private Gateway gateway = null;

        protected void Page_Load(object sender, EventArgs e)
        {
           // gateway = new Gateway(connectionString);
        }

        protected void initializeTextFields()
        {
            tbloginusername.Text = string.Empty;
            TextBox_Password.Text = string.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbloginusername.


            if ()
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                

            }
        }
    }
}