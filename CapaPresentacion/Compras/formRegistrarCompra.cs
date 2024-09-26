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

namespace CapaPresentacion.Compras
{
    public partial class formRegistrarCompra : Form
    {
        public formRegistrarCompra()
        {
            InitializeComponent();
        }

        private void formRegistrarCompra_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            formulario.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new ComprasListarProveedorcs());
        }

        private void ibtnBuscarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new ComprasListarProducto());
        }
    }
}
