using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROYECTO_FINAL
{
    class Conexionsql
    {
        public MySqlConnection conexion;
        public void crearconexion()
        {
            string conec = "Server=localhost;database=proyecto;uid=root;pwd=;";
            conexion = new MySqlConnection(conec);
            conexion.Open();
        }
        public void cerrarconexion()
        {
            conexion.Close();
        }
        public MySqlConnection getConexion()
        {
            System.Console.WriteLine("conexion creada");
            System.Console.ReadLine();
            return conexion;
        }
    }
}
