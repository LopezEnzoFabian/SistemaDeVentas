using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Reporte
    {

        //REPORTE DE COMPRAS
        public List<Reporte_compra> Compra(string fechainicio, string fechafin, int idproveedor)
        {

            List<Reporte_compra> lista = new List<Reporte_compra>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_reporte_compra", oconexion);

                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.Parameters.AddWithValue("idproveedor", idproveedor);

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Reporte_compra()
                            {
                                Fecha_registro = dr["fecha_registro"].ToString(),
                                Tipo_factura = dr["tipoDe_factura"].ToString(),
                                Numero_factura = dr["numeroDe_factura"].ToString(),
                                Monto_total = dr["montoTotal"].ToString(),
                                Usuario_registro = dr["Nombre_completo"].ToString(),
                                Dni_proveedor = dr["DNI"].ToString(),
                                Razon_social = dr["Razon_social"].ToString(),
                                Codigo_producto = dr["codigo"].ToString(),
                                Nombre_producto = dr["Nombre"].ToString(),
                                Categoria = dr["descripcion"].ToString(),
                                Precio_compra = dr["precioCompra"].ToString(),
                                Precio_venta = dr["precioVenta"].ToString(),
                                Cantidad = dr["cantidad"].ToString(),
                                Subtotal = dr["monto_total"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Reporte_compra>();
                }
            }
            return lista;
        }

        //REPORTE DE VENTAS
        public List<Reporte_venta> Venta(string fechainicio, string fechafin)
        {

            List<Reporte_venta> lista = new List<Reporte_venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_reporte_venta", oconexion);

                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Reporte_venta()
                            {
                                Fecha_registro = dr["fecha_registro"].ToString(),
                                Tipo_factura = dr["tipoDe_factura"].ToString(),
                                Numero_factura = dr["numeroDe_factura"].ToString(),
                                Monto_total = dr["Monto_Total"].ToString(),
                                Usuario_registro = dr["Nombre_completo"].ToString(),
                                Dni_cliente= dr["DNI_cliente"].ToString(),
                                Nombre_cliente = dr["Nombre_cliente"].ToString(),
                                Codigo_producto = dr["codigo"].ToString(),
                                Nombre_producto = dr["Nombre"].ToString(),
                                Categoria = dr["descripcion"].ToString(),
                                Precio_venta = dr["precioVenta"].ToString(),
                                Cantidad = dr["cantidad"].ToString(),
                                Subtotal = dr["subTotal"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Reporte_venta>();
                }
            }
            return lista;
        }

    }
}
