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
        private Usuario User;
        public formRegistrarCompra(Usuario ousuario = null)
        {
            User = ousuario;
            InitializeComponent();
        }

        private void formRegistrarCompra_Load(object sender, EventArgs e)
        {
            //combo box tipo de factura
            cbfactura.Items.Add(new OpcionCombo() { Valor = "Factura A", Texto = "Factura A" });
            cbfactura.Items.Add(new OpcionCombo() { Valor = "Factura B", Texto = "Factura B" });
            cbfactura.DisplayMember = "Texto";
            cbfactura.ValueMember = "Valor";
            cbfactura.SelectedIndex = 0;
            txtFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            formulario.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new ComprasListarProveedores())
            {
                var result = modal.ShowDialog();

               if(result == DialogResult.OK){

               txtidproveedor.Text = modal.Oproveedor.Id_proveedor.ToString();
               txtNumDoc.Text = modal.Oproveedor.DNI.ToString();
               txtRazonSoc.Text = modal.Oproveedor.RazonSocial.ToString();

               }
                else
                {
                    txtNumDoc.Select();
                }
            }
        }

        private void ibtnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new ComprasListarProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal.Oproducto.Id_producto.ToString();
                    txtCodProd.Text = modal.Oproducto.Codigo_prod.ToString();
                    txtProducto.Text = modal.Oproducto.Nombre.ToString();
                    txtDescripcion.Text = modal.Oproducto.Descripcion.ToString();
                    txtPrecioCom.Select();
                }
                else
                {
                    txtCodProd.Select();
                }
            }
        }

        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool producto_existe = false;

            if (ValidarCampos()){
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!decimal.TryParse(txtPrecioCom.Text, out precioCompra)){
                MessageBox.Show("Precio de Compra - Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCom.Select();
                return;
            }

            //foreach (DataGridViewRow fila in dgRegistrarCompra.Rows)
            //{
            //    if (fila.Cells["ID"].Value.ToString() == txtidproducto.Text)
            //    {
            //        producto_existe = true;
            //        break;
            //    }
            //}

            DialogResult resultado = MessageBox.Show(
            "¿Está seguro que desea agregar su compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes){

                if (!producto_existe)
                {
                    dgRegistrarCompra.Rows.Add(new object[]
                    {
                        txtidproducto.Text,
                        txtProducto.Text,
                        precioCompra.ToString("0.00"),
                        precioVenta.ToString("0.00"),
                        txtCantidad.Value.ToString(),
                        (txtCantidad.Value * precioCompra).ToString("0.00")
                    });
                }
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            calcularTOTAL();
            limpiarCampos();
            txtCantidad.Select();
        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return 
                   string.IsNullOrEmpty(cbfactura.Text) ||
                   string.IsNullOrEmpty(txtNumDoc.Text) ||
                   string.IsNullOrEmpty(txtRazonSoc.Text) ||
                   string.IsNullOrEmpty(txtCodProd.Text) ||
                   string.IsNullOrEmpty(txtProducto.Text) ||
                   string.IsNullOrEmpty(txtPrecioCom.Text) ||
                   string.IsNullOrEmpty(txtPrecioVen.Text) ||
                   string.IsNullOrEmpty(txtCantidad.Text);
        }

        private void limpiarCampos()
        {
            cbfactura.SelectedItem = null;
            txtRazonSoc.Clear();
            txtNumDoc.Clear();
            txtCodProd.Clear();
            txtProducto.Clear();
            txtDescripcion.Clear();
            txtPrecioCom.Clear();
            txtPrecioVen.Clear();
            txtCantidad.Value = 1;
            txtidproducto.Text = "0";
            txtidproveedor.Text = "0";
        }

        private void calcularTOTAL()
        {
            decimal total = 0;
            if(dgRegistrarCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgRegistrarCompra.Rows)                
                    total += Convert.ToDecimal(row.Cells["colSubtotal"].Value.ToString());
         }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void ibtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (dgRegistrarCompra.Rows.Count == 1)
            {
                MessageBox.Show("No hay productos para registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void txtPrecioVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void dgRegistrarCompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6) // Suponiendo que el botón está en la primera columna
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

        private void txtPrecioCom_TextChanged(object sender, EventArgs e)
        {
            decimal precioCompra;
            decimal precioVenta;

            if (decimal.TryParse(txtPrecioCom.Text, out precioCompra))
            {
                precioVenta = precioCompra * 1.20m; // Calcular el 20% más
                txtPrecioVen.Text = precioVenta.ToString("0.00");
            }
            else
            {
                txtPrecioVen.Text = string.Empty; // Limpiar si el valor es inválido
            }
            
        }

        private void txtPrecioCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, y la coma decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar la entrada
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Ignorar la entrada si ya hay un punto
            }

        }

        private void dgRegistrarCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRegistrarCompra.Columns[e.ColumnIndex].Name == "btndelete")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    dgRegistrarCompra.Rows.RemoveAt(indice);
                    calcularTOTAL();
                }
            }
        }
    }
}
