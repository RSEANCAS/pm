using pm.util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace pm.bl
{
    public class Conexion
    {
        static string nameConnection = AppSettings.Get<string>("nameConnection");
        static string connectionString = ConfigurationManager.ConnectionStrings[nameConnection].ConnectionString;
        protected SqlConnection cn = new SqlConnection(connectionString);
    }
}
