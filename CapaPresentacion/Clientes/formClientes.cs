using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static CapaPresentacion.formUsuarios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class formClientes : Form
    {
        private int fila = 0;
        public formClientes()
        {
            InitializeComponent();
        }

  

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(cbEstado.Text))
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validaciones.EsEmailValido(txtEmail.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El formato de email no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Tomar decisiones basadas en la respuesta del usuario
            if (ask == DialogResult.Yes)
            {
                // Si el usuario hizo clic en "Sí"
                MessageBox.Show("Usuario guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int fila = dgListarUsuario.Rows.Add();
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                dgListarUsuario.Rows[fila].Cells[2].Value = textInfo.ToTitleCase(txtDNI.Text.ToLower());
                dgListarUsuario.Rows[fila].Cells[3].Value = textInfo.ToTitleCase(txtNombre.Text.ToLower());
                dgListarUsuario.Rows[fila].Cells[4].Value = textInfo.ToTitleCase(txtEmail.Text.ToLower());
                dgListarUsuario.Rows[fila].Cells[5].Value = textInfo.ToTitleCase(txtTel.Text.ToLower());

                string estado = cbEstado.SelectedItem?.ToString();
                if (estado != null)
                    dgListarUsuario.Rows[fila].Cells[6].Value = textInfo.ToTitleCase(estado.ToLower());
            }
          
            limpiarCampos();

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras((KeyPressEventArgs)e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
           Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void limpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            cbEstado.Items.Clear();
    
        }

        private void dgListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
