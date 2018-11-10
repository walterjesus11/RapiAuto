using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.RapiAuto
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new formLogin();
            formLogin.ShowDialog();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVehiculos = new formVehiculos();
            formVehiculos.MdiParent = this;
            formVehiculos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new formClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
