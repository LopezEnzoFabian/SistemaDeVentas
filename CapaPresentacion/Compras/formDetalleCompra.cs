using Capa_Entidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
using iTextSharp.tool.xml;

namespace CapaPresentacion
{
    public partial class formDetalleCompra : Form
    {
        public formDetalleCompra()
        {
            InitializeComponent();
        }

        private void formDetalleCompra_Load(object sender, EventArgs e)
        {

        }

        private void ibtnPDFDetalleCompra_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea generar un documento PDF de esta compra?", "Generar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Aquí llamas a tu método para generar el PDF
                if(txtTIpofactura.Text == "")
                {
                    MessageBox.Show("No se encontraron datos", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string texto_html = Properties.Resources.PlantillaCompra.ToString();

                texto_html = texto_html.Replace("@tipodocumento", txtTIpofactura.Text);
                texto_html = texto_html.Replace("@numerodocumento", txtnumerofactura.Text);

                texto_html = texto_html.Replace("@docproveedor", txtDNIproveedor.Text);
                texto_html = texto_html.Replace("@nombreproveedor", txtRazonSoc.Text);
                texto_html = texto_html.Replace("@fecharegistro", txtFecha.Text);
                texto_html = texto_html.Replace("@usuarioregistro", txtUsuariocompra.Text);

                string filas = string.Empty;
                foreach(DataGridViewRow row in dgDetalleCompra.Rows){
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["colProducto"].Value.ToString() + "</td>";
                    filas += "<td>$" + row.Cells["colPrecioCompra"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["colCant"].Value.ToString() + "</td>";
                    filas += "<td>$" + row.Cells["colSubtotal"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                texto_html = texto_html.Replace("@filas", filas);
                texto_html = texto_html.Replace("@montototal", txtMontoTotal.Text);

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Compra_{0}.pdf", txtnumerofactura.Text);
                savefile.Filter = "Pdf Files|* .pdf";

                if(savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4,25,25,25,25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();

                        //aca funcion para agregar logo de resource

                        //pasar el texto html a doc pdf
                        using (StringReader sr = new StringReader(texto_html)) {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfdoc,sr);
                        }
                    pdfdoc.Close();//cerrar nuestro documento pdf
                    stream.Close(); //cerrar archivo de memoria
                    MessageBox.Show("Documento generado","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ibtnBuscar_Click(object sender, EventArgs e)
        {
            Compra ocompra = new CN_compras().SeleccionarCompra(txtBuscarFactura.Text);

            if (ocompra.Id_compra != 0)
            {
                txtnumerofactura.Text = ocompra.Numero_factura;

                txtFecha.Text = ocompra.Fecha_registro;
                txtTIpofactura.Text = ocompra.Tipo_factura;
                txtUsuariocompra.Text = ocompra.oUsuario.Nombre_completo;
                txtDNIproveedor.Text = ocompra.oProveedor.DNI;
                txtRazonSoc.Text = ocompra.oProveedor.RazonSocial;

                dgDetalleCompra.Rows.Clear();
                foreach(Detalle_compra dc in ocompra.oDetalle_compra) { 
                       dgDetalleCompra.Rows.Add(new object [] { dc.oProducto.Nombre, dc.Precio_compra,dc.Cantidad, dc.Monto_total });
                }
                txtMontoTotal.Text = ocompra.Monto_total.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No se encontró la compra con el número de factura proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtTIpofactura.Text = "";
            txtUsuariocompra.Text = "";
            txtDNIproveedor.Text = "";
            txtRazonSoc.Text = "";

            dgDetalleCompra.Rows.Clear();
            txtMontoTotal.Text="0.00";
        }

        private void dgDetalleCompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 4) // Suponiendo que el botón está en la primera columna
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
    }
}
