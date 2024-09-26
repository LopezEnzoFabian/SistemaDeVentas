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


        private void RegistrarVenta_Load(object sender, EventArgs e)
        {

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
