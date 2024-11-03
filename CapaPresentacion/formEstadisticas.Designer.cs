namespace CapaPresentacion
{
    partial class formEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GBTotalVentas = new System.Windows.Forms.GroupBox();
            this.LBVentas = new System.Windows.Forms.Label();
            this.GBClientes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GBEmpleados = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BGCaja = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GBProductos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GBCategorias = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.GBTotalVentas.SuspendLayout();
            this.GBClientes.SuspendLayout();
            this.GBEmpleados.SuspendLayout();
            this.BGCaja.SuspendLayout();
            this.GBProductos.SuspendLayout();
            this.GBCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 50);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(286, 213);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(304, 264);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(345, 226);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1d";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(12, 276);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Legend = "Legend1d";
            series6.Name = "Series1";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(286, 226);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "Cantidad de productos por categoria";
            // 
            // GBTotalVentas
            // 
            this.GBTotalVentas.Controls.Add(this.LBVentas);
            this.GBTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTotalVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBTotalVentas.Location = new System.Drawing.Point(313, 50);
            this.GBTotalVentas.Name = "GBTotalVentas";
            this.GBTotalVentas.Size = new System.Drawing.Size(101, 90);
            this.GBTotalVentas.TabIndex = 3;
            this.GBTotalVentas.TabStop = false;
            this.GBTotalVentas.Text = "Total Ventas";
            // 
            // LBVentas
            // 
            this.LBVentas.AutoSize = true;
            this.LBVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBVentas.Location = new System.Drawing.Point(24, 35);
            this.LBVentas.Name = "LBVentas";
            this.LBVentas.Size = new System.Drawing.Size(49, 20);
            this.LBVentas.TabIndex = 0;
            this.LBVentas.Text = "2348";
            // 
            // GBClientes
            // 
            this.GBClientes.Controls.Add(this.label3);
            this.GBClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBClientes.Location = new System.Drawing.Point(420, 50);
            this.GBClientes.Name = "GBClientes";
            this.GBClientes.Size = new System.Drawing.Size(104, 90);
            this.GBClientes.TabIndex = 4;
            this.GBClientes.TabStop = false;
            this.GBClientes.Text = "Cantidad Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "300";
            // 
            // GBEmpleados
            // 
            this.GBEmpleados.Controls.Add(this.label4);
            this.GBEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBEmpleados.Location = new System.Drawing.Point(530, 50);
            this.GBEmpleados.Name = "GBEmpleados";
            this.GBEmpleados.Size = new System.Drawing.Size(104, 90);
            this.GBEmpleados.TabIndex = 5;
            this.GBEmpleados.TabStop = false;
            this.GBEmpleados.Text = "Cantidad Empleados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "10";
            // 
            // BGCaja
            // 
            this.BGCaja.Controls.Add(this.label7);
            this.BGCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BGCaja.Location = new System.Drawing.Point(530, 163);
            this.BGCaja.Name = "BGCaja";
            this.BGCaja.Size = new System.Drawing.Size(104, 77);
            this.BGCaja.TabIndex = 9;
            this.BGCaja.TabStop = false;
            this.BGCaja.Text = "Caja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "$ 8.900.200";
            // 
            // GBProductos
            // 
            this.GBProductos.Controls.Add(this.label6);
            this.GBProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBProductos.Location = new System.Drawing.Point(420, 163);
            this.GBProductos.Name = "GBProductos";
            this.GBProductos.Size = new System.Drawing.Size(104, 77);
            this.GBProductos.TabIndex = 8;
            this.GBProductos.TabStop = false;
            this.GBProductos.Text = "Cantidad Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "80";
            // 
            // GBCategorias
            // 
            this.GBCategorias.Controls.Add(this.label5);
            this.GBCategorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBCategorias.Location = new System.Drawing.Point(313, 163);
            this.GBCategorias.Name = "GBCategorias";
            this.GBCategorias.Size = new System.Drawing.Size(101, 77);
            this.GBCategorias.TabIndex = 7;
            this.GBCategorias.TabStop = false;
            this.GBCategorias.Text = "Cantidad Categorias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "5";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(592, 496);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(57, 58);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Excel";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estadisticas generales.";
            // 
            // formEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BGCaja);
            this.Controls.Add(this.GBProductos);
            this.Controls.Add(this.GBCategorias);
            this.Controls.Add(this.GBEmpleados);
            this.Controls.Add(this.GBClientes);
            this.Controls.Add(this.GBTotalVentas);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEstadisticas";
            this.Text = "formEstadisticas";
            this.Load += new System.EventHandler(this.formEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.GBTotalVentas.ResumeLayout(false);
            this.GBTotalVentas.PerformLayout();
            this.GBClientes.ResumeLayout(false);
            this.GBClientes.PerformLayout();
            this.GBEmpleados.ResumeLayout(false);
            this.GBEmpleados.PerformLayout();
            this.BGCaja.ResumeLayout(false);
            this.BGCaja.PerformLayout();
            this.GBProductos.ResumeLayout(false);
            this.GBProductos.PerformLayout();
            this.GBCategorias.ResumeLayout(false);
            this.GBCategorias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox GBTotalVentas;
        private System.Windows.Forms.GroupBox GBClientes;
        private System.Windows.Forms.GroupBox GBEmpleados;
        private System.Windows.Forms.GroupBox BGCaja;
        private System.Windows.Forms.GroupBox GBProductos;
        private System.Windows.Forms.GroupBox GBCategorias;
        private System.Windows.Forms.Label LBVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
    }
}