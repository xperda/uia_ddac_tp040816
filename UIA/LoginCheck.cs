using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace UIA
{
    public class LoginCheck
    {
        private string password;
        private string username;
        private string enteredPassword;
        private string enteredUsername;
        private string connectionString;
    
     

    //default constructor
    public LoginCheck()
        {
            password = string.Empty;
            username = string.Empty;
            enteredPassword = string.Empty;
            enteredUsername = string.Empty;
            connectionString = ConfigurationSettings.AppSettings["connection_string"];
            gateway = new Gateway(connectionString);
        }
    //override constructor
        public LoginCheck(string enteredPassword, string enteredUsername)
        {
            connectionString = ConfigurationSettings.AppSettings["connection_string"];
            gateway = new Gateway(connectionString);

            this.enteredUsername = enteredUsername;
            this.enteredPassword = enteredPassword;
  
        }
}