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
    public partial class producto : Form
    {
        public producto()
        {
            InitializeComponent();
        }

        private void producto_Load(object sender, EventArgs e)
        {
            llenarcombo();
            actualizardatagrid();
        }
        clscontrolador cn = new clscontrolador();

        public void llenarcombo()
        {
            cbocodigo.Items.Clear();
            cbocodigoeliminar.Items.Clear();
            cbonombre.Items.Clear();
            cbonombreeliminar.Items.Clear();
            OdbcDataReader datareader = cn.llenarcboproducto();
            while (datareader.Read())
            {                
                cbocodigo.Items.Add(datareader[0].ToString());
                cbocodigoeliminar.Items.Add(datareader[0].ToString());
                cbonombre.Items.Add(datareader[1].ToString());
                cbonombreeliminar.Items.Add(datareader[1].ToString());
            }
        }

        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb2();
            dataGridView1.DataSource = dt;
        }

        private void cbonombreeliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocodigoeliminar.SelectedIndex = cbonombreeliminar.SelectedIndex;
            txteliminar.Text = cbonombreeliminar.SelectedItem.ToString();
        }

        private void cbocodigoeliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbonombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocodigo.SelectedIndex = cbonombre.SelectedIndex;
            txtlinea.Text= cbonombre.SelectedIndex.ToString();
        }

        private void cbocodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            cn.ingresarproducto(txtnombre.Text, txtdescripcion.Text, txtlinea.Text);
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtlinea.Text = "";
            cbonombre.Text = "";
            actualizardatagrid();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            cn.eliminarproducto(txteliminar.Text);
            txteliminar.Text = "";
            actualizardatagrid();
        }
    }
}
