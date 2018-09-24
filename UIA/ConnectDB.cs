using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace UIA
{
    public class ConnectDB
    {
        static void connectDB()
        {
            try
            {
                //Source code reference: https://docs.microsoft.com/en-us/azure/sql-database/sql-database-connect-query-dotnet-visual-studio
                //Source code reference: https://stackoverflow.com/questions/18605533/connecting-to-sql-server-using-windows-authentication
               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
                       
               conn.Open();

               submitSQLQuery(conn,"Creating Tables...",createQueries());
               submitSQLQuery(conn,"Populating data...",insertDummyData());

                conn.Close();
   

            }//end of try
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }//end of catch
        }//end of main
        public static string createQueries()
        {
            return @" CREATE TABLE [user] (
                [userID][int] NOT NULL,
                [password] [varchar] (50) NULL,
	            [fullname] [varchar] (50) NULL,
	            [passportNo] [varchar] (50) NULL,
	            CONSTRAINT PK_user PRIMARY KEY(userID)
                ) 

                CREATE TABLE[flight] (
                    [flightID][int] NOT NULL,
                    [timeofDepature] [varchar] (200) NULL,
	                [timeofArrival] [varchar] (200) NULL,
	                [destination] [varchar] (50) NULL,
	                [status] [varchar] (50) NULL,
	                CONSTRAINT PK_flight PRIMARY KEY(flightID)
                )	

                CREATE TABLE[reservation] (
                    [fullname][varchar](50) NULL,
	                [passportNo] [varchar] (50) NULL,
	                [flightID] [int] NOT NULL references flight(flightID),
	                [timeofDepature] [varchar] (200) NULL,
	                [timeofArrival] [varchar] (200) NULL,
	                [destination] [varchar] (50) NULL,
                ) ";
        }//end of createqueries
        public static string insertDummyData()
        {
            return @"INSERT INTO [dbo].[flight](
                [flightID],
	            [timeofDepature] ,
	            [timeofArrival] ,
	            [destination] ,
	            [status]
                ) VALUES(1, '14 January 2017 1:30pm' , '14 January 2017 2:45pm' ,'Moscow','Active');

                INSERT INTO [dbo].[flight](
                [flightID],
	            [timeofDepature] ,
	            [timeofArrival] ,
	            [destination] ,
	            [status]
                ) VALUES(2, '14 January 2017 2:30pm' , '14 January 2017 4:45pm' ,'Frankfurt','Active');

                INSERT INTO [dbo].[flight](
                [flightID],
	            [timeofDepature] ,
	            [timeofArrival] ,
	            [destination] ,
	            [status]
                ) VALUES(3, '15 January 2017 11:30am' , '15 January 2017 1:45pm' ,'Paris','Active');

                INSERT INTO [dbo].[flight](
                [flightID],
	            [timeofDepature] ,
	            [timeofArrival] ,
	            [destination] ,
	            [status]
                ) VALUES(4, '16 January 2017 4:30pm' , '16 January 2017 8:15pm' ,'London','Active');

                INSERT INTO [dbo].[flight](
                [flightID],
	            [timeofDepature] ,
	            [timeofArrival] ,
	            [destination] ,
	            [status]
                ) VALUES(5, '17 January 2017 10:30pm' , '17 January 2017 7:00am' ,'Bejing','Active');

                INSERT INTO [UIA].[dbo].[user](
                [userID],[password],[fullname],[passportNo]
                ) VALUES(1,'password','Desmond Lim','ABCDEFGH');"; 
        }//end of insertdummydata
        static void submitSQLQuery(SqlConnection connection,string tsqlPurpose,string tsqlSourceCode,string parameterName = null,string parameterValue = null){
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("T-SQL to {0}...", tsqlPurpose);

            using (var command = new SqlCommand(tsqlSourceCode, connection))
            {
                if (parameterName != null)
                {
                    command.Parameters.AddWithValue(  // Or, use SqlParameter class.
                       parameterName,
                       parameterValue);
                }
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " = rows affected.");
               
            }
        } // endofsubmitSQLQuery
    }//end of ConnectDB class
}
