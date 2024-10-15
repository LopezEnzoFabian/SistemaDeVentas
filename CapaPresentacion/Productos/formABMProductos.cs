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
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formABMProductos : Form
    {
        public formABMProductos()
        {
            InitializeComponent();
        }

        private void formABMProductos_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            //Agregar categoria para mostrar en los cb
            List<Categoria> listaCategoria = new CN_categoria().Listar();
            foreach (Categoria item in listaCategoria)
            {
                cbCategoria.Items.Add(new OpcionCombo() { Valor = item.Id_categoria, Texto = item.Descripcion });
            }
            cbCategoria.DisplayMember = "Texto";
            cbCategoria.ValueMember = "Valor";
            cbCategoria.SelectedIndex = 0;


            //buscar en nuestro boton de busqueda
            foreach (DataGridViewColumn column in dgListarProductos.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionar")
                {
                    cbFiltro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cbFiltro.DisplayMember = "Texto";
            cbFiltro.ValueMember = "Valor";
            cbFiltro.SelectedIndex = 0;


            //mostrar productos en dgListaUsuarios
            List<Producto> listaProducto = new CN_productos().Listar();
            foreach (Producto item in listaProducto)
            {
                dgListarProductos.Rows.Add(new object[] {
                    "",item.Id_producto,
                    item.Codigo_prod,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.Id_categoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.Precio_compra,
                    item.Precio_venta,
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
    

            DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                string mensaje = string.Empty;

                Producto producto = new Producto()
                {
                    Codigo_prod = txtCodigoPro.Text,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescri.Text,
                    oCategoria = new Categoria() { Id_categoria = Convert.ToInt32(((OpcionCombo)cbCategoria.SelectedItem).Valor)},
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };

                //REGISTRAR PRODUCTO NUEVO
                if (producto.Id_producto == 0)
                {
                    //METODO REGISTRAR envia nuestros datos a la CN Y CD para ejecutar nuestro PROCEDIMIENTO ALMACENADO EN LA BD
                    int idGen = new CN_productos().Registrar(producto, out mensaje);
                    //guarda los datos en el datagrid
                    if (idGen != 0)
                    {
                        dgListarProductos.Rows.Add(new object[] {
                            "",
                            idGen,
                            txtCodigoPro.Text,
                            txtNombre.Text,
                            txtDescri.Text,
                            ((OpcionCombo)cbCategoria.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cbCategoria.SelectedItem).Texto.ToString(),
                            "0",
                            "0.00",
                            "0.00",
                            ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString(),
                           
                    });
                        MessageBox.Show("Producto guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                    limpiarCampos();
                }
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Gancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarCampos();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }

            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                Producto obj = new Producto()
                {
                    Id_producto = Convert.ToInt32(txtID.Text)
                };

                bool respuesta = new CN_productos().Eliminar(obj, out mensaje);

                MessageBox.Show("Producto eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (respuesta)
                {
                    dgListarProductos.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                limpiarCampos();
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarCampos();
        }
 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea editar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                string mensaje = string.Empty;

                Producto obj = new Producto()
                {
                    Id_producto = Convert.ToInt32(txtID.Text),
                    Codigo_prod = txtCodigoPro.Text,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescri.Text,
                    oCategoria = new Categoria() { Id_categoria = Convert.ToInt32(((OpcionCombo)cbCategoria.SelectedItem).Valor) },
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };

                if (obj.Id_producto != 0)
                {

                    bool resultadoEdicion = new CN_productos().Editar(obj, out mensaje);

                    if (resultadoEdicion)
                    {
                        DataGridViewRow row = dgListarProductos.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["colID"].Value = txtID.Text;
                        row.Cells["colCodigo"].Value = txtCodigoPro.Text;
                        row.Cells["colNombre"].Value = txtNombre.Text;
                        row.Cells["colDescripcion"].Value = txtDescri.Text;
                        row.Cells["colIdcategoria"].Value = ((OpcionCombo)cbCategoria.SelectedItem).Valor.ToString();
                        row.Cells["colCategoria"].Value = ((OpcionCombo)cbCategoria.SelectedItem).Texto.ToString();
                        row.Cells["colEstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString();
                        row.Cells["colEstado"].Value = ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show("Se han editado los datos correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    limpiarCampos();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                limpiarCampos();
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
            return string.IsNullOrEmpty(txtNombre.Text) ||
                   string.IsNullOrEmpty(txtCodigoPro.Text) ||
                   string.IsNullOrEmpty(txtDescri.Text) ||
                   string.IsNullOrEmpty(cbCategoria.Text) ||
                   string.IsNullOrEmpty(cbEstado.Text);
        }

        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtCodigoPro.Clear();
            txtDescri.Clear();
            cbCategoria.SelectedItem = null;
            cbEstado.SelectedItem = null;

            txtID.Text = "0";
            txtindice.Text = "-1";
        }

        private void txtCodigoPro_KeyPress(object sender, KeyPressEventArgs e)
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

            string columnaFiltro = ((OpcionCombo)cbFiltro.SelectedItem).Valor.ToString();
            if (dgListarProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListarProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        public bool ValidarFiltro()
        {
            return string.IsNullOrEmpty(cbFiltro.Text);
        }

        private void dgListarProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgListarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListarProductos.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtID.Text = dgListarProductos.Rows[indice].Cells["colID"].Value.ToString();

                    txtCodigoPro.Text = dgListarProductos.Rows[indice].Cells["colCodigo"].Value.ToString();
                    txtNombre.Text = dgListarProductos.Rows[indice].Cells["colNombre"].Value.ToString();
                    txtDescri.Text = dgListarProductos.Rows[indice].Cells["colDescripcion"].Value.ToString();

                    foreach (OpcionCombo oc in cbCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListarProductos.Rows[indice].Cells["colIdcategoria"].Value))
                        {
                            int indice_combo = cbCategoria.Items.IndexOf(oc);
                            cbCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListarProductos.Rows[indice].Cells["colEstadoValor"].Value))
                        {
                            int indice_combo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgListarProductos.Rows)
            {
                row.Visible = true;
            }
        }
    }
}

