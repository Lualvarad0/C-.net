
namespace Examen3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txt_PrecioProcuto = new System.Windows.Forms.TextBox();
            this.Label_id = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.label_Precio = new System.Windows.Forms.Label();
            this.label_Estado = new System.Windows.Forms.Label();
            this.txt_EstadoProducto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Location = new System.Drawing.Point(57, 77);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(175, 35);
            this.txt_IdProducto.TabIndex = 0;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(57, 162);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(175, 35);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txt_PrecioProcuto
            // 
            this.txt_PrecioProcuto.Location = new System.Drawing.Point(57, 259);
            this.txt_PrecioProcuto.Name = "txt_PrecioProcuto";
            this.txt_PrecioProcuto.Size = new System.Drawing.Size(175, 35);
            this.txt_PrecioProcuto.TabIndex = 2;
            // 
            // Label_id
            // 
            this.Label_id.AutoSize = true;
            this.Label_id.Location = new System.Drawing.Point(58, 33);
            this.Label_id.Name = "Label_id";
            this.Label_id.Size = new System.Drawing.Size(121, 30);
            this.Label_id.TabIndex = 3;
            this.Label_id.Text = "Id producto";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(58, 129);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(89, 30);
            this.Label_Nombre.TabIndex = 4;
            this.Label_Nombre.Text = "Nombre";
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(58, 216);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(70, 30);
            this.label_Precio.TabIndex = 5;
            this.label_Precio.Text = "Precio";
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Location = new System.Drawing.Point(57, 312);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(165, 30);
            this.label_Estado.TabIndex = 6;
            this.label_Estado.Text = "Estado Producto";
            // 
            // txt_EstadoProducto
            // 
            this.txt_EstadoProducto.Location = new System.Drawing.Point(57, 363);
            this.txt_EstadoProducto.Name = "txt_EstadoProducto";
            this.txt_EstadoProducto.Size = new System.Drawing.Size(175, 35);
            this.txt_EstadoProducto.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(530, 299);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(426, 361);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(131, 40);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(391, 407);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(131, 40);
            this.btn_Exportar.TabIndex = 12;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_EstadoProducto);
            this.Controls.Add(this.label_Estado);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Label_id);
            this.Controls.Add(this.txt_PrecioProcuto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txt_PrecioProcuto;
        private System.Windows.Forms.Label Label_id;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.TextBox txt_EstadoProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Exportar;
    }
}

