using AngleSharp.Common;
using com.sun.tools.javac.file;
using java.awt;
using javax.management;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Documents;
using Newtonsoft.Json.Linq;
using sun.security.util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Form_builder_Test.DBHelper
{


    public static class SQLHelper
    {
        private static string endpoint;
        private static string primarykey;
        private static CosmosClient cosmosClient;
        public static SqlConnection SqlConnection;

        static SQLHelper()
        {
            string endpoint = ConfigurationManager.AppSettings["endpoint"];
            string primarykey = ConfigurationManager.AppSettings["primarykey"];
            try
            {
               // cosmosClient = new CosmosClient(endpoint, primarykey, new CosmosClientOptions() { AllowBulkExecution = true, ConnectionMode = ConnectionMode.Gateway });
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                
            }
        }
        public static SqlConnection SqlConnect(this SqlConnection SqlConnection)
        {
            try
            {
                SqlConnection = new SqlConnection("Server=tcp:b105d01sql-df-shared.database.windows.net,1433;Initial Catalog=b105d01db-df-shared;Persist Security Info=False;User ID=b105d01-sql-admin;Password=2G4zM2Xnsc@D7w;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                SqlConnection.Open();
            }
            catch (Exception e) { }
            return SqlConnection;

        }
        //public static async Task<DataTable> ExecuteStoredProceduretoDataTable(string query)
        //{
        //    SqlConnection sqlConnObj = null;
        //    DataTable dataTable = new DataTable();
        //    try
        //    {
        //        SqlConnection sqlConnection;
        //        sqlConnObj = (sqlConnection = new SqlConnection("Server=tcp:b105d01sql-df-shared.database.windows.net,1433;Initial Catalog=b105d01db-df-shared;Persist Security Info=False;User ID=b105d01-sql-admin;Password=2G4zM2Xnsc@D7w;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
        //        using (sqlConnection)
        //        {
        //            SqlCommand sqlCmd = new SqlCommand(query, sqlConnObj)
        //            {
        //                CommandType = CommandType.StoredProcedure
        //            };

        //            await sqlConnObj.OpenAsync();
        //            SqlDataReader reader = sqlCmd.ExecuteReader();
        //            dataTable.Load(reader);
        //        }

        //        return dataTable;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        sqlConnObj.Close();
        //    }
        //}
        public static DataTable ExecuteStoredProceduretoDataTable(string query)
        {
            DataTable dataTable = new DataTable();
            string connectionString = "Server=tcp:b105d01sql-df-shared.database.windows.net,1433;Initial Catalog=b105d01db-df-shared;Persist Security Info=False;User ID=b105d01-sql-admin;Password=2G4zM2Xnsc@D7w;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //string query = "SELECT * FROM YourTableName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Load data into DataTable
                    dataTable.Load(reader);

                    // Close the reader
                    reader.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataTable;
        }
        public static string ReadDataSQL(string query)
        {
            string a=null;
            SqlConnection =SqlConnect(SqlConnection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = SqlConnection;
           cmd.CommandText = query;
            SqlDataReader dr = cmd.ExecuteReader();        
            while (dr.Read())
            {
                 a= dr["RSPID"].ToString();
            }
            return a;
        }


        public static void ReadDataSQL1(string query)
        {
            string constr = @"Data Source=.;Initial Catalog=test;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from  Items", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            // return a;
        }



    }

}

