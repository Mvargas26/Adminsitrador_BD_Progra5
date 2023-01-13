using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmVentana : Form
    {
        public frmVentana()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // muestra la pantalla loguin

            frmLoguin pantalla = new frmLoguin();
            pantalla.MdiParent = this;
            pantalla.Show();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra la pantalla frmSGD
            frmSGBD pantalla = new frmSGBD();
            pantalla.MdiParent = this;
            pantalla.Show();
        }

        private void frmVentana_Load(object sender, EventArgs e)
        {
            frmLoguin pantalla = new frmLoguin();
            pantalla.MdiParent = this;
            pantalla.Show();
        }//fin load
    }//fin class
}//fin space
