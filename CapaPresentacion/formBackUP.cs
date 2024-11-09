using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formBackUP : Form
    {
        public formBackUP()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Configurar el cuadro de diálogo para seleccionar la ubicación del archivo de respaldo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar archivo de respaldo de base de datos";
            saveFileDialog.FileName = "MiBackup.bak"; // Nombre predeterminado para el archivo de respaldo

            // Si el usuario selecciona una ubicación y nombre de archivo
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaBackup = saveFileDialog.FileName;

                // Cadena de conexión a la base de datos SQL Server
                string connectionString = "Server=.\\sqlexpress; Database=Electrohub_Taller2; Integrated Security=True;";

                // Comando SQL para realizar el respaldo de la base de datos
                string backupQuery = $@"
                    BACKUP DATABASE Electrohub_Taller2
                    TO DISK = '{rutaBackup}'
                    WITH FORMAT,
                         MEDIANAME = 'MiBaseDeDatos_Backup',
                         NAME = 'Respaldo Completo de MiBaseDeDatos';";

                try
                {
                    // Crear conexión con SQL Server
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Ejecutar el comando para crear el respaldo
                        using (SqlCommand command = new SqlCommand(backupQuery, connection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Respaldo de base de datos generado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al generar el respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRESTAURAR_Click(object sender, EventArgs e)
        {
            // Configurar el cuadro de diálogo para seleccionar el archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
            openFileDialog.Title = "Seleccionar archivo de base de datos para importar";

            // Si el usuario selecciona un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo
                string archivoBD = openFileDialog.FileName;

                // Cadena de conexión a la base de datos SQL Server
                string connectionString = "Server=.\\sqlexpress; Database=master; Integrated Security=True;";

                // Comando SQL para restaurar la base de datos
                string restoreQuery = $@"
                    ALTER DATABASE Electrohub_Taller2 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE Electrohub_Taller2
                    FROM DISK = '{archivoBD}'
                    WITH REPLACE;";

                try
                {
                    // Crear conexión con SQL Server
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Ejecutar el comando para restaurar la base de datos
                        using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Base de datos importada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al importar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
