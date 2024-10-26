
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
using Capa_Entidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private static Usuario usuarioActual;
        private static Form presentacionForm;
        public Inicio(Usuario objusuario = null)
        {
            //opcion para no loguear y entrar como un usuario predefinido ELIMINAR AL TERMINAR EL PROYECTO
            if (objusuario == null) usuarioActual = new Usuario() { Nombre_completo = "Admin predeterminado", Id_usuario = 2 };
            else
                usuarioActual = objusuario;
            InitializeComponent();
        }
    

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUSER.Text = usuarioActual.Nombre_completo;

            MostrarFormularioPresentacion();

            //if (usuarioActual.oRol.Id_rol == 1) //administrador
            //{
            //   menuVentas.Visible = false;
            //   menuEstadisticas.Visible = false;
               
            //}
            //if (usuarioActual.oRol.Id_rol == 2) //vendedor
            //{
            //    menuUsuarios.Visible = false;
            //    menuCompras.Visible = false;
            //    menuReportes.Visible = false;
            //    menuProveedores.Visible = false;
            //    menuProductos.Visible = false;
            //    menuEstadisticas.Visible =false;
            //}
            //if (usuarioActual.oRol.Id_rol == 3)//supervisor
            //{
            //    menuCompras.Visible=false;
            //    menuVentas.Visible=false;
            //    menuProductos.Visible=false;
            //    menuReportes.Visible=false;
            //    menuProveedores.Visible=false;
            //    menuClientes.Visible=false;
            //    menuProductosVer.Visible=false;
            //}
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
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


            contenedor.Controls.Add(formulario);
            formulario.Show();

        }


        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formCompras(usuarioActual));
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
            AbrirFormulario((IconMenuItem)sender, new formClientes(usuarioActual));
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
            DialogResult result = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lógica para cerrar sesión               
                this.Close();
            }
            else
            {
                // Lógica si el usuario no desea cerrar sesión
                MessageBox.Show("Permanecerás en sesión.");
            }        

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizar el formulario
        }

        private void menuProductosVer_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new VerProductos());
        }

        private void menuEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formEstadisticas());
        }

        private void MostrarFormularioPresentacion()
        {
            presentacionForm = new PresentacionForm();
            presentacionForm.TopLevel = false;
            presentacionForm.FormBorderStyle = FormBorderStyle.None;
            presentacionForm.Dock = DockStyle.Fill;
            contenedor.Controls.Add(presentacionForm);
            presentacionForm.Show();
        }
    }
}
