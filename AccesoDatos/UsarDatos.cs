using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace AccesoDatos
{
    public class UsarDatos : ConexionMYSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection()) //devuelve MySqlConnection
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName = @user AND Password = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows; // si hay filas, el login es correcto
                    }
                }
            }
        }
    }
}
