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
                dgListarUsuario.Rows.Add(new object[] {"",item.Id_usuario,item.Nombre_completo,item.DNI,item.Email,item.Pass,item.Direccion,item.Telefono,
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
                     string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                     string.IsNullOrWhiteSpace(txtTelefono.Text) ||
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
                string mensaje = string.Empty;

                Usuario objusuario = new Usuario()
                {
                    Id_usuario = Convert.ToInt32(txtid.Text),
                    DNI = txtDNI.Text,
                    Nombre_completo = txtNombre.Text,
                    Email = txtEmail.Text,
                    Pass = txtPass.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    oRol = new Rol() { Id_rol = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).Valor) },
                    Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
                };
            
                //REGISTRAR USUARIO NUEVO
                if (objusuario.Id_usuario == 0)
                {
                    //METODO REGISTRAR envia nuestros datos a la CN Y CD para ejecutar nuestro PROCEDIMIENTO ALMACENADO EN LA BD
                    int idusuarioGen = new CN_usuario().Registrar(objusuario, out mensaje);
                    //guarda los datos en el datagrid
                    if (idusuarioGen != 0)
                    {
                    dgListarUsuario.Rows.Add(new object[] {"",idusuarioGen,txtNombre.Text,txtDNI.Text,txtEmail.Text,txt_Confirmpass,txtDireccion.Text,txtTelefono.Text,
                    ((OpcionCombo)cbRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbRol.SelectedItem).Texto.ToString(),
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
                //SI NO ES UN USUARIO NUEVO EL QUE SE A SELECCIONADO VAMOS A EDITAR
                else
                {
                    bool resultado = new CN_usuario().Editar(objusuario, out mensaje);
                    if (resultado)
                    {
                        DataGridViewRow row = dgListarUsuario.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["colid"].Value = txtid.Text;
                        row.Cells["colNombre"].Value = txtNombre.Text;
                        row.Cells["colDNI"].Value = txtDNI.Text;
                        row.Cells["colEmail"].Value = txtEmail.Text;
                        row.Cells["colPass"].Value = txtPass.Text;
                        row.Cells["colDireccion"].Value = txtDireccion.Text;
                        row.Cells["colTelefono"].Value = txtTelefono.Text;
                        row.Cells["idRol"].Value = ((OpcionCombo)cbRol.SelectedItem).Valor.ToString();
                        row.Cells["colRol"].Value = ((OpcionCombo)cbRol.SelectedItem).Texto.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cbEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cbEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show("Se han editado los datos correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }
   

        private void btnEliminar_Click(object sender, EventArgs e)
        {
 
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar este usuario", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        Id_usuario = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_usuario().Eliminar(objusuario, out mensaje);

                    MessageBox.Show("Usuario eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (respuesta)
                    {
                        dgListarUsuario.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                    Limpiar();
                }
            }

           
        }
        
        private void dgListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListarUsuario.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtid.Text = dgListarUsuario.Rows[indice].Cells["colid"].Value.ToString();
                    txtNombre.Text = dgListarUsuario.Rows[indice].Cells["colNombre"].Value.ToString();
                    txtDNI.Text = dgListarUsuario.Rows[indice].Cells["colDNI"].Value.ToString();
                    txtEmail.Text = dgListarUsuario.Rows[indice].Cells["colEmail"].Value.ToString();
                    txtPass.Text = dgListarUsuario.Rows[indice].Cells["colPass"].Value.ToString();
                    txt_Confirmpass.Text = dgListarUsuario.Rows[indice].Cells["colPass"].Value.ToString();
                    txtDireccion.Text = dgListarUsuario.Rows[indice].Cells["colDireccion"].Value.ToString();
                    txtTelefono.Text = dgListarUsuario.Rows[indice].Cells["colTelefono"].Value.ToString();

                    foreach (OpcionCombo oc in cbRol.Items)
                    {
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListarUsuario.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cbRol.Items.IndexOf(oc);
                            cbRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgListarUsuario.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
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

            string columnaFiltro = ((OpcionCombo)cbFiltroTipoUsuario.SelectedItem).Valor.ToString();
            if(dgListarUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgListarUsuario.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscarUsuario.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
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

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtid.Text = "0";
            txtDNI.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txt_Confirmpass.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cbEstado.SelectedItem = null;
            cbRol.SelectedItem = null;


            txtNombre.Select();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Text = "";
            foreach (DataGridViewRow row in dgListarUsuario.Rows)
            {
                    row.Visible = true;
            }
        }

      
    }
}
