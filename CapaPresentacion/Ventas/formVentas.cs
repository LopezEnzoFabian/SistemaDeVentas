using Capa_Entidad;
using CapaPresentacion.Compras;
using CapaPresentacion.Reportes;
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

namespace CapaPresentacion
{
    public partial class formVentas : Form
    {
        private static IconButton MenuActivo = null;
        private static Form FormularioActivo = null;
        private static Form presentacionForm;
        private Usuario User;
        public formVentas(Usuario ousuario = null)
        {
            User = ousuario;
            InitializeComponent();
        }

        private void formVentas_Load(object sender, EventArgs e)
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


            panelVentas.Controls.Add(formulario);
            formulario.Show();

        }

        private void ibtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formRegistrarVenta(User));
        }

        private void ibtnDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new DetalleVenta());
        }

        private void MostrarFormularioPresentacion()
        {
            presentacionForm = new formRegistrarVenta(User);
            presentacionForm.TopLevel = false;
            presentacionForm.FormBorderStyle = FormBorderStyle.None;
            presentacionForm.Dock = DockStyle.Fill;
            panelVentas.Controls.Add(presentacionForm);
            presentacionForm.Show();
        }
    }
}
