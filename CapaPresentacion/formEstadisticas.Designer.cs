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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GBTotalVentas = new System.Windows.Forms.GroupBox();
            this.txtTOTALVENTAS = new System.Windows.Forms.TextBox();
            this.GBClientes = new System.Windows.Forms.GroupBox();
            this.txtCLIENTES = new System.Windows.Forms.TextBox();
            this.GBEmpleados = new System.Windows.Forms.GroupBox();
            this.txtEMPLEADOS = new System.Windows.Forms.TextBox();
            this.BGCaja = new System.Windows.Forms.GroupBox();
            this.txtCAJA = new System.Windows.Forms.TextBox();
            this.GBCategorias = new System.Windows.Forms.GroupBox();
            this.txtCATEGORIAS = new System.Windows.Forms.TextBox();
            this.GBProductos = new System.Windows.Forms.GroupBox();
            this.txtPRODUCTOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.GBTotalVentas.SuspendLayout();
            this.GBClientes.SuspendLayout();
            this.GBEmpleados.SuspendLayout();
            this.BGCaja.SuspendLayout();
            this.GBCategorias.SuspendLayout();
            this.GBProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(304, 299);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(345, 249);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1d";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(12, 299);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1d";
            series4.Name = "Series1";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(286, 249);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "Cantidad de productos por categoria";
            // 
            // GBTotalVentas
            // 
            this.GBTotalVentas.Controls.Add(this.txtTOTALVENTAS);
            this.GBTotalVentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTotalVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBTotalVentas.Location = new System.Drawing.Point(167, 76);
            this.GBTotalVentas.Name = "GBTotalVentas";
            this.GBTotalVentas.Size = new System.Drawing.Size(101, 90);
            this.GBTotalVentas.TabIndex = 3;
            this.GBTotalVentas.TabStop = false;
            this.GBTotalVentas.Text = "Total Ventas";
            // 
            // txtTOTALVENTAS
            // 
            this.txtTOTALVENTAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtTOTALVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTOTALVENTAS.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTOTALVENTAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTOTALVENTAS.Location = new System.Drawing.Point(6, 45);
            this.txtTOTALVENTAS.Multiline = true;
            this.txtTOTALVENTAS.Name = "txtTOTALVENTAS";
            this.txtTOTALVENTAS.ReadOnly = true;
            this.txtTOTALVENTAS.Size = new System.Drawing.Size(89, 21);
            this.txtTOTALVENTAS.TabIndex = 0;
            this.txtTOTALVENTAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GBClientes
            // 
            this.GBClientes.Controls.Add(this.txtCLIENTES);
            this.GBClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBClientes.Location = new System.Drawing.Point(274, 76);
            this.GBClientes.Name = "GBClientes";
            this.GBClientes.Size = new System.Drawing.Size(104, 90);
            this.GBClientes.TabIndex = 4;
            this.GBClientes.TabStop = false;
            this.GBClientes.Text = "Cantidad Clientes";
            // 
            // txtCLIENTES
            // 
            this.txtCLIENTES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCLIENTES.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCLIENTES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCLIENTES.Location = new System.Drawing.Point(9, 46);
            this.txtCLIENTES.Multiline = true;
            this.txtCLIENTES.Name = "txtCLIENTES";
            this.txtCLIENTES.ReadOnly = true;
            this.txtCLIENTES.Size = new System.Drawing.Size(89, 20);
            this.txtCLIENTES.TabIndex = 1;
            this.txtCLIENTES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GBEmpleados
            // 
            this.GBEmpleados.Controls.Add(this.txtEMPLEADOS);
            this.GBEmpleados.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBEmpleados.Location = new System.Drawing.Point(384, 76);
            this.GBEmpleados.Name = "GBEmpleados";
            this.GBEmpleados.Size = new System.Drawing.Size(104, 90);
            this.GBEmpleados.TabIndex = 5;
            this.GBEmpleados.TabStop = false;
            this.GBEmpleados.Text = "Cantidad Empleados";
            // 
            // txtEMPLEADOS
            // 
            this.txtEMPLEADOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtEMPLEADOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEMPLEADOS.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEMPLEADOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEMPLEADOS.Location = new System.Drawing.Point(6, 46);
            this.txtEMPLEADOS.Multiline = true;
            this.txtEMPLEADOS.Name = "txtEMPLEADOS";
            this.txtEMPLEADOS.ReadOnly = true;
            this.txtEMPLEADOS.Size = new System.Drawing.Size(89, 20);
            this.txtEMPLEADOS.TabIndex = 1;
            this.txtEMPLEADOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BGCaja
            // 
            this.BGCaja.Controls.Add(this.txtCAJA);
            this.BGCaja.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BGCaja.Location = new System.Drawing.Point(384, 189);
            this.BGCaja.Name = "BGCaja";
            this.BGCaja.Size = new System.Drawing.Size(104, 77);
            this.BGCaja.TabIndex = 9;
            this.BGCaja.TabStop = false;
            this.BGCaja.Text = "Caja";
            // 
            // txtCAJA
            // 
            this.txtCAJA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCAJA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtCAJA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCAJA.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCAJA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCAJA.Location = new System.Drawing.Point(8, 38);
            this.txtCAJA.Margin = new System.Windows.Forms.Padding(5);
            this.txtCAJA.Multiline = true;
            this.txtCAJA.Name = "txtCAJA";
            this.txtCAJA.ReadOnly = true;
            this.txtCAJA.Size = new System.Drawing.Size(89, 20);
            this.txtCAJA.TabIndex = 1;
            this.txtCAJA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GBCategorias
            // 
            this.GBCategorias.Controls.Add(this.txtCATEGORIAS);
            this.GBCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCategorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBCategorias.Location = new System.Drawing.Point(167, 189);
            this.GBCategorias.Name = "GBCategorias";
            this.GBCategorias.Size = new System.Drawing.Size(101, 77);
            this.GBCategorias.TabIndex = 7;
            this.GBCategorias.TabStop = false;
            this.GBCategorias.Text = "Cantidad Categorias";
            // 
            // txtCATEGORIAS
            // 
            this.txtCATEGORIAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtCATEGORIAS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCATEGORIAS.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCATEGORIAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCATEGORIAS.Location = new System.Drawing.Point(6, 38);
            this.txtCATEGORIAS.Multiline = true;
            this.txtCATEGORIAS.Name = "txtCATEGORIAS";
            this.txtCATEGORIAS.ReadOnly = true;
            this.txtCATEGORIAS.Size = new System.Drawing.Size(89, 20);
            this.txtCATEGORIAS.TabIndex = 1;
            this.txtCATEGORIAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GBProductos
            // 
            this.GBProductos.Controls.Add(this.txtPRODUCTOS);
            this.GBProductos.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBProductos.Location = new System.Drawing.Point(274, 189);
            this.GBProductos.Name = "GBProductos";
            this.GBProductos.Size = new System.Drawing.Size(104, 77);
            this.GBProductos.TabIndex = 8;
            this.GBProductos.TabStop = false;
            this.GBProductos.Text = "Cantidad Productos";
            // 
            // txtPRODUCTOS
            // 
            this.txtPRODUCTOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtPRODUCTOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPRODUCTOS.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPRODUCTOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPRODUCTOS.Location = new System.Drawing.Point(6, 38);
            this.txtPRODUCTOS.Multiline = true;
            this.txtPRODUCTOS.Name = "txtPRODUCTOS";
            this.txtPRODUCTOS.ReadOnly = true;
            this.txtPRODUCTOS.Size = new System.Drawing.Size(91, 20);
            this.txtPRODUCTOS.TabIndex = 1;
            this.txtPRODUCTOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estadisticas generales.";
            // 
            // formEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGCaja);
            this.Controls.Add(this.GBProductos);
            this.Controls.Add(this.GBCategorias);
            this.Controls.Add(this.GBEmpleados);
            this.Controls.Add(this.GBClientes);
            this.Controls.Add(this.GBTotalVentas);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEstadisticas";
            this.Text = "formEstadisticas";
            this.Load += new System.EventHandler(this.formEstadisticas_Load);
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
            this.GBCategorias.ResumeLayout(false);
            this.GBCategorias.PerformLayout();
            this.GBProductos.ResumeLayout(false);
            this.GBProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox GBTotalVentas;
        private System.Windows.Forms.GroupBox GBClientes;
        private System.Windows.Forms.GroupBox GBEmpleados;
        private System.Windows.Forms.GroupBox BGCaja;
        private System.Windows.Forms.GroupBox GBCategorias;
        private System.Windows.Forms.TextBox txtTOTALVENTAS;
        private System.Windows.Forms.TextBox txtCLIENTES;
        private System.Windows.Forms.TextBox txtEMPLEADOS;
        private System.Windows.Forms.TextBox txtCAJA;
        private System.Windows.Forms.TextBox txtCATEGORIAS;
        private System.Windows.Forms.GroupBox GBProductos;
        private System.Windows.Forms.TextBox txtPRODUCTOS;
        private System.Windows.Forms.Label label1;
    }
}