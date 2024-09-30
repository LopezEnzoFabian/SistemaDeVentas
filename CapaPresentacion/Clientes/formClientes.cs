using Capa_Entidad;
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
        private Usuario usuarioActual;
        public formClientes(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
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
                dgListarUsuario.Rows[fila].Cells[6].Value = textInfo.ToTitleCase(txtDireccion.Text.ToLower());
                dgListarUsuario.Rows[fila].Cells[7].Value = textInfo.ToTitleCase(txtCiudad.Text.ToLower());
                dgListarUsuario.Rows[fila].Cells[8].Value = textInfo.ToTitleCase(txtLocalidad.Text.ToLower());

                string estado = cbEstado.SelectedItem?.ToString();
                if (estado != null)
                    dgListarUsuario.Rows[fila].Cells[9].Value = textInfo.ToTitleCase(estado.ToLower());

                limpiarCampos();
            }

        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(txtDNI.Text) ||
                   string.IsNullOrEmpty(txtNombre.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text) ||
                   string.IsNullOrEmpty(txtTel.Text) ||
                   string.IsNullOrEmpty(cbEstado.Text) ||
                   string.IsNullOrEmpty(txtCiudad.Text) ||
                   string.IsNullOrEmpty(txtDireccion.Text) ||
                   string.IsNullOrEmpty(txtCodPostal.Text);
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
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            txtCodPostal.Clear();
        }

        private void dgListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            if (usuarioActual.oRol.Id_rol == 2) // Cambia 2 por el ID del rol que representa a "cliente"
            {
                btnEliminar.Visible = false; // Cambia 'btnBoton' por el nombre del botón que deseas ocultar
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está a punto de eliminar un cliente. ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                //EliminarUsuario();
                // Mensaje de éxito
                MessageBox.Show("Usuario eliminado correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete los campos del cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea editar este cliente?", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Lógica para editar el cliente
                //EditarCliente();
                // Mensaje de éxito
                MessageBox.Show("Cliente editado correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgListarUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)  
                return;  

            if (e.ColumnIndex == 0) // Suponiendo que el botón está en la primera columna
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
           
                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;
                // Dimensiones de la imagen original
                var originalImage = Properties.Resources.check;
                // Reducir el tamaño de la imagen
                int margin = 4; // Ajusta este margen según lo necesites
                var newWidth = cellWidth - margin;
                var newHeight = cellHeight - margin;
                // Calcular la posición centrada
                var x = e.CellBounds.Left + (cellWidth - newWidth) / 2;
                var y = e.CellBounds.Top + (cellHeight - newHeight) / 2;
                // Redimensionar la imagen
                using (var resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight)))
                {
                    e.Graphics.DrawImage(resizedImage, new Rectangle(x, y, newWidth, newHeight));
                }
                e.Handled = true;
            }

        }

        private void dgListarUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione un filtro para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(cbFiltro.Text);
        }
    }
}
