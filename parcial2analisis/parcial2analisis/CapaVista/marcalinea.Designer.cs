
namespace CapaVista
{
    partial class marcalinea
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkmarca = new System.Windows.Forms.CheckBox();
            this.chklinea = new System.Windows.Forms.CheckBox();
            this.txtnombremarca = new System.Windows.Forms.TextBox();
            this.txtdirmarca = new System.Windows.Forms.TextBox();
            this.txtdesclinea = new System.Windows.Forms.TextBox();
            this.txtnombrelinea = new System.Windows.Forms.TextBox();
            this.txtcodmarca = new System.Windows.Forms.TextBox();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnmarca = new System.Windows.Forms.Button();
            this.btnlinea = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Marca Linea";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdirmarca);
            this.groupBox1.Controls.Add(this.txtnombremarca);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(26, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Marca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btnlinea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbomarca);
            this.groupBox2.Controls.Add(this.txtcodmarca);
            this.groupBox2.Controls.Add(this.txtdesclinea);
            this.groupBox2.Controls.Add(this.txtnombrelinea);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar linea";
            // 
            // chkmarca
            // 
            this.chkmarca.AutoSize = true;
            this.chkmarca.Location = new System.Drawing.Point(32, 29);
            this.chkmarca.Name = "chkmarca";
            this.chkmarca.Size = new System.Drawing.Size(94, 17);
            this.chkmarca.TabIndex = 0;
            this.chkmarca.Text = "agregar marca";
            this.chkmarca.UseVisualStyleBackColor = true;
            this.chkmarca.CheckedChanged += new System.EventHandler(this.chkmarca_CheckedChanged);
            // 
            // chklinea
            // 
            this.chklinea.AutoSize = true;
            this.chklinea.Location = new System.Drawing.Point(12, 248);
            this.chklinea.Name = "chklinea";
            this.chklinea.Size = new System.Drawing.Size(87, 17);
            this.chklinea.TabIndex = 1;
            this.chklinea.Text = "agregar linea";
            this.chklinea.UseVisualStyleBackColor = true;
            this.chklinea.CheckedChanged += new System.EventHandler(this.chklinea_CheckedChanged);
            // 
            // txtnombremarca
            // 
            this.txtnombremarca.Location = new System.Drawing.Point(116, 53);
            this.txtnombremarca.Name = "txtnombremarca";
            this.txtnombremarca.Size = new System.Drawing.Size(100, 20);
            this.txtnombremarca.TabIndex = 3;
            // 
            // txtdirmarca
            // 
            this.txtdirmarca.Location = new System.Drawing.Point(116, 107);
            this.txtdirmarca.Name = "txtdirmarca";
            this.txtdirmarca.Size = new System.Drawing.Size(100, 20);
            this.txtdirmarca.TabIndex = 4;
            // 
            // txtdesclinea
            // 
            this.txtdesclinea.Location = new System.Drawing.Point(216, 108);
            this.txtdesclinea.Name = "txtdesclinea";
            this.txtdesclinea.Size = new System.Drawing.Size(100, 20);
            this.txtdesclinea.TabIndex = 6;
            // 
            // txtnombrelinea
            // 
            this.txtnombrelinea.Location = new System.Drawing.Point(216, 54);
            this.txtnombrelinea.Name = "txtnombrelinea";
            this.txtnombrelinea.Size = new System.Drawing.Size(100, 20);
            this.txtnombrelinea.TabIndex = 5;
            // 
            // txtcodmarca
            // 
            this.txtcodmarca.Location = new System.Drawing.Point(371, 108);
            this.txtcodmarca.Name = "txtcodmarca";
            this.txtcodmarca.Size = new System.Drawing.Size(100, 20);
            this.txtcodmarca.TabIndex = 7;
            // 
            // cbomarca
            // 
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(496, 54);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(121, 21);
            this.cbomarca.TabIndex = 8;
            this.cbomarca.SelectedIndexChanged += new System.EventHandler(this.cbomarca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Direccion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre linea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripcion de linea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Marca pertenece";
            // 
            // btnmarca
            // 
            this.btnmarca.Location = new System.Drawing.Point(372, 48);
            this.btnmarca.Name = "btnmarca";
            this.btnmarca.Size = new System.Drawing.Size(112, 23);
            this.btnmarca.TabIndex = 14;
            this.btnmarca.Text = "Agregar Marca";
            this.btnmarca.UseVisualStyleBackColor = true;
            this.btnmarca.Click += new System.EventHandler(this.btnmarca_Click);
            // 
            // btnlinea
            // 
            this.btnlinea.Location = new System.Drawing.Point(505, 105);
            this.btnlinea.Name = "btnlinea";
            this.btnlinea.Size = new System.Drawing.Size(112, 23);
            this.btnlinea.TabIndex = 15;
            this.btnlinea.Text = "Agregar linea";
            this.btnlinea.UseVisualStyleBackColor = true;
            this.btnlinea.Click += new System.EventHandler(this.btnlinea_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(496, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // marcalinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.chklinea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkmarca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "marcalinea";
            this.Text = "marcalinea";
            this.Load += new System.EventHandler(this.marcalinea_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdirmarca;
        private System.Windows.Forms.TextBox txtnombremarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.TextBox txtcodmarca;
        private System.Windows.Forms.TextBox txtdesclinea;
        private System.Windows.Forms.TextBox txtnombrelinea;
        private System.Windows.Forms.CheckBox chkmarca;
        private System.Windows.Forms.CheckBox chklinea;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}