using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UIA
{
    public class SqlConnection
    {
        static void Main(string[] args)
        {
            try
            {
                //Source code reference: https://docs.microsoft.com/en-us/azure/sql-database/sql-database-connect-query-dotnet-visual-studio
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "your_server.database.windows.net";
                builder.UserID = "your_user";
                builder.Password = "your_password";
                builder.InitialCatalog = "your_database";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}