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
    public class CD_producto
    {
        public List<Producto> Listar()
        {

            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id_producto,codigo,Nombre,p.descripcion,c.id_categoria,c.descripcion[descripcioncategoria],stock,precio_compra,precio_venta,p.estado from producto p");
                    query.AppendLine("inner join categoria c on c.id_categoria = p.id_categoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {


                        while (dr.Read())
                        {

                            lista.Add(new Producto()
                            {
                                Id_producto = Convert.ToInt32(dr["id_producto"]),
                                Codigo_prod = dr["codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["descripcion"].ToString(),
                                oCategoria = new Categoria() { Id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                Descripcion = dr["descripcioncategoria"].ToString() },
                                Stock = Convert.ToInt32(dr["stock"]),
                                Precio_compra = Convert.ToDecimal(dr["precio_compra"]),
                                Precio_venta = Convert.ToDecimal(dr["precio_venta"]),
                                Estado = Convert.ToBoolean(dr["estado"]),
                            });
                        }

                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }

            }

            return lista;
        }

        //REGISTRAR Producto
        public int Registrar(Producto obj, out string Mensaje)
        {
            int idProductoGen = 0;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_alta_producto", oconexion);
                    cmd.Parameters.AddWithValue("codigo", obj.Codigo_prod);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("id_categoria", obj.oCategoria.Id_categoria);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idProductoGen = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                idProductoGen = 0;
                Mensaje = ex.Message;
            }
            return idProductoGen;
        }

        //EDITAR Producto

        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    //declarando los parametros de entrada que necesita nuestro procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_modificar_producto", oconexion);
                    cmd.Parameters.AddWithValue("id_Producto", obj.Id_producto);
                    cmd.Parameters.AddWithValue("codigo", obj.Codigo_prod);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);
                    cmd.Parameters.AddWithValue("id_categoria", obj.oCategoria.Id_categoria);

                    //parametros de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    //abriendo conexion y ejecutando mi los comandos
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
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

        //ELIMINAR Producto
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    //declarando los parametros de entrada que necesita nuestro procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_eliminar_producto", oconexion);
                    cmd.Parameters.AddWithValue("id_producto", obj.Id_producto);
                    //parametros de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    //abriendo conexion y ejecutando mi los comandos
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
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
