using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using MySql.Data.MySqlClient;

namespace Dominio
{
    public class ModeloUsuario
    {
        UsarDatos usarDatos = new UsarDatos();
        public bool loginUser(string user, string pass)
        {
            return usarDatos.Login(user, pass);
        }
    }
}
