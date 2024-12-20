﻿using CapaDatos;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class formEstadisticas : Form
    {
      
            private readonly Estadisticas estadisticas;

            public formEstadisticas()
            {
                InitializeComponent();
                estadisticas = new Estadisticas(); // Instancia de la clase Estadisticas
                CargarDatosEnChart();
                CargarDatosTotales();
            }

            private void CargarDatosEnChart()
            {
                // Limpiar cualquier serie existente en los gráficos
                chart2.Series.Clear();
                chart3.Series.Clear();

                // Configurar y cargar datos reales en chart2 (gráfico de torta para ventas por categoría)
                DataTable salesDataByCategory = estadisticas.CrearTorta();
                Series serieVentas = new Series("Categorías");
                serieVentas.ChartType = SeriesChartType.Pie;

                foreach (DataRow row in salesDataByCategory.Rows)
                {
                    string categoryName = row["CategoryName"].ToString();
                    int totalSales = Convert.ToInt32(row["TotalSales"]);
                    serieVentas.Points.AddXY(categoryName, totalSales);
                }

                chart2.Series.Add(serieVentas);
                chart2.Titles.Add("Productos más Vendidos por Categoría");




            DataTable topProductsData = estadisticas.ProductosMasVendidos();
            Series serieProductos = new Series("Producto");
            serieProductos.ChartType = SeriesChartType.Bar;

            foreach (DataRow row in topProductsData.Rows)
            {
                string productName = row["ProductName"].ToString();
                int totalSales = Convert.ToInt32(row["TotalSales"]);
                serieProductos.Points.AddXY(productName, totalSales);
            }

            chart3.Series.Add(serieProductos);
            chart3.Titles.Add("Productos Más Vendidos");


        }

        private void CargarDatosTotales()
        {
            txtTOTALVENTAS.Text = estadisticas.GetTotalVentas().ToString();
            txtCLIENTES.Text = estadisticas.GetCantidadClientes().ToString();
            txtEMPLEADOS.Text = estadisticas.GetCantidadEmpleados().ToString();
            txtCATEGORIAS.Text = estadisticas.GetCantidadCategorias().ToString();
            txtPRODUCTOS.Text = estadisticas.GetCantidadProductos().ToString();
            txtCAJA.Text = estadisticas.GetTotalCaja().ToString("C"); // Formato de moneda
        }

        private void formEstadisticas_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
        //    // Limpiar cualquier serie existente en el Chart
        //    chart1.Series.Clear();
        //    chart2.Series.Clear();
        //    chart3.Series.Clear();

        //    // Crear una nueva serie de datos
        //    Series serieVentas1 = new Series("Ventas1");
        //    serieVentas1.ChartType = SeriesChartType.Line;
        //    Series serieVentas = new Series("Ventas");
        //    serieVentas.ChartType = SeriesChartType.Pie; // Puedes usar diferentes tipos de gráficos, como Pie, Line, etc.
        //    Series serieProductos = new Series("Productos");
        //    serieProductos.ChartType = SeriesChartType.Bar;
        //    // Agregar datos ficticios
        //    serieVentas.Points.AddXY("Celulares", 30);
        //    serieVentas.Points.AddXY("Monitores", 10);
        //    serieVentas.Points.AddXY("Mouses", 15);
        //    serieVentas.Points.AddXY("Teclados", 8);
        //    serieVentas.Points.AddXY("Auriculares", 29);

        //    serieProductos.Points.AddXY("Celulares", 60);
        //    serieProductos.Points.AddXY("Monitores", 40);
        //    serieProductos.Points.AddXY("Mouses", 25);
        //    serieProductos.Points.AddXY("Teclados", 30);
        //    serieProductos.Points.AddXY("Auriculares", 50);

        //    serieVentas1.Points.AddXY("Celulares", 30);
        //    serieVentas1.Points.AddXY("Monitores", 10);
        //    serieVentas1.Points.AddXY("Mouses", 15);
        //    serieVentas1.Points.AddXY("Teclados", 18);
        //    serieVentas1.Points.AddXY("Auriculares", 29);

        //    // Agregar la serie al Chart
        //    chart1.Series.Add(serieVentas1);
        //    chart2.Series.Add(serieVentas);
        //    chart3.Series.Add(serieProductos);

        //    // Opcional: Configurar el título del chart
        //    chart1.Titles.Add("Ventas");
        //    chart2.Titles.Add("Ventas por Categoría");
        //    chart3.Titles.Add("Cantidad de productos por categoria");
        //
        }

    
    }
}
