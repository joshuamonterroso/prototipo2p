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
    public partial class marcalinea : Form
    {
        public marcalinea()
        {
            InitializeComponent();
        }

        private void chkmarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmarca.Checked==true)
            {
                chklinea.Checked = false;
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            } else
            {
                groupBox1.Enabled = false;
            }
            
        }

        private void chklinea_CheckedChanged(object sender, EventArgs e)
        {
            if (chklinea.Checked == true)
            {
                groupBox2.Enabled = true;
                chkmarca.Checked = false;
                groupBox1.Enabled = false;
            } else
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void btnmarca_Click(object sender, EventArgs e)
        {
            cn.ingresarmarca(txtnombremarca.Text, txtdirmarca.Text);
            txtnombremarca.Text = "";
            txtdirmarca.Text = "";
            llenarcombo();
        }

        private void marcalinea_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }
        clscontrolador cn = new clscontrolador();

        public void llenarcombo()
        {
            comboBox1.Items.Clear();
            cbomarca.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo();
            while (datareader.Read())
            {
                comboBox1.Items.Add(datareader[0].ToString());
                cbomarca.Items.Add(datareader[1].ToString());
            }
        }

        private void cbomarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = cbomarca.SelectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcodmarca.Text = comboBox1.SelectedItem.ToString();
        }

        private void btnlinea_Click(object sender, EventArgs e)
        {
            cn.ingresarlinea(txtnombrelinea.Text, txtdesclinea.Text, txtcodmarca.Text);
            txtdesclinea.Text = "";
            txtnombrelinea.Text = "";
            txtcodmarca.Text = "";
            cbomarca.Text = "";
            comboBox1.Text = "";
        }
    }
}
