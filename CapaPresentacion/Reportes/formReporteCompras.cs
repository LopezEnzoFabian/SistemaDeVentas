using Capa_Entidad;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Net.Http.Headers;

namespace CapaPresentacion.Reportes
{
    public partial class formReporteCompra : Form
    {
        public formReporteCompra()
        {
            InitializeComponent();
        }

        private void formReporteCompra_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CN_proveedor().Listar();

            cbProveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" }); //0 es el valor que va a ser enviado a nuestro sp_compra nos permite traer todas la comprar con idproveedor 0

            //traer datos a combo box 
            foreach(Proveedor item in lista)
            {
                cbProveedor.Items.Add(new OpcionCombo() { Valor = item.Id_proveedor, Texto = item.RazonSocial });
            }
            cbProveedor.DisplayMember = "Texto";
            cbProveedor.ValueMember = "Valor";
            cbProveedor.SelectedIndex = 0;

            //traer datos a combo box 
            foreach (DataGridViewColumn column in dgReporteCompras.Columns)
            {
                cbBuscarPor.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
            }
            cbBuscarPor.DisplayMember = "Texto";
            cbBuscarPor.ValueMember = "Valor";
            cbBuscarPor.SelectedIndex = 0;

        }

        private void ibtnDescargaExcel_Click(object sender, EventArgs e)
        {
         

            DialogResult result = MessageBox.Show("¿Desea generar la tabla en Excel de estas compras?", "Generar Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgReporteCompras.Rows.Count < 1)
                {
                    MessageBox.Show("No hay registros para exportar","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataTable dt = new DataTable();

                    foreach (DataGridViewColumn columna in dgReporteCompras.Columns)
                    {
                            dt.Columns.Add(columna.HeaderText,typeof(string));
                    }
                    foreach(DataGridViewRow row in dgReporteCompras.Rows)
                    {
                        if(row.Visible)
                            dt.Rows.Add(new object[]
                            {
                                row.Cells[0].Value,
                                row.Cells[1].Value,
                                row.Cells[2].Value,
                                row.Cells[3].Value,
                                row.Cells[4].Value,
                                row.Cells[5].Value,
                                row.Cells[6].Value,
                                row.Cells[7].Value,
                                row.Cells[8].Value,
                                row.Cells[9].Value,
                                row.Cells[10].Value,
                                row.Cells[11].Value,
                                row.Cells[12].Value,
                                row.Cells[13].Value,
                            });
                    }
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                    savefile.Filter = "Excel Files | *.xlsx";

                    if(savefile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            XLWorkbook wb = new XLWorkbook();
                            var hoja = wb.Worksheets.Add(dt, "Informe");
                            hoja.ColumnsUsed().AdjustToContents();
                            wb.SaveAs(savefile.FileName);
                            MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch {
                            MessageBox.Show("Error al generar reporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    
                }
            }
        }

        private void ibtnBuscarPor_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione una opcion para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void ibtnBuscaFecha_Click(object sender, EventArgs e)
        {
            if (ValidarFechaProveedor())
            {
                MessageBox.Show("Por favor, debe definir un intervalo y un proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idproveedor = Convert.ToInt32(((OpcionCombo)cbProveedor.SelectedItem).Valor.ToString());

            List<Reporte_compra> lista = new List<Reporte_compra>();

            lista = new CN_reporte().Compra(

                dtFechainicio.Value.ToString(),
                dtFechafin.Value.ToString(),
                idproveedor
                );

            dgReporteCompras.Rows.Clear();

            foreach(Reporte_compra rc in lista)
            {
                dgReporteCompras.Rows.Add(new object[]
                {
                    rc.Fecha_registro,
                    rc.Tipo_factura,
                    rc.Numero_factura,
                    "$ " + rc.Monto_total,
                    rc.Usuario_registro,
                    rc.Dni_proveedor,
                    rc.Razon_social,
                    rc.Codigo_producto,
                    rc.Nombre_producto,
                    rc.Cantidad,
                    "$ " + rc.Precio_compra,
                    "$ " + rc.Precio_venta,
                    rc.Cantidad,
                    "$ " + rc.Subtotal
                });
            }
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(txtBuscarPor.Text);
        }

        public bool ValidarFechaProveedor()
        {
            return string.IsNullOrEmpty(dtFechainicio.Text) ||
                   string.IsNullOrEmpty(dtFechafin.Text) ||
                   string.IsNullOrEmpty(cbProveedor.Text);
        }

       
    }
}
