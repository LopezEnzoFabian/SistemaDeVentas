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
using CapaPresentacion;


namespace CapaPresentacion
{
    public partial class formCategorias : Form
    {
        public formCategorias()
        {
            InitializeComponent();
        }

        private void formCategorias_Load(object sender, EventArgs e)
        {
            //agregar estado para mostrar en los cb
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

    
            //buscar en nuestro boton de busqueda
            foreach (DataGridViewColumn column in dgListaCategorias.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionar")
                {
                    cbFiltro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cbFiltro.DisplayMember = "Texto";
            cbFiltro.ValueMember = "Valor";
            cbFiltro.SelectedIndex = 0;


            //mostrar categorias en dgListacategorias
            List<Categoria> lista = new CN_categoria().Listar();
            foreach (Categoria item in lista)
            {
                dgListaCategorias.Rows.Add(new object[] {"",item.Id_categoria,
                    item.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                    });
            }
        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
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

                Categoria categoria = new Categoria()
                {
                    Descripcion = txtDescrip.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };

                //REGISTRAR USUARIO NUEVO
                if (categoria.Id_categoria == 0)
                {
                    //METODO REGISTRAR envia nuestros datos a la CN Y CD para ejecutar nuestro PROCEDIMIENTO ALMACENADO EN LA BD
                    int idGen = new CN_categoria().Registrar(categoria, out mensaje);
                    //guarda los datos en el datagrid
                    if (idGen != 0)
                    {
                        dgListaCategorias.Rows.Add(new object[] {"",idGen,txtDescrip.Text,
                    ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString()
                    });
                        MessageBox.Show("Usuario guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                    Limpiar();
                }
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
        }


        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea editar esta categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                string mensaje = string.Empty;

                Categoria obj = new Categoria()
                {
                    Id_categoria = Convert.ToInt32(txtID.Text),
                    Descripcion = txtDescrip.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };
        
                if (obj.Id_categoria != 0)
                {

                    bool resultadoEdicion = new CN_categoria().Editar(obj, out mensaje);

                    if (resultadoEdicion) {
                        DataGridViewRow row = dgListaCategorias.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["colid"].Value = txtID.Text;
                        row.Cells["colDescripcion"].Value = txtDescrip.Text;
                        row.Cells["colEstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString();
                        row.Cells["colEstado"].Value = ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show("Se han editado los datos correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                Limpiar();
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
        }


        private void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si hay campos vacíos
            }
            // Mensaje de confirmación para editar

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar esta categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                Categoria obj = new Categoria()
                {
                    Id_categoria = Convert.ToInt32(txtID.Text)
                };

                bool respuesta = new CN_categoria().Eliminar(obj, out mensaje);

                MessageBox.Show("Categoria eliminada con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (respuesta)
                {
                    dgListaCategorias.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                Limpiar();
            }
            else
            {
                // Acción cancelada
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                MessageBox.Show("Por favor, seleccione un filtro para la busqueda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaFiltro = ((OpcionCombo)cbFiltro.SelectedItem).Valor.ToString();
            if (dgListaCategorias.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListaCategorias.Rows)
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

        private void dgListaCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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



        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtID.Text = "0";
            txtDescrip.Clear();
            cbEstado.SelectedItem = null;
            txtDescrip.Select();
        }

        public bool ValidarCampos()
        {
            // Verifica si alguno de los campos está vacío o nulo
            return string.IsNullOrEmpty(txtDescrip.Text) ||
                   string.IsNullOrEmpty(cbEstado.Text);
        }


        private void dgListaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaCategorias.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtID.Text = dgListaCategorias.Rows[indice].Cells["colid"].Value.ToString();
                    txtDescrip.Text = dgListaCategorias.Rows[indice].Cells["colDescripcion"].Value.ToString();

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListaCategorias.Rows[indice].Cells["colEstadoValor"].Value))
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
            foreach (DataGridViewRow row in dgListaCategorias.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
