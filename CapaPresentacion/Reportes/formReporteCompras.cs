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
    public partial class formReporteCompra : Form
    {
        public formReporteCompra()
        {
            InitializeComponent();
        }

        private void ibtnBuscarPorFec_Click(object sender, EventArgs e)
        {

        }

        private void ibtnDescargaExcel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea generar la tabla en Excel de estas compras?", "Generar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Aquí llamas a tu método para generar el excel
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
