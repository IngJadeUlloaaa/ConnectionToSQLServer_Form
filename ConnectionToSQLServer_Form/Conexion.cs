using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionToSQLServer_Form
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection("SERVER=INGJADE;DATABASE=Contactos;integrated security=true;");
            conn.Open();
            return conn;
        }
    }
}
