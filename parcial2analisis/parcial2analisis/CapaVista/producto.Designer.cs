
namespace CapaVista
{
    partial class producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbonombre = new System.Windows.Forms.ComboBox();
            this.cbocodigo = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtlinea = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.cbocodigoeliminar = new System.Windows.Forms.ComboBox();
            this.cbonombreeliminar = new System.Windows.Forms.ComboBox();
            this.txteliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NombreProducto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Linea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripcion";
            // 
            // cbonombre
            // 
            this.cbonombre.FormattingEnabled = true;
            this.cbonombre.Location = new System.Drawing.Point(105, 112);
            this.cbonombre.Name = "cbonombre";
            this.cbonombre.Size = new System.Drawing.Size(121, 21);
            this.cbonombre.TabIndex = 6;
            this.cbonombre.SelectedIndexChanged += new System.EventHandler(this.cbonombre_SelectedIndexChanged);
            // 
            // cbocodigo
            // 
            this.cbocodigo.FormattingEnabled = true;
            this.cbocodigo.Location = new System.Drawing.Point(241, 112);
            this.cbocodigo.Name = "cbocodigo";
            this.cbocodigo.Size = new System.Drawing.Size(121, 21);
            this.cbocodigo.TabIndex = 7;
            this.cbocodigo.SelectedIndexChanged += new System.EventHandler(this.cbocodigo_SelectedIndexChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(105, 61);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 8;
            // 
            // txtlinea
            // 
            this.txtlinea.Location = new System.Drawing.Point(105, 139);
            this.txtlinea.Name = "txtlinea";
            this.txtlinea.Size = new System.Drawing.Size(100, 20);
            this.txtlinea.TabIndex = 9;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(105, 86);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 10;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(254, 58);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(108, 23);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Agregar Producto";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Productos Existentes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(436, 58);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(108, 23);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar Producto";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // cbocodigoeliminar
            // 
            this.cbocodigoeliminar.FormattingEnabled = true;
            this.cbocodigoeliminar.Location = new System.Drawing.Point(569, 107);
            this.cbocodigoeliminar.Name = "cbocodigoeliminar";
            this.cbocodigoeliminar.Size = new System.Drawing.Size(121, 21);
            this.cbocodigoeliminar.TabIndex = 15;
            this.cbocodigoeliminar.SelectedIndexChanged += new System.EventHandler(this.cbocodigoeliminar_SelectedIndexChanged);
            // 
            // cbonombreeliminar
            // 
            this.cbonombreeliminar.FormattingEnabled = true;
            this.cbonombreeliminar.Location = new System.Drawing.Point(433, 107);
            this.cbonombreeliminar.Name = "cbonombreeliminar";
            this.cbonombreeliminar.Size = new System.Drawing.Size(121, 21);
            this.cbonombreeliminar.TabIndex = 14;
            this.cbonombreeliminar.SelectedIndexChanged += new System.EventHandler(this.cbonombreeliminar_SelectedIndexChanged);
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(436, 139);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(100, 20);
            this.txteliminar.TabIndex = 16;
            // 
            // producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txteliminar);
            this.Controls.Add(this.cbocodigoeliminar);
            this.Controls.Add(this.cbonombreeliminar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtlinea);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbocodigo);
            this.Controls.Add(this.cbonombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "producto";
            this.Text = "producto";
            this.Load += new System.EventHandler(this.producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbonombre;
        private System.Windows.Forms.ComboBox cbocodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtlinea;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox cbocodigoeliminar;
        private System.Windows.Forms.ComboBox cbonombreeliminar;
        private System.Windows.Forms.TextBox txteliminar;
    }
}