using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            Inicio formularioInicio = new Inicio();

            formularioInicio.Show();
            this.Hide();

            formularioInicio.FormClosing += cerrar_form;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrar_form(object sender, FormClosingEventArgs e)
        {
            txttEmail.Text = "";
            txttPass.Text = "";
            this.Show();
        }
    }
}
