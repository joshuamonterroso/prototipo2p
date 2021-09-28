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
    public partial class forma1ejemplo : Form
    {
        public forma1ejemplo()
        {
            InitializeComponent();
        }

        private void forma1ejemplo_Load(object sender, EventArgs e)
        {

        }

        clscontrolador cn = new clscontrolador();
        //Llenar el datagridview, lo mandas a llamar donde lo necesites
        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb1();
            dataGridView1.DataSource = dt;
        }

        //Llenar el combobox, lo mandas a llamar donde lo necesite
        public void llenarcombo()
        {
            comboBox1.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo();
            while (datareader.Read())
            {
                comboBox1.Items.Add(datareader[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cn.ingresarconsulta(textBox1.Text, textBox2.Text);
            llenarcombo();
            actualizardatagrid();
        }

        //Para hacer el insert, update o delete
        //Esta no esta en una funcion, la mando a llamar directamente segun sus parametros
        //cn.ingresarconsulta(txtNombreConsulta.Text, txtCadenaGenerada.Text);

    }
}
