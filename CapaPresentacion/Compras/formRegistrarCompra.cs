using Capa_Entidad;
using CapaPresentacion.Ventas;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Compras
{
    public partial class formRegistrarCompra : Form
    {
        public formRegistrarCompra()
        {
            InitializeComponent();
        }

   

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            formulario.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new ComprasListarProveedorcs());
        }

        private void ibtnBuscarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new ComprasListarProducto());
        }

        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()){
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
               "¿Está seguro que desea agregar su compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes){
                MessageBox.Show("Se a agregado su compra", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return string.IsNullOrEmpty(dtFechaCompra.Text) ||
                   string.IsNullOrEmpty(cbTIpoFac.Text) ||
                   string.IsNullOrEmpty(txtNumDoc.Text) ||
                   string.IsNullOrEmpty(txtRazonSoc.Text) ||
                   string.IsNullOrEmpty(txtCodProd.Text) ||
                   string.IsNullOrEmpty(txtProducto.Text) ||
                   string.IsNullOrEmpty(txtPrecioCom.Text) ||
                   string.IsNullOrEmpty(txtPrecioVen.Text) ||
                   string.IsNullOrEmpty(nudCant.Text);
        }

        private void limpiarCampos()
        {
            cbTIpoFac.SelectedItem = null;
            txtRazonSoc.Clear();
            txtNumDoc.Clear();
            txtCodProd.Clear();
            txtProducto.Clear();
            txtPrecioCom.Clear();
            txtPrecioVen.Clear();
        }

        private void ibtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (dgRegistrarCompra.Rows.Count == 1)
            {
                MessageBox.Show("No hay productos para registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtPrecioCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void txtPrecioVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void dgRegistrarCompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0) // Suponiendo que el botón está en la primera columna
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;
                // Dimensiones de la imagen original
                var originalImage = Properties.Resources.icons8_delete_32;
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

        private void formRegistrarCompra_Load(object sender, EventArgs e)
        {

        }

     
    }
}
