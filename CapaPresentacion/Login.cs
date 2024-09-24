using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Capa_Entidad;

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
            List<Usuario> TEST = new CN_usuario().Listar();

            Usuario ousuario = new CN_usuario().Listar().Where(u => u.Email == txttEmail.Text && u.Pass == txttPass.Text).FirstOrDefault(); //expresion lambda
                
            if(ousuario != null)
            {
                Inicio formularioInicio = new Inicio(ousuario);

                formularioInicio.Show();
                this.Hide();

                formularioInicio.FormClosing += cerrar_form;
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

           
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
