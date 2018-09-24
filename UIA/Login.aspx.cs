using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace UIA
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void initializeTextBoxes()
        {
            tbloginusername.Text = String.Empty;
            tbloginpassword.Text = String.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}