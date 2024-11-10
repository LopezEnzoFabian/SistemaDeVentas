using Capa_Entidad;
using CapaPresentacion.Compras;
using CapaPresentacion.Ventas;
using CapaNegocio;
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

namespace CapaPresentacion.Ventas
{
    public partial class formRegistrarVenta : Form
    {
        private Usuario Eusuario;

        public formRegistrarVenta(Usuario ousuario = null)
        {
            Eusuario = ousuario;
            InitializeComponent();
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            //combo box tipo de factura
            cbfactura.Items.Add(new OpcionCombo() { Valor = "Factura A", Texto = "Factura A" });
            cbfactura.Items.Add(new OpcionCombo() { Valor = "Factura B", Texto = "Factura B" });
            cbfactura.DisplayMember = "Texto";
            cbfactura.ValueMember = "Valor";
            cbfactura.SelectedIndex = 0;
            txtFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");

            txtidcliente.Text = "0";
            txtidproducto.Text = "0";
        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            formulario.Show();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new VentasListarCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {

                    txtidcliente.Text = modal.Ocliente.Id_cliente.ToString();
                    txtDNI.Text = modal.Ocliente.DNI.ToString();
                    txtNombre.Text = modal.Ocliente.Nombre_completo.ToString();

                }
                else
                {
                    txtDNI.Select();
                }
            }
        }

        //boton para buscar producto
        private void ibtnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new VentasListarProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal.Oproducto.Id_producto.ToString();
                    txtCodProd.Text = modal.Oproducto.Codigo_prod.ToString();
                    txtProducto.Text = modal.Oproducto.Nombre.ToString();
                    txtDescripcion.Text = modal.Oproducto.Descripcion.ToString();
                    txtPrecioVen.Text = modal.Oproducto.Precio_venta.ToString();
                    txtstock.Text = modal.Oproducto.Stock.ToString();
                }
                else
                {
                    txtCodProd.Select();
                }
            }
        }


        //boton registrar venta
        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioVenta = 0;
            bool producto_existe = false;

            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!decimal.TryParse(txtPrecioVen.Text, out precioVenta))
            {
                MessageBox.Show("Precio de Venta - Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVen.Select();
                return;
            }


           if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(nudCant.Value.ToString()) )
            {
                MessageBox.Show("Precio de Compra - Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVen.Select();
                return;
            }

            DialogResult resultado = MessageBox.Show(
               "¿Está seguro que desea agregar la venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                if (!producto_existe)
                {
                    bool respuesta = new CN_venta().RestarStock(
                        Convert.ToInt32(txtidproducto.Text),
                        Convert.ToInt32(nudCant.Value.ToString())
                        );//pasamos los parametros a nuestro metodo restar

                    if (respuesta)
                    {
                    dgRegistrarVenta.Rows.Add(new object[]
                    {
                        txtidproducto.Text,
                        txtProducto.Text,
                        precioVenta.ToString("0.00"),
                        nudCant.Value.ToString(),
                        (nudCant.Value * precioVenta).ToString("0.00")
                    });
                    }
                }
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            calcularTOTAL();
            nudCant.Select();
            limpiarCampos();

        }


        //metodo para calcular total de venta a pagar
        private void calcularTOTAL()
        {
            decimal total = 0;
            if (dgRegistrarVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgRegistrarVenta.Rows)
                    total += Convert.ToDecimal(row.Cells["colSubtotal"].Value.ToString());
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void ibtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dgRegistrarVenta.Rows.Count < 1)
            {
                MessageBox.Show("No hay productos para registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("Idproducto", typeof(int));//al momento de ingresar al datatable lo convierte a este tipo de dato
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgRegistrarVenta.Rows)
            {
                detalle_venta.Rows.Add(
                    new object[]
                    {
                        Convert.ToInt32(row.Cells["colIdproducto"].Value.ToString()),//por ende no definimos aqui el tipo de dato
                        row.Cells["colPrecioVenta"].Value.ToString(),
                        row.Cells["colCantidad"].Value.ToString(),
                        row.Cells["colSubTotal"].Value.ToString()

                    });
            }//CREAR NUESTRA TABLA PARA ENVIAR 


            //OBTENER CORRELATIVO
            int idcorrelativo = new CN_venta().ObtenerCorrelativo();
            string numerofactura = string.Format("{0:00000}", idcorrelativo);

            calcularCambio();//actualizar antes de crear una venta

            Venta venta = new Venta()
            {
                Tipo_factura = ((OpcionCombo)cbfactura.SelectedItem).Texto,
                DNI_cliente = txtDNI.Text,
                Nombre_cliente = txtNombre.Text,
                Monto_pago = Convert.ToDecimal(txtPagacon.Text),
                Monto_cambio = Convert.ToDecimal(txtCambio.Text),
                Monto_total = Convert.ToDecimal(txtTotalPagar.Text),
                oUsuario = new Usuario() { Id_usuario = Eusuario.Id_usuario },
                Numero_factura = numerofactura
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_venta().Registrar(venta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numerofactura + "\n\n¿Desea guardar la venta realizada?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numerofactura);

                    txtidproducto.Text = "0";
                    txtDNI.Clear();
                    txtNombre.Clear();
                    dgRegistrarVenta.Rows.Clear();
                    calcularTOTAL();
                    txtPagacon.Clear();
                    txtCambio.Clear();
                }
            }
            else
            {
                MessageBox.Show("Operacion cancela", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return 
                   string.IsNullOrEmpty(cbfactura.Text) ||
                   string.IsNullOrEmpty(txtDNI.Text) ||
                   string.IsNullOrEmpty(txtNombre.Text) ||
                   string.IsNullOrEmpty(txtCodProd.Text) ||
                   string.IsNullOrEmpty(txtProducto.Text) ||
                   string.IsNullOrEmpty(txtPrecioVen.Text) ||
                   string.IsNullOrEmpty(nudCant.Text);
        }

        private void limpiarCampos()
        {
            txtCodProd.Clear();
            txtProducto.Clear();
            txtPrecioVen.Clear();
            txtDescripcion.Clear();
            txtstock.Clear();
            nudCant.Value = 1;
        }

        private void dgRegistrarVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5) // Suponiendo que el botón está en la primera columna
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


        //funcionalidad del boton de borrar en el dg
        private void dgRegistrarVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRegistrarVenta.Columns[e.ColumnIndex].Name == "btndelete")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    bool respuesta = new CN_venta().SumarStock(
                    Convert.ToInt32(dgRegistrarVenta.Rows[indice].Cells["colIdProducto"].Value.ToString()),
                    Convert.ToInt32(dgRegistrarVenta.Rows[indice].Cells["colCantidad"].Value.ToString())
                    );//pasamos las variables necesarias del dg a nuestro metodo sumar stock

                    dgRegistrarVenta.Rows.RemoveAt(indice);
                    calcularTOTAL();

                }
            }
        }

        private void calcularCambio()
        {
            if(txtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen producto a la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);

            if(txtPagacon.Text.Trim() == "")
            {
                txtPagacon.Text ="0";
            }

            //convercio a decimal del textbox y lo convertimos a variable pagacon
            if(decimal.TryParse(txtPagacon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtCambio.Text = "0";
                }
                else { 
                  decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }

        }

        //funcionalidad al apretar enter en EL TEXT BOX PAGA CON Y CALCULAR CAMBIO
        private void txtPagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { 
              calcularCambio();
            }
        }
    }
}
