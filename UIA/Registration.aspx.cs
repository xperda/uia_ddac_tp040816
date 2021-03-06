﻿using System;
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
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [user] ([username], [password],[fullname],[passportNo]) VALUES(@username, @password,@fullname,@passportNo);", con);
                    cmd.Parameters.AddWithValue("@username", tbusername.Text.ToString());
                    cmd.Parameters.AddWithValue("@password", tbpassword.Text.ToString());
                    cmd.Parameters.AddWithValue("@fullname", tbfullname.Text.ToString());
                    cmd.Parameters.AddWithValue("@passportNo", tbpassport.Text.ToString());
                    
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