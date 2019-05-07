using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementLite.Windows.BL
{
    class CMConnection
    {
        public SqlConnection cnn = new SqlConnection();
        public SqlCommand    cmd = new SqlCommand();
    }

    class CMConnectionManager
    {
        private static string db = "Server=ERNESTOSQL;Database=ClinicManagementLite;Integrated Security=true";

        public static CMConnection getConnection(string text, CommandType type = CommandType.StoredProcedure)
        {
            CMConnection connection = new CMConnection();

            connection.cnn.ConnectionString = db;
            connection.cmd.Connection = connection.cnn;
            connection.cmd.CommandType = type;
            connection.cmd.CommandText = text;

            return connection;
        }
    }
}
