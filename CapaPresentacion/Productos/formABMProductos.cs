using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formABMProductos : Form
    {
        public formABMProductos()
        {
            InitializeComponent();
        }

        private void dgListarPorductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
    

            DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                // Lógica para editar el cliente
                //EditarCliente();
                // Mensaje de éxito
                MessageBox.Show("Los datos han sido guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Gancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarCampos();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }

            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                //EliminarUsuario();
                // Mensaje de éxito
                MessageBox.Show("Producto eliminado correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limpiarCampos();
        }
 
        private void txtCodigoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);

        }

  

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea editar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Lógica para editar el cliente
                //EditarCliente();
                // Mensaje de éxito
                MessageBox.Show("Producto editado correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarCampos();
        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(txtNombre.Text) ||
                   string.IsNullOrEmpty(txtCodigoPro.Text) ||
                   string.IsNullOrEmpty(txtDescri.Text) ||
                   string.IsNullOrEmpty(cbCategoria.Text) ||
                   string.IsNullOrEmpty(cbEstado.Text);
        }

        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtCodigoPro.Clear();
            txtDescri.Clear();
            cbCategoria.SelectedItem = null;
            cbEstado.SelectedItem = null;
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

