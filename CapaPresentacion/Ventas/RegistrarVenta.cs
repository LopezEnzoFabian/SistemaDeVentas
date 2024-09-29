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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton) sender, new VentasListarCliente());
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new VentasListarProducto());
        }

        private void ibtnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
               "¿Está seguro que desea agregar su venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Se a agregado su venta", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limpiarCampos();
        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(dtFechaVenta.Text) ||
                   string.IsNullOrEmpty(cbTIpoFac.Text) ||
                   string.IsNullOrEmpty(txtNumDoc.Text) ||
                   string.IsNullOrEmpty(txtNombreCliente.Text) ||
                   string.IsNullOrEmpty(txtCodProd.Text) ||
                   string.IsNullOrEmpty(txtProducto.Text) ||
                   string.IsNullOrEmpty(txtPrecioCom.Text) ||
                   string.IsNullOrEmpty(txtPrecioVen.Text) ||
                   string.IsNullOrEmpty(nudCant.Text);
        }

        private void limpiarCampos()
        {
            cbTIpoFac.SelectedItem = null;
            cbTIpoFac.SelectedItem = null;
            txtNumDoc.Clear();
            txtCodProd.Clear();
            txtProducto.Clear();
            txtPrecioCom.Clear();
            txtPrecioVen.Clear();
        }

        private void ibtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dgRegistrarVenta.Rows.Count == 1)
            {
                MessageBox.Show("No hay productos para registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
