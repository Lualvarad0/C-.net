using System;
using Examen3.product;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto.product;
using System.IO;

namespace Examen3

{
    public partial class Form1 : Form
    {
        //public Product pro;
       
        public Form1()
        {
            InitializeComponent();
        }

        public void RefrescarListado()
        {

            //List<Carros> lista = new List<Carros>();

            MySqlDataAdapter _comando = new MySqlDataAdapter(String.Format(
               "SELECT Id, nombre, precio, estado FROM producto "), Conexion.ObtenerConexion());
            DataTable dt = new DataTable();
            _comando.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


        }

        public void Limpiar()
        {
            txt_IdProducto.Clear();
            txtNombreProducto.Clear();
            txt_PrecioProcuto.Clear();
            txt_EstadoProducto.Clear();
            txt_IdProducto.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Listar();
        }
        //listar
        public static List<Product> Listar(){
            List<Product> lista = new List<Product>();

        MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT Id, nombre, precio, estado FROM producto "), Conexion.ObtenerConexion());
        MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Product pro = new Product();

        pro.Id = _reader.GetString(0);
                pro.nombre = _reader.GetString(1);
                pro.Precio = _reader.GetString(2);
                pro.Estado = _reader.GetString(4);

                lista.Add(pro);

            }
            return lista;

        }


private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Id = txt_IdProducto.Text.Trim();
            pro.nombre = txtNombreProducto.Text.Trim();
            pro.Precio = txt_PrecioProcuto.Text.Trim();
            pro.Estado = txt_EstadoProducto.Text.Trim();
            int res = pro.Agregar(pro);

            if (res > 0)
            {
                MessageBox.Show(" Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                RefrescarListado();
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();

            MessageBox.Show(" Usted se ha conectado con éxito ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefrescarListado();
            Refresh();
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = @"C:\Users\carlo\Desktop\productos.txt";
            void GuardarDatos(List<Product> productos)
            {
                StreamWriter nombreArchivo;
                nombreArchivo = File.AppendText("productos.txt");
            }
        }
    }
}
