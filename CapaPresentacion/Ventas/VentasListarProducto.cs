using Capa_Entidad;
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

namespace CapaPresentacion.Ventas
{
    public partial class VentasListarProducto : Form
    {
        public Producto Oproducto { get; set; }

        public VentasListarProducto()
        {
            InitializeComponent();
        }

        private void VentasListarProducto_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn column in dgListaProductos.Columns)
            {
                if (column.Visible == true)
                {
                    cbFiltro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }

            cbFiltro.DisplayMember = "Texto";
            cbFiltro.ValueMember = "Valor";
            cbFiltro.SelectedIndex = 0;

            List<Producto> lista = new CN_productos().Listar();
            foreach (Producto item in lista)
            {
                dgListaProductos.Rows.Add(new object[] {
                    item.Id_producto,
                    item.Codigo_prod,
                    item.Nombre,
                    item.oCategoria.Descripcion,
                    item.Descripcion,
                    item.Stock,
                    item.Precio_compra,
                    item.Precio_venta,
                 });
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione un filtro para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnaFiltro = ((OpcionCombo)cbFiltro.SelectedItem).Valor.ToString();
            if (dgListaProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListaProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(cbFiltro.Text);
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgListaProductos.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolum = e.ColumnIndex;

            if (irow >= 0 && icolum > 0)
            {
                Oproducto = new Producto()
                {
                    Id_producto = Convert.ToInt32(dgListaProductos.Rows[irow].Cells["ID"].Value.ToString()),
                    Codigo_prod = dgListaProductos.Rows[irow].Cells["colCodigo"].Value.ToString(),
                    Nombre = dgListaProductos.Rows[irow].Cells["colNombre"].Value.ToString(),
                    Descripcion = dgListaProductos.Rows[irow].Cells["colDescripcion"].Value.ToString(),
                    Stock = Convert.ToInt32(dgListaProductos.Rows[irow].Cells["colStock"].Value.ToString()),
                    Precio_compra = Convert.ToDecimal(dgListaProductos.Rows[irow].Cells["colPrecioCompra"].Value.ToString()),
                    Precio_venta = Convert.ToDecimal(dgListaProductos.Rows[irow].Cells["colPrecioVenta"].Value.ToString()),

                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }   
}
