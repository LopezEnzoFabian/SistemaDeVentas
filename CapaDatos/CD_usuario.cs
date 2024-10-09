using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Reflection;
using System.Collections;
using System.Net;

namespace CapaDatos
{
    public class CD_usuario
    {
        public List<Usuario> Listar() { 

        List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.id_usuario, u.DNI, u.Nombre_completo, u.Email, u.Pass, u.telefono, u.direccion, u.estado, r.id_rol, r.descripcion from Usuario u");
                    query.AppendLine("inner join Rol r on r.id_rol = u.id_rol");
                                                                                                                                                               
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {


                        while (dr.Read())
                        {

                            lista.Add(new Usuario()
                            {
                                Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                                DNI = dr["DNI"].ToString(),
                                Nombre_completo = dr["Nombre_completo"].ToString(),
                                Email = dr["Email"].ToString(),
                                Pass = dr["Pass"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol() { Id_rol = Convert.ToInt32(dr["id_rol"]), 
                                Descripcion = dr["Descripcion"].ToString() }
                            });
                        }

                    }
                }

                catch (Exception ex) {
                lista = new List<Usuario>();
                }

            }


            return lista;

        }

        //REGISTRAR 
        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idusuarioGen = 0;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {

                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("DNI",obj.DNI);
                    cmd.Parameters.AddWithValue("Nombre_completo", obj.Nombre_completo);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Pass", obj.Pass);
                    cmd.Parameters.AddWithValue("telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("id_rol", obj.oRol.Id_rol);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);

                    cmd.Parameters.Add("id_usuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idusuarioGen = Convert.ToInt32(cmd.Parameters["id_usuarioResultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex) {
                idusuarioGen = 0;
                Mensaje = ex.Message;
            }
        return idusuarioGen;
        }

        //EDITAR

        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    //declarando los parametros de entrada que necesita nuestro procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("SP_EditarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", obj.Id_usuario);
                    cmd.Parameters.AddWithValue("DNI", obj.DNI);
                    cmd.Parameters.AddWithValue("Nombre_completo", obj.Nombre_completo);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Pass", obj.Pass);
                    cmd.Parameters.AddWithValue("telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("id_rol", obj.oRol.Id_rol);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);
                    //parametros de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                    //abriendo conexion y ejecutando mi los comandos
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }

        //ELIMINAR
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    //declarando los parametros de entrada que necesita nuestro procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", obj.Id_usuario);
                    //parametros de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    //abriendo conexion y ejecutando mi los comandos
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

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
