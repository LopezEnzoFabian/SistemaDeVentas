using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Reflection;

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
    }
}
