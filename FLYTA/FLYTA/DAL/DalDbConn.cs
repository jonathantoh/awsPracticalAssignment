using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace FLYTA.DAL
{
    public class DalDbConn
    {
        public SqlConnection GetConnection()
        {
            SqlConnection dbConn;
            String connString = ConfigurationManager.ConnectionStrings["FLY-TA"].ConnectionString;

            dbConn = new SqlConnection(connString);

            return dbConn;
        }
    }
}