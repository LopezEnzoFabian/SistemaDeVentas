using Capa_Entidad;
using CapaNegocio;
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
    public partial class formProveedores : Form
    {
        public formProveedores()
        {
            InitializeComponent();
        }


        private void formProveedores_Load(object sender, EventArgs e)
        {
            //agregar estado para mostrar en los cb
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            //buscar en nuestro boton de busqueda
            foreach (DataGridViewColumn column in dgListaProveedores.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionar")
                {
                    cbFiltro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cbFiltro.DisplayMember = "Texto";
            cbFiltro.ValueMember = "Valor";
            cbFiltro.SelectedIndex = 0;

            //mostrar usuarios en dgListaUsuarios
            List<Proveedor> lista = new CN_proveedor().Listar();
            foreach (Proveedor item in lista)
            {
                dgListaProveedores.Rows.Add(new object[] {
                    "",
                    item.Id_proveedor,
                    item.DNI,
                    item.RazonSocial,
                    item.Email,
                    item.Telefono,
                    item.Direccion,
                    item.Codigo_postal,
                    item.Ciudad,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                 });
            }
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
                // Dimensiones de la imagen original
                var originalImage = Properties.Resources.check;
                // Reducir el tamaño de la imagen
                int margin = 4; // Ajusta este margen según lo necesites
                var newWidth = cellWidth - margin;
                var newHeight = cellHeight - margin;
                // Calcular la posición centrada
                var x = e.CellBounds.Left + (cellWidth - newWidth) / 2;
                var y = e.CellBounds.Top + (cellHeight - newHeight) / 2;
                // Redimensionar la imagen
                using (var resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight)))
                {
                    e.Graphics.DrawImage(resizedImage, new Rectangle(x, y, newWidth, newHeight));
                }
                e.Handled = true;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            if (!Validaciones.EsEmailValido(txtEmail.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("El formato de email no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Tomar decisiones basadas en la respuesta del usuario
            if (ask == DialogResult.Yes)
            {
                // Si el usuario hizo clic en "Sí"
                string mensaje = string.Empty;

                Proveedor obj = new Proveedor()
                {
                    DNI = txtDNI.Text,
                    RazonSocial = txtRazonS.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTel.Text,
                    Direccion = txtDireccion.Text,
                    Codigo_postal = txtCodPostal.Text,
                    Ciudad = txtCiudad.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };

                //REGISTRAR PROVEEDOR NUEVO
                if (obj.Id_proveedor == 0)
                {
                    //METODO REGISTRAR envia nuestros datos a la CN Y CD para ejecutar nuestro PROCEDIMIENTO ALMACENADO EN LA BD
                    int idusuarioGen = new CN_proveedor().Registrar(obj, out mensaje);
                    //guarda los datos en el datagrid
                    if (idusuarioGen != 0)
                    {
                        dgListaProveedores.Rows.Add(new object[] {
                            "",
                            idusuarioGen,
                            txtDNI.Text,
                            txtRazonS.Text,
                            txtEmail.Text,
                            txtTel.Text,
                            txtDireccion.Text,
                            txtCodPostal.Text,
                            txtCiudad.Text,
                            ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString()
                    });
                        MessageBox.Show("Proveedor registrado correctamente", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                    limpiarCampos();
                }
            }
        }
        


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete los campos del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea editar este proveedor?", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                string mensaje = string.Empty;

                Proveedor obj = new Proveedor()
                {
                    Id_proveedor = Convert.ToInt32(txtID.Text),
                    DNI = txtDNI.Text,
                    RazonSocial = txtRazonS.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTel.Text,
                    Direccion = txtDireccion.Text,
                    Codigo_postal = txtCodPostal.Text,
                    Ciudad = txtCiudad.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };

                if (obj.Id_proveedor != 0)
                {
                    bool resultadoEdicion = new CN_proveedor().Editar(obj, out mensaje);

                    if (resultadoEdicion)
                    {
                        DataGridViewRow row = dgListaProveedores.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["colID"].Value = txtID.Text;
                        row.Cells["colDNI"].Value = txtDNI.Text;
                        row.Cells["colRazonSocial"].Value = txtRazonS.Text;
                        row.Cells["colEmail"].Value = txtEmail.Text;
                        row.Cells["colTel"].Value = txtTel.Text;
                        row.Cells["colDireccion"].Value = txtDireccion.Text;
                        row.Cells["colCodigoPostal"].Value = txtCodPostal.Text;
                        row.Cells["colCiudad"].Value = txtCiudad.Text;
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show("Se han editado los datos correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtID.Text) != 0)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar este proveedor", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor obj = new Proveedor()
                    {
                        Id_proveedor = Convert.ToInt32(txtID.Text)
                    };

                    bool respuesta = new CN_proveedor().Eliminar(obj, out mensaje);

                    MessageBox.Show("Proveedor eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (respuesta)
                    {
                        dgListaProveedores.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        dgListaProveedores.Refresh();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                    limpiarCampos();
                }
            }
        }



        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);

        }

        private void txtRazonS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras((KeyPressEventArgs)e);

        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
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
            return string.IsNullOrEmpty(cbFiltro.Text);
        }

        private void limpiarCampos()
        {
            txtDNI.Clear();
            txtRazonS.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtCodPostal.Clear();
            cbEstado.SelectedItem = null;

            txtID.Text = "0";
            txtindice.Text = "-1";
        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(txtDNI.Text) ||
                   string.IsNullOrEmpty(txtRazonS.Text) ||
                   string.IsNullOrEmpty(txtTel.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text) ||
                   string.IsNullOrEmpty(txtCiudad.Text) ||
                   string.IsNullOrEmpty(cbEstado.Text) ||
                   string.IsNullOrEmpty(txtDireccion.Text) ||
                   string.IsNullOrEmpty(txtCodPostal.Text);
        }

        private void btnclean_Click(object sender, EventArgs e)
        {

        }

        private void dgListaProveedoreses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtID.Text = dgListaProveedores.Rows[indice].Cells["colID"].Value.ToString();
                    txtDNI.Text = dgListaProveedores.Rows[indice].Cells["colDNI"].Value.ToString();
                    txtRazonS.Text = dgListaProveedores.Rows[indice].Cells["colRazonSocial"].Value.ToString();
                    txtEmail.Text = dgListaProveedores.Rows[indice].Cells["colEmail"].Value.ToString();
                    txtTel.Text = dgListaProveedores.Rows[indice].Cells["colTel"].Value.ToString();
                    txtDireccion.Text = dgListaProveedores.Rows[indice].Cells["colDireccion"].Value.ToString();
                    txtCodPostal.Text = dgListaProveedores.Rows[indice].Cells["colCodigoPostal"].Value.ToString();
                    txtCiudad.Text = dgListaProveedores.Rows[indice].Cells["colCiudad"].Value.ToString();

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListaProveedores.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void dgListaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtID.Text = dgListaProveedores.Rows[indice].Cells["colID"].Value.ToString();
                    txtDNI.Text = dgListaProveedores.Rows[indice].Cells["colDNI"].Value.ToString();
                    txtRazonS.Text = dgListaProveedores.Rows[indice].Cells["colRazonSocial"].Value.ToString();
                    txtEmail.Text = dgListaProveedores.Rows[indice].Cells["colEmail"].Value.ToString();
                    txtTel.Text = dgListaProveedores.Rows[indice].Cells["colTel"].Value.ToString();
                    txtDireccion.Text = dgListaProveedores.Rows[indice].Cells["colDireccion"].Value.ToString();
                    txtCodPostal.Text = dgListaProveedores.Rows[indice].Cells["colCodigoPostal"].Value.ToString();
                    txtCiudad.Text = dgListaProveedores.Rows[indice].Cells["colCiudad"].Value.ToString();

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListaProveedores.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
