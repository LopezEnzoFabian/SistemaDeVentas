using Capa_Entidad;
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

namespace CapaPresentacion.Ventas
{
    public partial class RegistrarVenta : Form
    {
        private static IconButton Boton = null;
       
        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {   
            formulario.Show();
        }

        private void ibtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (dgRegistrarVenta.Rows.Count == 1)
            {
                MessageBox.Show("No hay productos para registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton) sender, new VentasListarCliente());
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new VentasListarProducto());
        }
    }
}
