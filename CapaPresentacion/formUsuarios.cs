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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evitar que el carácter se introduzca en el TextBox
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                     string.IsNullOrWhiteSpace(txtNombre.Text) ||
                     string.IsNullOrWhiteSpace(cbRol.Text) ||
                     string.IsNullOrWhiteSpace(cbEstado.Text) ||
                     string.IsNullOrWhiteSpace(txtContra.Text) ||
                     string.IsNullOrWhiteSpace(txtEmail.Text) ||
                     string.IsNullOrWhiteSpace(txtConfirContra.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Tomar decisiones basadas en la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                    // Si el usuario hizo clic en "Sí"
                    MessageBox.Show("Usuario guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (  string.IsNullOrWhiteSpace(txtDNI.Text) ||
                  string.IsNullOrWhiteSpace(txtNombre.Text) ||
                  string.IsNullOrWhiteSpace(cbRol.Text) ||
                  string.IsNullOrWhiteSpace(cbEstado.Text) ||
                  string.IsNullOrWhiteSpace(txtContra.Text) ||
                  string.IsNullOrWhiteSpace(txtEmail.Text) ||
                  string.IsNullOrWhiteSpace(txtConfirContra.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Tomar decisiones basadas en la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                    // Si el usuario hizo clic en "Sí"
                    MessageBox.Show("Cambios guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                txtNombre.Clear();
                cbEstado.Items.Clear();
                cbRol.Items.Clear();
                txtEmail.Clear();
                txtContra.Clear();
                txtConfirContra.Clear();
                
                
            }
        }
    }
}
