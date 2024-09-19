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
    public partial class formUsuarios : Form
    {
        public formUsuarios()
        {
            InitializeComponent();
        }

        private void formUsuarios_Load(object sender, EventArgs e)
        {

        }

        public static class Validaciones
        {
            public static bool ValidarSoloNumeros(KeyPressEventArgs e)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return false;
                }
                return true;
            }

            public static bool ValidarSoloLetras(KeyPressEventArgs e)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                    return false;
                }
                return true;
            }

            public static bool EsEmailValido(string email)
            {
                try
                {
                    var mail = new System.Net.Mail.MailAddress(email);
                    return mail.Address == email;
                }
                catch
                {
                    return false;
                }
            }
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras((KeyPressEventArgs)e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                     string.IsNullOrWhiteSpace(Tbt_Nombre.Text) ||
                     string.IsNullOrWhiteSpace(cbRol.Text) ||
                     string.IsNullOrWhiteSpace(cbEstado.Text) ||
                     string.IsNullOrWhiteSpace(Tbt_pass.Text) ||
                     string.IsNullOrWhiteSpace(Tbt_email.Text) ||
                     string.IsNullOrWhiteSpace(Tbt_confirmpass.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Tbt_pass.Text != Tbt_confirmpass.Text)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Las contraseñas deben coincidir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsEmailValido(Tbt_email.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Tomar decisiones basadas en la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                    // Si el usuario hizo clic en "Sí"
                    MessageBox.Show("Usuario guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (  string.IsNullOrWhiteSpace(txtDNI.Text) ||
                  string.IsNullOrWhiteSpace(Tbt_Nombre.Text) ||
                  string.IsNullOrWhiteSpace(cbRol.Text) ||
                  string.IsNullOrWhiteSpace(cbEstado.Text) ||
                  string.IsNullOrWhiteSpace(Tbt_pass.Text) ||
                  string.IsNullOrWhiteSpace(Tbt_email.Text) ||
                  string.IsNullOrWhiteSpace(Tbt_confirmpass.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe Completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           if(Tbt_pass.Text != Tbt_confirmpass.Text)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Las contraseñas deben coincidir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsEmailValido(Tbt_email.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
                DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Tomar decisiones basadas en la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                    // Si el usuario hizo clic en "Sí"
                    MessageBox.Show("Cambios guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "Seguro que desea eliminar este usuario";
            string titulo = "Confirmar Eliminación";
            DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {
                string msj = "Usuario eliminado con exito";
                string titulo2 = "Eliminar";
                MessageBox.Show(msj, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDNI.Clear();
                Tbt_Nombre.Clear();
                cbEstado.Items.Clear();
                cbRol.Items.Clear();
                Tbt_email.Clear();
                Tbt_pass.Clear();
                Tbt_confirmpass.Clear();
                
                
            }
        }

        //private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        //}

        private void dgListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }
    }
}
