using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControlador;


namespace CapaVista
{
    public partial class proveedores : Form
    {
        public proveedores()
        {
            InitializeComponent();
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            actualizardatagrid();
        }
        clscontrolador cn = new clscontrolador();

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb1();
            dataGridView1.DataSource = dt;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            cn.ingresarproveedor(txtnombre.Text, txtdireccion.Text, txttelefono.Text, txtemail.Text);
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txttelefono.Text = "";
            actualizardatagrid();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            cn.eliminarproveedor(txteliminar.Text);
            txteliminar.Text = "";
            actualizardatagrid();
        }
    }
}
