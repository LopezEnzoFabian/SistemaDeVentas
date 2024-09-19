using CapaPresentacion.Compras;
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

namespace CapaPresentacion.Productos
{
   
    public partial class formProductos : Form
    {
        private static IconButton MenuActivo = null;
        private static Form FormularioActivo = null;
        public formProductos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Transparent;
            }
            menu.BackColor = Color.Black;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;


            panelProductos.Controls.Add(formulario);
            formulario.Show();

        }

        private void ibtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formVerProductos());
        }

        private void ibtnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formCategorias());
        }
    }
}
