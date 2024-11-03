using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace CapaDatos
{
    public class CD_venta
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) +1 from Venta");
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

        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @Cantidad where id_producto = @Idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;//nos devuelve un conteo de filas afectadas
                }
                catch (Exception ex) { 
                 respuesta=false;
                }
            }
            return respuesta;
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock + @Cantidad where id_producto = @Idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;//nos devuelve un conteo de filas afectadas
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }


        //REGISTRAR VENTA
        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_registrar_venta", oconexion);
                    cmd.Parameters.AddWithValue("Tipofactura", obj.Tipo_factura);
                    cmd.Parameters.AddWithValue("DNIcliente", obj.DNI_cliente);
                    cmd.Parameters.AddWithValue("NombreCliente", obj.Nombre_cliente);
                    cmd.Parameters.AddWithValue("MontoPago", obj.Monto_pago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.Monto_cambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.Monto_total);
                    cmd.Parameters.AddWithValue("Idusuario", obj.oUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("Numerofactura", obj.Numero_factura);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString(); //error que pueda tener nuestro sp
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        //consulta a nuestra base de datos para obtener un registro de una venta
        public Venta SeleccionarVenta(string numero)
        {
            Venta obj = new Venta();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select V.id_venta,u.Nombre_completo,v.Nombre_cliente,v.DNI_cliente,v.tipoDe_factura,v.numeroDe_factura,");
                    query.AppendLine("v.Monto_pago,v.Monto_cambio,v.Monto_Total,CONVERT(char(10),v.fecha_registro,103)[fecha_registro]");
                    query.AppendLine("from Venta v");
                    query.AppendLine("INNER JOIN Usuario u ON u.id_usuario = v.id_usuario");
                    query.AppendLine("where v.numeroDe_factura = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Venta()
                            {
                                Id_venta = Convert.ToInt32(dr["id_venta"]),
                                Tipo_factura = dr["tipoDe_factura"].ToString(),
                                DNI_cliente = dr["DNI_cliente"].ToString(),
                                Nombre_cliente = dr["Nombre_cliente"].ToString(),
                                Monto_pago = Convert.ToDecimal(dr["Monto_pago"].ToString()),
                                Monto_cambio = Convert.ToDecimal(dr["Monto_cambio"].ToString()),
                                Monto_total = Convert.ToDecimal(dr["Monto_Total"].ToString()),
                                Fecha_registro = dr["fecha_registro"].ToString(),
                                oUsuario = new Usuario() { Nombre_completo = dr["Nombre_completo"].ToString() },
                                Numero_factura = dr["numeroDe_factura"].ToString(),
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = new Venta();
                }
            }
            return obj;
        }


        //consulta a nuestra base de datos para obtener el registro de un detalle de venta realizado

        public List<Detalle_venta> SeleccionarDetalleVenta(int idventa)
        {
            List<Detalle_venta> Olista = new List<Detalle_venta>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.Nombre,dv.precioVenta,dv.cantidad,dv.subTotal");
                    query.AppendLine("FROM Detalle_Venta dv");
                    query.AppendLine("inner join producto p ON p.id_producto = dv.id_producto");
                    query.AppendLine("WHERE dv.id_venta = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Olista.Add(new Detalle_venta()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                Precio_venta = Convert.ToDecimal(dr["precioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                Sub_total = Convert.ToDecimal(dr["subTotal"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Olista = new List<Detalle_venta>();
            }
            return Olista;
        }
    }
}
