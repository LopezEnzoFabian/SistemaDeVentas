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
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.EsEmailValido(txttEmail.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                limpiarCampos();
            }

           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas salir de ElectroHub?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lógica para cerrar sesión               
                Application.Exit();
            }
           
        }

        private void cerrar_form(object sender, FormClosingEventArgs e)
        {
            txttEmail.Text = "";
            txttPass.Text = "";
            this.Show();
        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(txttPass.Text) ||
                   string.IsNullOrEmpty(txttEmail.Text);
              
        }

        private void limpiarCampos()
        {
            txttEmail.Clear();
            txttPass.Clear();
            
        }
    }
}
