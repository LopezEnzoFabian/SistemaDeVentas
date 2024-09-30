using CapaPresentacion.Ventas;
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

        private void AbrirFormulario(Button menu, Form formulario)
        {
            formulario.Show();
        }

        private void lblRepoCompras_Click(object sender, EventArgs e)
        {

        }

        private void lblRV_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarPor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ibtnDescargaExcel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea generar la tabla en Excel de estas ventas?", "Generar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Aquí llamas a tu método para generar el excel
            }
        }

        private void icbtnBuscarFecha_Click(object sender, EventArgs e)
        {
            if (ValidarFecha())
            {
                MessageBox.Show("Por favor, debe seleccionar todas las opciones", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

        public bool ValidarFecha()
        {
            return string.IsNullOrEmpty(dtFechaInicio.Text) ||
                   string.IsNullOrEmpty(dtFechaFin.Text);
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(txtBuscarPor.Text);
        }

    }
}
