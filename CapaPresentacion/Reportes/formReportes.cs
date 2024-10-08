﻿using CapaPresentacion.Compras;
using CapaPresentacion.Reportes;
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
    public partial class formReportes : Form
    {
        private static IconButton MenuActivo = null;
        private static Form FormularioActivo = null;
        private static Form presentacionForm;

        public formReportes()
        {
            InitializeComponent();
        }

        private void formReportes_Load(object sender, EventArgs e)
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


            panelReportes.Controls.Add(formulario);
            formulario.Show();

        }

        

        private void btnVentasRepo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formReporteVentas());
        }

        private void btnComprasRepo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formReporteCompra());
        }

        private void MostrarFormularioPresentacion()
        {
            presentacionForm = new formReporteCompra();
            presentacionForm.TopLevel = false;
            presentacionForm.FormBorderStyle = FormBorderStyle.None;
            presentacionForm.Dock = DockStyle.Fill;
            panelReportes.Controls.Add(presentacionForm);
            presentacionForm.Show();
        }
    }
}
 