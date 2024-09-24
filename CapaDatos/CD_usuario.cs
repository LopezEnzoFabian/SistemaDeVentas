using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;

namespace CapaDatos
{
    public class CD_usuario
    {
        public List<Usuario> Listar() { 

        List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {

                try
                {
                    string query = "select  Id_usuario,DNI,Nombre_completo,Email,Pass,telefono,direccion,estado from Usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
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
                                Estado = Convert.ToBoolean(dr["Estado"])
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
