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

namespace CapaPresentacion.Compras
{
    public partial class ComprasListarProveedores : Form
    {
        public Proveedor Oproveedor { get; set; }
        public ComprasListarProveedores()
        {
            InitializeComponent();
        }

        private void ComprasListarProveedorcs_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgListaProveedores.Columns)
            {
                if (column.Visible == true)
                {
                    cbFiltro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cbFiltro.DisplayMember = "Texto";
            cbFiltro.ValueMember = "Valor";
            cbFiltro.SelectedIndex = 0;

            List<Proveedor> lista = new CN_proveedor().Listar();
            foreach (Proveedor item in lista)
            {
                dgListaProveedores.Rows.Add(new object[] {
                    item.Id_proveedor,
                    item.DNI,
                    item.RazonSocial,
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
            if (dgListaProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListaProveedores.Rows)
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
            foreach (DataGridViewRow row in dgListaProveedores.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgListaProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolum = e.ColumnIndex;

            if (irow >= 0 && icolum > 0)
            {

                Oproveedor = new Proveedor()
                {
                    Id_proveedor = Convert.ToInt32(dgListaProveedores.Rows[irow].Cells["ID"].Value.ToString()),
                    DNI = dgListaProveedores.Rows[irow].Cells["colDNI"].Value.ToString(),
                    RazonSocial = dgListaProveedores.Rows[irow].Cells["colRazonSocial"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
