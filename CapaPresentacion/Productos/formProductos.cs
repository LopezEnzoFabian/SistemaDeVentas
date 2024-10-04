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
        private static Form presentacionForm;

        public formProductos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            MostrarFormularioPresentacion();
        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            if (presentacionForm != null && presentacionForm.Visible)
            {
                presentacionForm.Hide(); // Ocultar el formulario de presentación
            }

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
            AbrirFormulario((IconButton)sender, new formABMProductos());
        }

        private void ibtnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formCategorias());
        }

        private void MostrarFormularioPresentacion()
        {
            presentacionForm = new formABMProductos();
            presentacionForm.TopLevel = false;
            presentacionForm.FormBorderStyle = FormBorderStyle.None;
            presentacionForm.Dock = DockStyle.Fill;
            panelProductos.Controls.Add(presentacionForm);
            presentacionForm.Show();
        }
    }
}
