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

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new GraficosForm());
        }
    }
}
