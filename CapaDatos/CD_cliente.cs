using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from Cliente");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Cliente()
                            {
                                Id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                DNI = dr["DNI"].ToString(),
                                Nombre_completo = dr["Nombre_completo"].ToString(),
                                Email = dr["Email"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                Direccion = dr["direccion"].ToString(),
                                Codigo_postal = dr["codigo_postal"].ToString(),
                                Ciudad = dr["ciudad"].ToString(),
                                Estado = Convert.ToBoolean(dr["estado"]),
                                Localidad = dr["localidad"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }
            }
            return lista;
        }

        //REGISTRAR CLIENTE
        public int Registrar(Cliente obj, out string Mensaje)
        {
            int idusuarioGen = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_registrar_cliente", oconexion);
                    cmd.Parameters.AddWithValue("DNI", obj.DNI);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.Nombre_completo);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("CodigoPostal", obj.Codigo_postal);
                    cmd.Parameters.AddWithValue("Ciudad", obj.Ciudad);
                    cmd.Parameters.AddWithValue("Localidad", obj.Localidad);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idusuarioGen = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                idusuarioGen = 0;
                Mensaje = ex.Message;
            }
            return idusuarioGen;
        }

        //EDITAR CLIENTE

        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    //declarando los parametros de entrada que necesita nuestro procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_modificar_cliente", oconexion);
                    cmd.Parameters.AddWithValue("id_cliente", obj.Id_cliente);
                    cmd.Parameters.AddWithValue("DNI", obj.DNI);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.Nombre_completo);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("CodigoPostal", obj.Codigo_postal);
                    cmd.Parameters.AddWithValue("ciudad", obj.Ciudad);
                    cmd.Parameters.AddWithValue("localidad", obj.Localidad);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);
                    //parametros de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    //abriendo conexion y ejecutando mi los comandos
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from Cliente where id_cliente = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", obj.Id_cliente);
                    //abriendo conexion y ejecutando mi los comandos
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
