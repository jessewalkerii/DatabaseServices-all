using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DatabaseServicesAPI.Models;

namespace DatabaseServicesAPI.Classes
{
    public static class DBUtils
    {
        public static SqlConnection GetSqlConnection(String SQLServer, String Database)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLServer;
            builder.InitialCatalog = Database;
            builder.IntegratedSecurity = true;
            SqlConnection thisConnection = new SqlConnection(builder.ConnectionString);
            thisConnection.Open();

            return thisConnection;
        }
        public static SqlConnection GetSqlConnection(String SQLServer)
        {
            return GetSqlConnection(SQLServer, "master");
        }
    }
}