using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class menu : Form
    {
        private int childFormNumber = 0;

        public menu()
        {
            InitializeComponent();
        }


        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void formpruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma1ejemplo frmprueba = new forma1ejemplo();
            frmprueba.MdiParent = this;
            frmprueba.Show();
        }
    }
}
