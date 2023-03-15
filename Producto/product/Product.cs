using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen3.product
{
    class Product
    {
        public string Id { get; set; }
        public string nombre { get; set; }
        public string Precio { get; set; }
        public string Estado { get; set; }
        public Product()
        {

        }

        public Product(string pId, string pNombre, string pPrecio, string pEstado)
        {
            this.Id = pId;
            this.nombre = pNombre;
            this.Precio = pPrecio;
            this.Estado = pEstado;
        }

        public int Agregar(Product producto)
        {
            int retorno = 0;
            MySqlConnection add = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into autos (nombre, precio, estado) values ('{0}','{1}','{2}')",
            producto.nombre, producto.Precio, producto.Precio), add);
            retorno = comando.ExecuteNonQuery();
            add.Close();
            return retorno;
        }

       

    }
}
