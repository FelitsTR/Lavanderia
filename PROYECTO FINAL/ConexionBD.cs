using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class ConexionBD
    {
        public MySqlConnection conexion;
        //string conec;

        public void CrearConexion()
        {
            string conec = "Server=localhost;database=lavanderia;uid=root;pwd=;";
            conexion = new MySqlConnection(conec);
            conexion.Open();
        }

        public MySqlConnection GetConnection()
        {
            Console.WriteLine("conexión creada");
            Console.ReadLine();
            return conexion;
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }


    }
}

