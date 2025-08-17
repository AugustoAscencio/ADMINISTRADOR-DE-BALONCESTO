using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public abstract class ConexionMYSQL
    {
        private readonly string connectionString;

        public ConexionMYSQL()
        {
            // Cambia los valores según tu configuración de MySQL
            connectionString = "Server=127.0.0.1;Port=3306;Database=DatosSQL;Uid=root;Pwd=27182;";

        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
