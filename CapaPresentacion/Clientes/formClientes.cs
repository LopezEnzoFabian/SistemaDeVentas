using Capa_Entidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static CapaPresentacion.formUsuarios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class formClientes : Form
    {
        private int fila = 0;
        private Usuario usuarioActual;
        public formClientes(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }


        private void formClientes_Load(object sender, EventArgs e)
        {
            //if (usuarioActual.oRol.Id_rol == 2) // Cambia 2 por el ID del rol que representa a "cliente"
            //{
            //    btnEliminar.Visible = false; // Cambia 'btnBoton' por el nombre del botón que deseas ocultar
            //}

            //agregar estado para mostrar en los cb
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            //buscar en nuestro boton de busqueda
            foreach (DataGridViewColumn column in dgListaCliente.Columns)
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
            List<Cliente> listacliente = new CN_cliente().Listar();
            foreach (Cliente item in listacliente)
            {
                dgListaCliente.Rows.Add(new object[] {
                    "",
                    item.Id_cliente,
                    item.DNI,
                    item.Nombre_completo,
                    item.Email,
                    item.Telefono,
                    item.Direccion,
                    item.Codigo_postal,
                    item.Ciudad,
                    item.Localidad,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                 });
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
                string mensaje = string.Empty;

                Cliente objcliente = new Cliente()
                {
                    DNI = txtDNI.Text,
                    Nombre_completo = txtNombrecliente.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTel.Text,
                    Direccion = txtDireccion.Text,
                    Codigo_postal = txtCodPostal.Text,
                    Ciudad = txtCiudad.Text,
                    Localidad = txtLocalidad.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };

                //REGISTRAR CLIENTE NUEVO
                if (objcliente.Id_cliente == 0)
                {
                    //METODO REGISTRAR envia nuestros datos a la CN Y CD para ejecutar nuestro PROCEDIMIENTO ALMACENADO EN LA BD
                    int idusuarioGen = new CN_cliente().Registrar(objcliente, out mensaje);
                    //guarda los datos en el datagrid
                    if (idusuarioGen != 0)
                    {
                    dgListaCliente.Rows.Add(new object[] {
                            "",
                            idusuarioGen,
                            txtDNI.Text,
                            txtNombrecliente.Text,
                            txtEmail.Text,
                            txtTel.Text,
                            txtDireccion.Text,
                            txtCodPostal.Text,
                            txtCiudad.Text,
                            txtLocalidad.Text,
                            ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString()
                    });
                        MessageBox.Show("Cliente guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(txtDNI.Text) ||
                   string.IsNullOrEmpty(txtNombrecliente.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text) ||
                   string.IsNullOrEmpty(txtTel.Text) ||
                   string.IsNullOrEmpty(cbEstado.Text) ||
                   string.IsNullOrEmpty(txtCiudad.Text) ||
                   string.IsNullOrEmpty(txtDireccion.Text) ||
                   string.IsNullOrEmpty(txtLocalidad.Text) ||
                   string.IsNullOrEmpty(txtCodPostal.Text);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras((KeyPressEventArgs)e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void limpiarCampos()
        {
            txtDNI.Clear();
            txtNombrecliente.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtDireccion.Clear();
            txtCodPostal.Clear();
            txtCiudad.Clear();
            txtLocalidad.Clear();

            txtID.Text = "0";
            txtindice.Text = "-1";
        }
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Comprobar la respuesta del usuario

            if (Convert.ToInt32(txtID.Text) != 0)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar este cliente", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente objcliente = new Cliente()
                    {
                        Id_cliente = Convert.ToInt32(txtID.Text)
                    };

                    bool respuesta = new CN_cliente().Eliminar(objcliente, out mensaje);

                    MessageBox.Show("Cliente eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (respuesta)
                    {
                        dgListaCliente.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        dgListaCliente.Refresh();
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
                MessageBox.Show("Por favor, complete los campos del cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar
            DialogResult resultado = MessageBox.Show(
            "¿Está seguro que desea editar este cliente?", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del cliente
            if (resultado == DialogResult.Yes)
            {
                string mensaje = string.Empty;

                Cliente obj = new Cliente()
                {
                    Id_cliente = Convert.ToInt32(txtID.Text),
                    DNI = txtDNI.Text,
                    Nombre_completo = txtNombrecliente.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTel.Text,
                    Direccion = txtDireccion.Text,
                    Codigo_postal = txtCodPostal.Text,
                    Ciudad = txtCiudad.Text,
                    Localidad = txtLocalidad.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };

                if (obj.Id_cliente != 0)
                {
                    bool resultadoEdicion = new CN_cliente().Editar(obj, out mensaje);

                    if (resultadoEdicion)
                    {
                        DataGridViewRow row = dgListaCliente.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["colID"].Value = txtID.Text;
                        row.Cells["colDNI"].Value = txtDNI.Text;
                        row.Cells["colNombre"].Value = txtNombrecliente.Text;
                        row.Cells["colEmail"].Value = txtEmail.Text;
                        row.Cells["colTelefono"].Value = txtTel.Text;
                        row.Cells["colDireccion"].Value = txtDireccion.Text;
                        row.Cells["colCodigoPostal"].Value = txtCodPostal.Text;
                        row.Cells["colCiudad"].Value = txtCiudad.Text;
                        row.Cells["colLocalidad"].Value = txtLocalidad.Text;
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show("Se han editado los datos correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros((KeyPressEventArgs)e);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("No haz seleccionado un filtro!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(cbFiltro.Text);
        }

        private void dgListaCliente_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaCliente.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtID.Text = dgListaCliente.Rows[indice].Cells["colID"].Value.ToString();
                    txtDNI.Text = dgListaCliente.Rows[indice].Cells["colDNI"].Value.ToString();
                    txtNombrecliente.Text = dgListaCliente.Rows[indice].Cells["colNombre"].Value.ToString();
                    txtEmail.Text = dgListaCliente.Rows[indice].Cells["colEmail"].Value.ToString();
                    txtTel.Text = dgListaCliente.Rows[indice].Cells["colTelefono"].Value.ToString();
                    txtDireccion.Text = dgListaCliente.Rows[indice].Cells["colDireccion"].Value.ToString();
                    txtCodPostal.Text = dgListaCliente.Rows[indice].Cells["colCodigoPostal"].Value.ToString();
                    txtCiudad.Text = dgListaCliente.Rows[indice].Cells["colCiudad"].Value.ToString();
                    txtLocalidad.Text = dgListaCliente.Rows[indice].Cells["colLocalidad"].Value.ToString();

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListaCliente.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void dgListaCliente_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione un filtro para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaFiltro = ((OpcionCombo)cbFiltro.SelectedItem).Valor.ToString();
            if (dgListaCliente.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListaCliente.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgListaCliente.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
