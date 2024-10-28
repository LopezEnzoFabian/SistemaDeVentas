using Capa_Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_compras
    {
        public int OptenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) +1 from Compra ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }


        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_registrar_compra", oconexion);
                    cmd.Parameters.AddWithValue("Idusuario", obj.oUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("Idproveedor", obj.oProveedor.Id_proveedor);
                    cmd.Parameters.AddWithValue("Tipofactura", obj.Tipo_factura);
                    cmd.Parameters.AddWithValue("Numerofactura", obj.Numero_factura);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.Monto_total);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return respuesta;
        }


        //consulta a nuestra base de datos para obtener un registro de una compra
        public Compra SeleccionarCompra(string numero)
        {
            Compra obj = new Compra();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.id_compra,c.tipoDe_factura,c.numeroDe_factura,c.montoTotal,convert(char(10),c.fecha_registro,103)[FechaRegistro],");
                    query.AppendLine("u.Nombre_completo,");
                    query.AppendLine("pr.DNI,pr.Razon_social");
                    query.AppendLine("from Compra c");
                    query.AppendLine("inner join Usuario u on u.id_usuario = c.id_usuario");
                    query.AppendLine("inner join Proveedor pr on pr.id_proveedor = c.id_proveedor");
                    query.AppendLine("where c.numeroDe_factura = @numero");

                   SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Compra()
                            {
                                Id_compra = Convert.ToInt32(dr["id_compra"]),
                                Tipo_factura = dr["tipoDe_factura"].ToString(),
                                Monto_total = Convert.ToDecimal(dr["montoTotal"].ToString()),
                                Fecha_registro = dr["FechaRegistro"].ToString(),
                                oProveedor = new Proveedor() { DNI = dr["DNI"].ToString(), RazonSocial = dr["Razon_social"].ToString()},
                                oUsuario = new Usuario() { Nombre_completo = dr["Nombre_completo"].ToString()},
                                Numero_factura = dr["numeroDe_factura"].ToString(),
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = new Compra();
                }
            }
            return obj;
        }

        //consulta a nuestra base de datos para obtener el registro de un detalle de compra realizado

        public List<Detalle_compra> SeleccionarDetalleCompra(int idcompra)
        {
            List<Detalle_compra> Olista = new List<Detalle_compra>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT p.Nombre,");
                    query.AppendLine("dc.precioCompra,dc.cantidad,dc.monto_total");
                    query.AppendLine("FROM Detalle_Compra dc");
                    query.AppendLine("INNER JOIN producto p on p.id_producto = dc.id_producto");
                    query.AppendLine("where dc.id_compra = @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Olista.Add(new Detalle_compra()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                Precio_compra = Convert.ToDecimal(dr["precioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                Monto_total = Convert.ToDecimal(dr["monto_total"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Olista = new List<Detalle_compra>();
            }
            return Olista;
        }





    }
}
