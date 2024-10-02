﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using Capa_Entidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class formUsuarios : Form
    {
        public formUsuarios()
        {
            InitializeComponent();
        }

        private void formUsuarios_Load(object sender, EventArgs e)
        {
            //agregar estado para mostrar en los cb
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            //Agregar rol para mostrar en los cb
            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cbRol.Items.Add(new OpcionCombo() { Valor = item.Id_rol,Texto = item.Descripcion});
            }
            cbRol.DisplayMember = "Texto";
            cbRol.ValueMember = "Valor";
            cbRol.SelectedIndex = 0;


            //buscar en nuestro boton de busqueda
            foreach (DataGridViewColumn column in dgListarUsuario.Columns) { 
                if(column.Visible == true && column.Name != "btnSeleccionar")
                {
                    cbFiltroTipoUsuario.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                 }
            }
            cbFiltroTipoUsuario.DisplayMember = "Texto";
            cbFiltroTipoUsuario.ValueMember = "Valor";
            cbFiltroTipoUsuario.SelectedIndex = 0;


            //mostrar usuarios en dgListaUsuarios
            List<Usuario> listausuario = new CN_usuario().Listar();
            foreach (Usuario item in listausuario)
            {
                dgListarUsuario.Rows.Add(new object[] {"",item.Id_usuario,item.DNI,item.Nombre_completo,item.Email,txt_Confirmpass,item.Direccion,item.Telefono,
                    item.oRol.Id_rol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                    });
            }
        }
    
        


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                     string.IsNullOrWhiteSpace(txtNombre.Text) ||
                     string.IsNullOrWhiteSpace(cbRol.Text) ||
                     string.IsNullOrWhiteSpace(cbEstado.Text) ||
                     string.IsNullOrWhiteSpace(txtPass.Text) ||
                     string.IsNullOrWhiteSpace(txtEmail.Text) ||
                     string.IsNullOrWhiteSpace(txt_Confirmpass.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPass.Text != txt_Confirmpass.Text)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Las contraseñas deben coincidir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPass.Text.Length < 8)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Las contraseña debe tener almenos 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsEmailValido(txtEmail.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Tomar decisiones basadas en la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                // Si el usuario hizo clic en "Sí"
                MessageBox.Show("Usuario guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //guarda los datos en el datagrid
                    dgListarUsuario.Rows.Add(new object[] {"",txtID,txtDNI.Text,txtNombre.Text,txtEmail.Text,txt_Confirmpass,txtDireccion.Text,txtTelefono.Text,
                    ((OpcionCombo)cbRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbRol.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString()
                    });
                }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (  string.IsNullOrWhiteSpace(txtDNI.Text) ||
                  string.IsNullOrWhiteSpace(txtNombre.Text) ||
                  string.IsNullOrWhiteSpace(cbRol.Text) ||
                  string.IsNullOrWhiteSpace(cbEstado.Text) ||
                  string.IsNullOrWhiteSpace(txtPass.Text) ||
                  string.IsNullOrWhiteSpace(txtEmail.Text) ||
                  string.IsNullOrWhiteSpace(txt_Confirmpass.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe seleccionar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           if(txtPass.Text != txt_Confirmpass.Text)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Las contraseñas deben coincidir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsEmailValido(txtEmail.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
                DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Tomar decisiones basadas en la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                    // Si el usuario hizo clic en "Sí"
                    MessageBox.Show("Cambios guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "Seguro que desea eliminar este usuario";
            string titulo = "Confirmar Eliminación";
            DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {
                string msj = "Usuario eliminado con exito";
                string titulo2 = "Eliminar";
                MessageBox.Show(msj, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDNI.Clear();
                txtNombre.Clear();
                cbEstado.Items.Clear();
                cbRol.Items.Clear();
                txtEmail.Clear();
                txtPass.Clear();
                txt_Confirmpass.Clear();
                
            }
        }

        private void dgListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgListarUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0) // Suponiendo que el botón está en la primera columna
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;

                var originalImage = Properties.Resources.check;

                int margin = 4; // Ajusta este margen según lo necesites
                var newWidth = cellWidth - margin;
                var newHeight = cellHeight - margin;

                var x = e.CellBounds.Left + (cellWidth - newWidth) / 2;
                var y = e.CellBounds.Top + (cellHeight - newHeight) / 2;
                using (var resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight)))
                {
                    e.Graphics.DrawImage(resizedImage, new Rectangle(x, y, newWidth, newHeight));
                }
                e.Handled = true;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione un filtro para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(cbFiltroTipoUsuario.Text);
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras((KeyPressEventArgs)e);
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }
    }
}
