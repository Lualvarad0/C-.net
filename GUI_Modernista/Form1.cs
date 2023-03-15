using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;

namespace GUI_Modernista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }

        //mover ventana a voluntad
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //fin mover pantalla
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = true;
        }

        private void btnrptVentas_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = false;
        }

        private void btnrptCompras_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = false;
        }

        private void btnrptPagos_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
