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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
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

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip8_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip7_Click(object sender, EventArgs e)
        {
      
        }

        private void menuUsuario_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void menuUsuario_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click_2(object sender, EventArgs e)
        {

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
    }
}
