using CapaPresentacion.Productos;
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

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }

      

        private void Inicio_Load(object sender, EventArgs e)
        {
         
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(MenuActivo != null)
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


            contenedor.Controls.Add(formulario);
            formulario.Show();

        }


        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formCompras());
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formVentas());
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formProductos());
        }


        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formUsuarios());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formProveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formReportes());
        }

        private void menuAcercade_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formInfo());
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
         this.Close(); 
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizar el formulario
        }
    }
}
