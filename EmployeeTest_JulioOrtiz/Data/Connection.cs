using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EmployeeTest_JulioOrtiz
{
    public class Connection
    {
        //creating an object to use for initialice DB connection
        private static SqlConnection objConnect;
        //variable to save the error in the connection
        private static string error;

        public static SqlConnection getConnection()
        {
            if (objConnect != null)
            {
                return objConnect;
            }
            objConnect = new SqlConnection();
            objConnect.ConnectionString = "Server=SV-LAPTOP74;DataBase=EmployeeTest;Integrated Security=true";
            try
            {
                objConnect.Open();
                return objConnect;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }

        public static void closeConnection()
        {
            if (objConnect != null)
            {
                objConnect.Close();
            }
        }
    }
}