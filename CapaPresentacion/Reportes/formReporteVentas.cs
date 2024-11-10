using Capa_Entidad;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Ventas;
using ClosedXML.Excel;
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

namespace CapaPresentacion.Reportes
{
    public partial class formReporteVentas : Form
    {
        public formReporteVentas()
        {
            InitializeComponent();
        }

        private void formReporteVentas_Load(object sender, EventArgs e)
        {
            //traer datos a combo box 
            foreach (DataGridViewColumn column in dgReporteVentas.Columns)
            {
                cbBuscarPor.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
            }
            cbBuscarPor.DisplayMember = "Texto";
            cbBuscarPor.ValueMember = "Valor";
            cbBuscarPor.SelectedIndex = 0;
        }
    
        private void ibtnDescargaExcel_Click(object sender, EventArgs e)
        {
            if (ValidarFecha())
            {
                MessageBox.Show("Por favor, debe seleccionar todas las opciones", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Desea generar la tabla en Excel de estas ventas?", "Generar Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgReporteVentas.Rows.Count < 1)
                {
                    MessageBox.Show("No hay registros para exportar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataTable dt = new DataTable();

                    foreach (DataGridViewColumn columna in dgReporteVentas.Columns)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                    foreach (DataGridViewRow row in dgReporteVentas.Rows)
                    {
                        if (row.Visible)
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
                            });
                    }
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                    savefile.Filter = "Excel Files | *.xlsx";

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            XLWorkbook wb = new XLWorkbook();
                            var hoja = wb.Worksheets.Add(dt, "Informe");
                            hoja.ColumnsUsed().AdjustToContents();
                            wb.SaveAs(savefile.FileName);
                            MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch
                        {
                            MessageBox.Show("Error al generar reporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }


        public bool ValidarFecha()
        {
            return string.IsNullOrEmpty(dtFechaInicio.Text) ||
                   string.IsNullOrEmpty(dtFechaFin.Text);
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(txtBuscarPor.Text);
        }

        private void ibtnBuscaFecha_Click(object sender, EventArgs e)
        {
            List<Reporte_venta> lista = new List<Reporte_venta>();

            lista = new CN_reporte().Venta(

                dtFechaInicio.Value.ToString(),
                dtFechaFin.Value.ToString()
                );

            dgReporteVentas.Rows.Clear();

            foreach (Reporte_venta rc in lista)
            {
                dgReporteVentas.Rows.Add(new object[]
                {
                    rc.Fecha_registro,
                    rc.Tipo_factura,
                    rc.Numero_factura,
                    "$ " + rc.Monto_total,
                    rc.Usuario_registro,
                    rc.Dni_cliente,
                    rc.Nombre_cliente,
                    rc.Codigo_producto,
                    rc.Nombre_producto,
                    rc.Categoria,
                    "$ " + rc.Precio_venta,
                    rc.Cantidad,
                    "$ " + rc.Subtotal
                });
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione una opcion para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaFiltro = ((OpcionCombo)cbBuscarPor.SelectedItem).Valor.ToString();
            if (dgReporteVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgReporteVentas.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscarPor.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtBuscarPor.Text = "";
            foreach (DataGridViewRow row in dgReporteVentas.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
