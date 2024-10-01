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
    public partial class formProveedores : Form
    {
        public formProveedores()
        {
            InitializeComponent();
        }


        private void formProveedores_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Proveedor guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiarCampos();
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete los campos del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea editar este proveedor?", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Lógica para editar el cliente
                //EditarCliente();
                // Mensaje de éxito
                MessageBox.Show("Proveedor editado correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está a punto de eliminar un proveedor. ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                //EliminarUsuario();
                // Mensaje de éxito
                MessageBox.Show("Proveedor eliminado correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);

        }

        private void txtRazonS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras((KeyPressEventArgs)e);

        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
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

        private void limpiarCampos()
        {
            txtDNI.Clear();
            txtRazonS.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtCodPostal.Clear();
            cbEstado.SelectedItem = null;
        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(txtDNI.Text) ||
                   string.IsNullOrEmpty(txtRazonS.Text) ||
                   string.IsNullOrEmpty(txtTel.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text) ||
                   string.IsNullOrEmpty(txtCiudad.Text) ||
                   string.IsNullOrEmpty(cbEstado.Text) ||
                   string.IsNullOrEmpty(txtDireccion.Text) ||
                   string.IsNullOrEmpty(txtCodPostal.Text);
        }

   
    }
}
