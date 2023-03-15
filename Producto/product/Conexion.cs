using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Producto.product
{
    class Conexion
    {
        private string cadenaConexion = "Server=localhost;port=3306;Database=ecotec;User id=root;Password=";
        private bool estaConectado = true;
        private MySqlConnection conexion;

        public Conexion()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                Console.WriteLine("Exito al conectarse");
            }
            catch (Exception e)
            {
                estaConectado = false;
                Console.WriteLine(e.Message);
            }
        }

        protected void EjecutarConsulta(string consulta)
        {
            if (estaConectado)
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
            }
        }

        protected MySqlDataReader ObtenerRegistros(string consulta)
        {
            if (estaConectado)
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                return comando.ExecuteReader();
            }
            else
            {
                return null;
            }
        }

        ~Conexion()
        {
            if (estaConectado)
            {
                conexion.Close();
            }
        }
    }
}
