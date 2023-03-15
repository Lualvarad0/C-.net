
namespace GUI_Modernista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Menu_Vertical = new System.Windows.Forms.Panel();
            this.SubmenuReporte = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnrptPagos = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnrptCompras = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnrptVentas = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Pagos = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Control = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.Menu_Vertical.SuspendLayout();
            this.SubmenuReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btn_Restaurar);
            this.BarraTitulo.Controls.Add(this.btn_minimizar);
            this.BarraTitulo.Controls.Add(this.btn_Maximizar);
            this.BarraTitulo.Controls.Add(this.Btn_Cerrar);
            this.BarraTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1321, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restaurar.Image")));
            this.btn_Restaurar.Location = new System.Drawing.Point(1253, 3);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Restaurar.TabIndex = 3;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1222, 4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(25, 25);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.TabStop = false;
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximizar.Image")));
            this.btn_Maximizar.Location = new System.Drawing.Point(1253, 4);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(25, 25);
            this.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Maximizar.TabIndex = 1;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1284, 4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Menu_Vertical
            // 
            this.Menu_Vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.Menu_Vertical.Controls.Add(this.btnSalir);
            this.Menu_Vertical.Controls.Add(this.SubmenuReporte);
            this.Menu_Vertical.Controls.Add(this.panel7);
            this.Menu_Vertical.Controls.Add(this.btn_Reporte);
            this.Menu_Vertical.Controls.Add(this.panel6);
            this.Menu_Vertical.Controls.Add(this.btn_Pagos);
            this.Menu_Vertical.Controls.Add(this.panel5);
            this.Menu_Vertical.Controls.Add(this.button5);
            this.Menu_Vertical.Controls.Add(this.panel4);
            this.Menu_Vertical.Controls.Add(this.button4);
            this.Menu_Vertical.Controls.Add(this.panel3);
            this.Menu_Vertical.Controls.Add(this.button3);
            this.Menu_Vertical.Controls.Add(this.panel2);
            this.Menu_Vertical.Controls.Add(this.button2);
            this.Menu_Vertical.Controls.Add(this.panel1);
            this.Menu_Vertical.Controls.Add(this.button1);
            this.Menu_Vertical.Controls.Add(this.pictureBox1);
            this.Menu_Vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Vertical.Location = new System.Drawing.Point(0, 38);
            this.Menu_Vertical.Name = "Menu_Vertical";
            this.Menu_Vertical.Size = new System.Drawing.Size(220, 744);
            this.Menu_Vertical.TabIndex = 1;
            // 
            // SubmenuReporte
            // 
            this.SubmenuReporte.Controls.Add(this.panel11);
            this.SubmenuReporte.Controls.Add(this.btnrptPagos);
            this.SubmenuReporte.Controls.Add(this.panel10);
            this.SubmenuReporte.Controls.Add(this.btnrptCompras);
            this.SubmenuReporte.Controls.Add(this.panel9);
            this.SubmenuReporte.Controls.Add(this.btnrptVentas);
            this.SubmenuReporte.Location = new System.Drawing.Point(20, 413);
            this.SubmenuReporte.Name = "SubmenuReporte";
            this.SubmenuReporte.Size = new System.Drawing.Size(200, 137);
            this.SubmenuReporte.TabIndex = 15;
            this.SubmenuReporte.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(1, 95);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 42);
            this.panel11.TabIndex = 7;
            // 
            // btnrptPagos
            // 
            this.btnrptPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnrptPagos.FlatAppearance.BorderSize = 0;
            this.btnrptPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptPagos.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptPagos.ForeColor = System.Drawing.Color.White;
            this.btnrptPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptPagos.Location = new System.Drawing.Point(12, 92);
            this.btnrptPagos.Name = "btnrptPagos";
            this.btnrptPagos.Size = new System.Drawing.Size(184, 42);
            this.btnrptPagos.TabIndex = 7;
            this.btnrptPagos.Text = "Reporte Pagos";
            this.btnrptPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrptPagos.UseVisualStyleBackColor = false;
            this.btnrptPagos.Click += new System.EventHandler(this.btnrptPagos_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(1, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 42);
            this.panel10.TabIndex = 6;
            // 
            // btnrptCompras
            // 
            this.btnrptCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnrptCompras.FlatAppearance.BorderSize = 0;
            this.btnrptCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptCompras.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptCompras.ForeColor = System.Drawing.Color.White;
            this.btnrptCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptCompras.Location = new System.Drawing.Point(13, 48);
            this.btnrptCompras.Name = "btnrptCompras";
            this.btnrptCompras.Size = new System.Drawing.Size(184, 42);
            this.btnrptCompras.TabIndex = 5;
            this.btnrptCompras.Text = "Reporte Compras";
            this.btnrptCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrptCompras.UseVisualStyleBackColor = false;
            this.btnrptCompras.Click += new System.EventHandler(this.btnrptCompras_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 42);
            this.panel9.TabIndex = 4;
            // 
            // btnrptVentas
            // 
            this.btnrptVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnrptVentas.FlatAppearance.BorderSize = 0;
            this.btnrptVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptVentas.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptVentas.ForeColor = System.Drawing.Color.White;
            this.btnrptVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptVentas.Location = new System.Drawing.Point(12, 0);
            this.btnrptVentas.Name = "btnrptVentas";
            this.btnrptVentas.Size = new System.Drawing.Size(184, 42);
            this.btnrptVentas.TabIndex = 3;
            this.btnrptVentas.Text = "Reporte Ventas";
            this.btnrptVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrptVentas.UseVisualStyleBackColor = false;
            this.btnrptVentas.Click += new System.EventHandler(this.btnrptVentas_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(0, 365);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 42);
            this.panel7.TabIndex = 14;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte.ForeColor = System.Drawing.Color.Snow;
            this.btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reporte.Image")));
            this.btn_Reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reporte.Location = new System.Drawing.Point(12, 365);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(208, 42);
            this.btn_Reporte.TabIndex = 13;
            this.btn_Reporte.Text = "Reportes";
            this.btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 317);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 42);
            this.panel6.TabIndex = 12;
            // 
            // btn_Pagos
            // 
            this.btn_Pagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_Pagos.FlatAppearance.BorderSize = 0;
            this.btn_Pagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pagos.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pagos.ForeColor = System.Drawing.Color.Snow;
            this.btn_Pagos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pagos.Image")));
            this.btn_Pagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pagos.Location = new System.Drawing.Point(12, 317);
            this.btn_Pagos.Name = "btn_Pagos";
            this.btn_Pagos.Size = new System.Drawing.Size(208, 42);
            this.btn_Pagos.TabIndex = 11;
            this.btn_Pagos.Text = "Pagos";
            this.btn_Pagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pagos.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 42);
            this.panel5.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Snow;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 42);
            this.button5.TabIndex = 9;
            this.button5.Text = "Empleados";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 42);
            this.panel4.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 42);
            this.button4.TabIndex = 7;
            this.button4.Text = "Compras";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 42);
            this.panel3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Clientes";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 42);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ventas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 42);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Produtos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Control
            // 
            this.Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Control.Location = new System.Drawing.Point(220, 38);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(1101, 744);
            this.Control.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(0, 670);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 73);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 16;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 782);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Menu_Vertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.Menu_Vertical.ResumeLayout(false);
            this.SubmenuReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.Panel Menu_Vertical;
        private System.Windows.Forms.Panel Control;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_Maximizar;
        private System.Windows.Forms.PictureBox btn_Restaurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Pagos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SubmenuReporte;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnrptCompras;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnrptVentas;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnrptPagos;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}

