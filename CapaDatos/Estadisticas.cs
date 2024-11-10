using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Estadisticas
    {

        public DataTable CrearTorta()
        {
            DataTable dataTable = new DataTable();
            string query = @"
        SELECT 
            c.descripcion AS CategoryName,
            SUM(dv.cantidad) AS TotalSales
        FROM 
            Detalle_Venta dv
        JOIN 
            producto p ON dv.id_producto = p.id_producto
        JOIN 
            categoria c ON p.id_categoria = c.id_categoria
        GROUP BY 
            c.descripcion
        ORDER BY 
            TotalSales DESC";

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }


        public int GetTotalVentas()
        {
            int totalVentas = 0;
            string query = "SELECT COUNT(*) FROM Venta";
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                totalVentas = (int)cmd.ExecuteScalar();
            }
            return totalVentas;
        }

        public int GetCantidadClientes()
        {
            int cantidadClientes = 0;
            string query = "SELECT COUNT(*) FROM Cliente";
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cantidadClientes = (int)cmd.ExecuteScalar();
            }
            return cantidadClientes;
        }

        public int GetCantidadEmpleados()
        {
            int cantidadEmpleados = 0;
            string query = "SELECT COUNT(*) FROM Usuario";
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cantidadEmpleados = (int)cmd.ExecuteScalar();
            }
            return cantidadEmpleados;
        }

        public int GetCantidadCategorias()
        {
            int cantidadCategorias = 0;
            string query = "SELECT COUNT(*) FROM categoria";
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cantidadCategorias = (int)cmd.ExecuteScalar();
            }
            return cantidadCategorias;
        }

        public int GetCantidadProductos()
        {
            int cantidadProductos = 0;
            string query = "SELECT COUNT(*) FROM producto";
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cantidadProductos = (int)cmd.ExecuteScalar();
            }
            return cantidadProductos;
        }

        public decimal GetTotalCaja()
        {
            decimal totalCaja = 0;
            string query = "SELECT SUM(Monto_Total) FROM Venta";
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    totalCaja = (decimal)result;
            }
            return totalCaja;
        }


        public DataTable ProductosMasVendidos()
        {
            DataTable dataTable = new DataTable();
            string query = @"
        SELECT TOP 10 
            p.Nombre AS ProductName,
            SUM(dv.cantidad) AS TotalSales
        FROM 
            Detalle_Venta dv
        JOIN 
            producto p ON dv.id_producto = p.id_producto
        GROUP BY 
            p.Nombre
        ORDER BY 
            TotalSales DESC";

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

    }

}

