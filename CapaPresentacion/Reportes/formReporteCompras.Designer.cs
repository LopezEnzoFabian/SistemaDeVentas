namespace CapaPresentacion.Reportes
{
    partial class formReporteCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRepoCompras = new System.Windows.Forms.Label();
            this.dgReporteCompras = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechainicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechafin = new System.Windows.Forms.DateTimePicker();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.ibtnDescargaExcel = new FontAwesome.Sharp.IconButton();
            this.lblRV = new System.Windows.Forms.Label();
            this.ibtnBuscarPor = new FontAwesome.Sharp.IconButton();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnBuscaFecha = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.colFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNIProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRepoCompras
            // 
            this.lblRepoCompras.AutoSize = true;
            this.lblRepoCompras.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepoCompras.ForeColor = System.Drawing.Color.Black;
            this.lblRepoCompras.Location = new System.Drawing.Point(257, 9);
            this.lblRepoCompras.Name = "lblRepoCompras";
            this.lblRepoCompras.Size = new System.Drawing.Size(223, 24);
            this.lblRepoCompras.TabIndex = 0;
            this.lblRepoCompras.Text = "Reporte de Compras";
            // 
            // dgReporteCompras
            // 
            this.dgReporteCompras.AllowUserToAddRows = false;
            this.dgReporteCompras.AllowUserToDeleteRows = false;
            this.dgReporteCompras.AllowUserToResizeColumns = false;
            this.dgReporteCompras.AllowUserToResizeRows = false;
            this.dgReporteCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgReporteCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReporteCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgReporteCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaRegistro,
            this.colTipoDFactura,
            this.colNumeroFactura,
            this.colMontoTotal,
            this.colUsuarioRegistro,
            this.colDNIProveedor,
            this.colRazonSocial,
            this.colCodigoProducto,
            this.colNombreProducto,
            this.colCategoria,
            this.colPrecioCompra,
            this.colPrecioVenta,
            this.colCantidad,
            this.colSubTotal});
            this.dgReporteCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgReporteCompras.Location = new System.Drawing.Point(0, 219);
            this.dgReporteCompras.Name = "dgReporteCompras";
            this.dgReporteCompras.ReadOnly = true;
            this.dgReporteCompras.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgReporteCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgReporteCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReporteCompras.Size = new System.Drawing.Size(658, 309);
            this.dgReporteCompras.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(179, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de inicio :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(217, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha fin :";
            // 
            // dtFechainicio
            // 
            this.dtFechainicio.CustomFormat = "dd/MM/yyyy";
            this.dtFechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechainicio.Location = new System.Drawing.Point(301, 65);
            this.dtFechainicio.Name = "dtFechainicio";
            this.dtFechainicio.Size = new System.Drawing.Size(100, 20);
            this.dtFechainicio.TabIndex = 4;
            // 
            // dtFechafin
            // 
            this.dtFechafin.CustomFormat = "dd/MM/yyyy";
            this.dtFechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechafin.Location = new System.Drawing.Point(301, 91);
            this.dtFechafin.Name = "dtFechafin";
            this.dtFechafin.Size = new System.Drawing.Size(100, 20);
            this.dtFechafin.TabIndex = 5;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProveedor.ForeColor = System.Drawing.Color.Black;
            this.lblProveedor.Location = new System.Drawing.Point(209, 123);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(86, 15);
            this.lblProveedor.TabIndex = 47;
            this.lblProveedor.Text = "Proveedor :";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(301, 117);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(100, 21);
            this.cbProveedor.TabIndex = 48;
            // 
            // ibtnDescargaExcel
            // 
            this.ibtnDescargaExcel.AutoSize = true;
            this.ibtnDescargaExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnDescargaExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnDescargaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnDescargaExcel.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtnDescargaExcel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDescargaExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnDescargaExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnDescargaExcel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibtnDescargaExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDescargaExcel.IconSize = 20;
            this.ibtnDescargaExcel.Location = new System.Drawing.Point(567, 186);
            this.ibtnDescargaExcel.Name = "ibtnDescargaExcel";
            this.ibtnDescargaExcel.Size = new System.Drawing.Size(82, 27);
            this.ibtnDescargaExcel.TabIndex = 67;
            this.ibtnDescargaExcel.Text = "Excel";
            this.ibtnDescargaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDescargaExcel.UseVisualStyleBackColor = false;
            this.ibtnDescargaExcel.Click += new System.EventHandler(this.ibtnDescargaExcel_Click);
            // 
            // lblRV
            // 
            this.lblRV.AutoSize = true;
            this.lblRV.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRV.ForeColor = System.Drawing.Color.Black;
            this.lblRV.Location = new System.Drawing.Point(9, 176);
            this.lblRV.Name = "lblRV";
            this.lblRV.Size = new System.Drawing.Size(90, 15);
            this.lblRV.TabIndex = 71;
            this.lblRV.Text = "Buscar por :";
            // 
            // ibtnBuscarPor
            // 
            this.ibtnBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnBuscarPor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarPor.IconColor = System.Drawing.Color.Cyan;
            this.ibtnBuscarPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarPor.IconSize = 20;
            this.ibtnBuscarPor.Location = new System.Drawing.Point(290, 186);
            this.ibtnBuscarPor.Name = "ibtnBuscarPor";
            this.ibtnBuscarPor.Size = new System.Drawing.Size(71, 27);
            this.ibtnBuscarPor.TabIndex = 70;
            this.ibtnBuscarPor.Text = "Buscar";
            this.ibtnBuscarPor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBuscarPor.UseVisualStyleBackColor = false;
            this.ibtnBuscarPor.Click += new System.EventHandler(this.ibtnBuscarPor_Click);
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(152, 193);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(124, 20);
            this.txtBuscarPor.TabIndex = 69;
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Location = new System.Drawing.Point(12, 192);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(134, 21);
            this.cbBuscarPor.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Buscar una compra realizada por intervalos de fechas.";
            // 
            // ibtnBuscaFecha
            // 
            this.ibtnBuscaFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscaFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnBuscaFecha.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscaFecha.IconColor = System.Drawing.Color.Cyan;
            this.ibtnBuscaFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscaFecha.IconSize = 20;
            this.ibtnBuscaFecha.Location = new System.Drawing.Point(301, 144);
            this.ibtnBuscaFecha.Name = "ibtnBuscaFecha";
            this.ibtnBuscaFecha.Size = new System.Drawing.Size(100, 27);
            this.ibtnBuscaFecha.TabIndex = 73;
            this.ibtnBuscaFecha.Text = "Buscar";
            this.ibtnBuscaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnBuscaFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBuscaFecha.UseVisualStyleBackColor = false;
            this.ibtnBuscaFecha.Click += new System.EventHandler(this.ibtnBuscaFecha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "Generar archivo";
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FillWeight = 150F;
            this.colFechaRegistro.HeaderText = "Fecha de registro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.ReadOnly = true;
            this.colFechaRegistro.Width = 150;
            // 
            // colTipoDFactura
            // 
            this.colTipoDFactura.FillWeight = 150F;
            this.colTipoDFactura.HeaderText = "TIpo de factura";
            this.colTipoDFactura.Name = "colTipoDFactura";
            this.colTipoDFactura.ReadOnly = true;
            this.colTipoDFactura.Width = 150;
            // 
            // colNumeroFactura
            // 
            this.colNumeroFactura.FillWeight = 150F;
            this.colNumeroFactura.HeaderText = "Numero de factura";
            this.colNumeroFactura.Name = "colNumeroFactura";
            this.colNumeroFactura.ReadOnly = true;
            this.colNumeroFactura.Width = 150;
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.HeaderText = "Monto Total";
            this.colMontoTotal.Name = "colMontoTotal";
            this.colMontoTotal.ReadOnly = true;
            // 
            // colUsuarioRegistro
            // 
            this.colUsuarioRegistro.FillWeight = 150F;
            this.colUsuarioRegistro.HeaderText = "Usuario Registro";
            this.colUsuarioRegistro.Name = "colUsuarioRegistro";
            this.colUsuarioRegistro.ReadOnly = true;
            this.colUsuarioRegistro.Width = 150;
            // 
            // colDNIProveedor
            // 
            this.colDNIProveedor.FillWeight = 150F;
            this.colDNIProveedor.HeaderText = "DNI del proveedor";
            this.colDNIProveedor.Name = "colDNIProveedor";
            this.colDNIProveedor.ReadOnly = true;
            this.colDNIProveedor.Width = 150;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.HeaderText = "Razon Social";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.ReadOnly = true;
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.FillWeight = 150F;
            this.colCodigoProducto.HeaderText = "Codigo de producto";
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.ReadOnly = true;
            this.colCodigoProducto.Width = 150;
            // 
            // colNombreProducto
            // 
            this.colNombreProducto.FillWeight = 150F;
            this.colNombreProducto.HeaderText = "Nombre de producto";
            this.colNombreProducto.Name = "colNombreProducto";
            this.colNombreProducto.ReadOnly = true;
            this.colNombreProducto.Width = 150;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.FillWeight = 150F;
            this.colPrecioCompra.HeaderText = "Precio compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            this.colPrecioCompra.Width = 150;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.HeaderText = "Precio venta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // formReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(661, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ibtnBuscaFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRV);
            this.Controls.Add(this.ibtnBuscarPor);
            this.Controls.Add(this.txtBuscarPor);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.ibtnDescargaExcel);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.dtFechafin);
            this.Controls.Add(this.dtFechainicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReporteCompras);
            this.Controls.Add(this.lblRepoCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formReporteCompra";
            this.Text = "Reporte de Compras";
            this.Load += new System.EventHandler(this.formReporteCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepoCompras;
        private System.Windows.Forms.DataGridView dgReporteCompras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechainicio;
        private System.Windows.Forms.DateTimePicker dtFechafin;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbProveedor;
        private FontAwesome.Sharp.IconButton ibtnDescargaExcel;
        private System.Windows.Forms.Label lblRV;
        private FontAwesome.Sharp.IconButton ibtnBuscarPor;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtnBuscaFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNIProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}