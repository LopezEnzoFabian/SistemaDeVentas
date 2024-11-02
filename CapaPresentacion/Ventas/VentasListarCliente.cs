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
    public partial class VentasListarCliente : Form
    {
        public Cliente Ocliente { get; set; }

        public VentasListarCliente()
        {
            InitializeComponent();
        }

        private void VentasListarCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgListaClientes.Columns)
            {
                if (column.Visible == true)
                {
                    cbFiltro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cbFiltro.DisplayMember = "Texto";
            cbFiltro.ValueMember = "Valor";
            cbFiltro.SelectedIndex = 0;

            List<Cliente> lista = new CN_cliente().Listar();
            foreach (Cliente item in lista)
            {
                dgListaClientes.Rows.Add(new object[] {
                    item.Id_cliente,
                    item.DNI,
                    item.Nombre_completo,
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
            if (dgListaClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListaClientes.Rows)
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
            foreach (DataGridViewRow row in dgListaClientes.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolum = e.ColumnIndex;

            if (irow >= 0 && icolum > 0)
            {

                Ocliente = new Cliente()
                {
                    Id_cliente = Convert.ToInt32(dgListaClientes.Rows[irow].Cells["ID"].Value.ToString()),
                    DNI = dgListaClientes.Rows[irow].Cells["colDNI"].Value.ToString(),
                    Nombre_completo = dgListaClientes.Rows[irow].Cells["colNombreCompleto"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
