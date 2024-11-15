using Capa_Entidad;
using CapaNegocio;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Ventas
{
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {

        }

        private void ibtnPDFDetalleVenta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea generar un documento PDF de esta compra?", "Generar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Aquí llamas a tu método para generar el PDF
                if (txtTipofactura.Text == "")
                {
                    MessageBox.Show("No se encontraron datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string texto_html = Properties.Resources.PlantillaVenta.ToString();

                texto_html = texto_html.Replace("@tipodocumento", txtTipofactura.Text);
                texto_html = texto_html.Replace("@numerodocumento", txtnumerofactura.Text);

                texto_html = texto_html.Replace("@doccliente", txtDNIcliente.Text);
                texto_html = texto_html.Replace("@nombrecliente", txtNombreCliente.Text);
                texto_html = texto_html.Replace("@fecharegistro", txtFechaVenta.Text);
                texto_html = texto_html.Replace("@usuarioregistro", txtNombreVendedor.Text);

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgListaDetalleVenta.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["colProducto"].Value.ToString() + "</td>";
                    filas += "<td>$" + row.Cells["colPrecioVenta"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["colCantidad"].Value.ToString() + "</td>";
                    filas += "<td>$" + row.Cells["colSubtotal"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                texto_html = texto_html.Replace("@filas", filas);
                texto_html = texto_html.Replace("@montototal", txtTotalmonto.Text); 
                texto_html = texto_html.Replace("@pagocon", txtTotalpago.Text);
                texto_html = texto_html.Replace("@cambio", txtTotalcambio.Text);

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Venta_{0}.pdf", txtnumerofactura.Text);
                savefile.Filter = "Pdf Files|* .pdf";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();

                        //aca funcion para agregar logo de resource

                        //pasar el texto html a doc pdf
                        using (StringReader sr = new StringReader(texto_html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfdoc, sr);
                        }
                        pdfdoc.Close();//cerrar nuestro documento pdf
                        stream.Close(); //cerrar archivo de memoria
                        MessageBox.Show("Documento generado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, ingrese el numero de la factura para iniciar la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Venta Oventa = new CN_venta().SeleccionarVenta(txtBuscarNumFactura.Text);
            if (Oventa.Id_venta != 0)
            {
                txtBuscarNumFactura.Text = Oventa.Numero_factura;

                txtFechaVenta.Text = Oventa.Fecha_registro;
                txtTipofactura.Text = Oventa.Tipo_factura;
                txtnumerofactura.Text = Oventa.Numero_factura;
                txtNombreVendedor.Text = Oventa.oUsuario.Nombre_completo;
                txtNombreCliente.Text = Oventa.Nombre_cliente;
                txtDNIcliente.Text = Oventa.DNI_cliente;

                dgListaDetalleVenta.Rows.Clear();

                foreach(Detalle_venta dv in Oventa.oDetalle_venta)
                {
                    dgListaDetalleVenta.Rows.Add(new object[] { dv.oProducto.Nombre,dv.Precio_venta,dv.Cantidad,dv.Sub_total});
                }

                txtTotalpago.Text = Oventa.Monto_pago.ToString("0.00");
                txtTotalcambio.Text = Oventa.Monto_cambio.ToString("0.00");
                txtTotalmonto.Text = Oventa.Monto_total.ToString("0.00");

            }
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(txtBuscarNumFactura.Text);
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtFechaVenta.Text = "";
            txtTipofactura.Text = "";
            txtNombreCliente.Text = "";
            txtNombreVendedor.Text = "";
            txtDNIcliente.Text = "";

            dgListaDetalleVenta.Rows.Clear();
            txtTotalpago.Text = "0.00";
            txtTotalcambio.Text = "0.00";
            txtTotalmonto.Text = "0.00";
        }

        private void dgListaDetalleVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                    e.Graphics.DrawImage(resizedImage, new System.Drawing.Rectangle(x, y, newWidth, newHeight));
                }
                e.Handled = true;
            }
        }

        private void txtBuscarNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }
    }
}
