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

namespace CapaPresentacion.Productos
{
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }

        private void dgListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione un filtro para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaFiltro = ((OpcionCombo)cbFiltro.SelectedItem).Valor.ToString();
            if (dgListarProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListarProductos.Rows)
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

        private void VerProductos_Load(object sender, EventArgs e)
        {
            //buscar en nuestro boton de busqueda
            foreach (DataGridViewColumn column in dgListarProductos.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionar")
                {
                    cbFiltro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cbFiltro.DisplayMember = "Texto";
            cbFiltro.ValueMember = "Valor";
            cbFiltro.SelectedIndex = 0;

            //mostrar productos en el data grid
            List<Producto> listaProducto = new CN_productos().Listar();
            foreach (Producto item in listaProducto)
            {
                dgListarProductos.Rows.Add(new object[] {
                    item.Id_producto,
                    item.Codigo_prod,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.Id_categoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.Precio_venta,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                    });
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgListarProductos.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
