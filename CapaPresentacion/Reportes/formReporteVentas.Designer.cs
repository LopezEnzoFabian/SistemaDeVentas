namespace CapaPresentacion.Reportes
{
    partial class formReporteVentas
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
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dgReporteVentas = new System.Windows.Forms.DataGridView();
            this.lblReporteVentas = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.lblRV2 = new System.Windows.Forms.Label();
            this.lblRV = new System.Windows.Forms.Label();
            this.ibtnDescargaExcel = new FontAwesome.Sharp.IconButton();
            this.ibtnBuscaFecha = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.colFechaDeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNIlciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(297, 100);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(109, 20);
            this.dtFechaFin.TabIndex = 55;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(297, 74);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(109, 20);
            this.dtFechaInicio.TabIndex = 54;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFin.Location = new System.Drawing.Point(219, 105);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(78, 15);
            this.lblFechaFin.TabIndex = 53;
            this.lblFechaFin.Text = "Fecha fin :";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(180, 79);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(117, 15);
            this.lblFechaInicio.TabIndex = 52;
            this.lblFechaInicio.Text = "Fecha de inicio :";
            // 
            // dgReporteVentas
            // 
            this.dgReporteVentas.AllowUserToAddRows = false;
            this.dgReporteVentas.AllowUserToDeleteRows = false;
            this.dgReporteVentas.AllowUserToResizeColumns = false;
            this.dgReporteVentas.AllowUserToResizeRows = false;
            this.dgReporteVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgReporteVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgReporteVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaDeRegistro,
            this.colTipoDocumento,
            this.colNumeroDocumento,
            this.colMontoTotal,
            this.colUsuarioRegistro,
            this.colDNIlciente,
            this.colNombreCliente,
            this.colCodProd,
            this.colNomProducto,
            this.colCate,
            this.colPrecioCom,
            this.colCantidad,
            this.colSubTotal});
            this.dgReporteVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgReporteVentas.Location = new System.Drawing.Point(-1, 219);
            this.dgReporteVentas.Name = "dgReporteVentas";
            this.dgReporteVentas.ReadOnly = true;
            this.dgReporteVentas.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgReporteVentas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReporteVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgReporteVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgReporteVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReporteVentas.Size = new System.Drawing.Size(661, 307);
            this.dgReporteVentas.TabIndex = 51;
            // 
            // lblReporteVentas
            // 
            this.lblReporteVentas.AutoSize = true;
            this.lblReporteVentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteVentas.ForeColor = System.Drawing.Color.Black;
            this.lblReporteVentas.Location = new System.Drawing.Point(255, 9);
            this.lblReporteVentas.Name = "lblReporteVentas";
            this.lblReporteVentas.Size = new System.Drawing.Size(202, 24);
            this.lblReporteVentas.TabIndex = 50;
            this.lblReporteVentas.Text = "Reporte de Ventas";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.ForeColor = System.Drawing.Color.Cyan;
            this.lblBuscarPor.Location = new System.Drawing.Point(12, 151);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(0, 13);
            this.lblBuscarPor.TabIndex = 60;
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Items.AddRange(new object[] {
            "Fecha de registro",
            "Tipo de documento",
            "Numero de factura"});
            this.cbBuscarPor.Location = new System.Drawing.Point(12, 190);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(132, 21);
            this.cbBuscarPor.TabIndex = 61;
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(153, 191);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(124, 20);
            this.txtBuscarPor.TabIndex = 62;
            // 
            // lblRV2
            // 
            this.lblRV2.AutoSize = true;
            this.lblRV2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRV2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRV2.Location = new System.Drawing.Point(139, 43);
            this.lblRV2.Name = "lblRV2";
            this.lblRV2.Size = new System.Drawing.Size(295, 15);
            this.lblRV2.TabIndex = 64;
            this.lblRV2.Text = "Buscar una venta por intervalos de fechas.";
            // 
            // lblRV
            // 
            this.lblRV.AutoSize = true;
            this.lblRV.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRV.ForeColor = System.Drawing.Color.Black;
            this.lblRV.Location = new System.Drawing.Point(12, 172);
            this.lblRV.Name = "lblRV";
            this.lblRV.Size = new System.Drawing.Size(90, 15);
            this.lblRV.TabIndex = 65;
            this.lblRV.Text = "Buscar por :";
            // 
            // ibtnDescargaExcel
            // 
            this.ibtnDescargaExcel.AutoSize = true;
            this.ibtnDescargaExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnDescargaExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnDescargaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnDescargaExcel.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtnDescargaExcel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ibtnDescargaExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnDescargaExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnDescargaExcel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibtnDescargaExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDescargaExcel.IconSize = 20;
            this.ibtnDescargaExcel.Location = new System.Drawing.Point(567, 186);
            this.ibtnDescargaExcel.Name = "ibtnDescargaExcel";
            this.ibtnDescargaExcel.Size = new System.Drawing.Size(82, 27);
            this.ibtnDescargaExcel.TabIndex = 66;
            this.ibtnDescargaExcel.Text = "Excel";
            this.ibtnDescargaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDescargaExcel.UseVisualStyleBackColor = false;
            this.ibtnDescargaExcel.Click += new System.EventHandler(this.ibtnDescargaExcel_Click);
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
            this.ibtnBuscaFecha.Location = new System.Drawing.Point(297, 126);
            this.ibtnBuscaFecha.Name = "ibtnBuscaFecha";
            this.ibtnBuscaFecha.Size = new System.Drawing.Size(109, 27);
            this.ibtnBuscaFecha.TabIndex = 74;
            this.ibtnBuscaFecha.Text = "Buscar";
            this.ibtnBuscaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnBuscaFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBuscaFecha.UseVisualStyleBackColor = false;
            this.ibtnBuscaFecha.Click += new System.EventHandler(this.ibtnBuscaFecha_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton1.IconColor = System.Drawing.Color.Cyan;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(290, 186);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(71, 27);
            this.iconButton1.TabIndex = 75;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Generar archivo";
            // 
            // colFechaDeRegistro
            // 
            this.colFechaDeRegistro.FillWeight = 120F;
            this.colFechaDeRegistro.HeaderText = "Fecha de registro";
            this.colFechaDeRegistro.Name = "colFechaDeRegistro";
            this.colFechaDeRegistro.ReadOnly = true;
            this.colFechaDeRegistro.Width = 120;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.FillWeight = 150F;
            this.colTipoDocumento.HeaderText = "TIpo de factura";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.ReadOnly = true;
            this.colTipoDocumento.Width = 150;
            // 
            // colNumeroDocumento
            // 
            this.colNumeroDocumento.FillWeight = 150F;
            this.colNumeroDocumento.HeaderText = "Numero de factura";
            this.colNumeroDocumento.Name = "colNumeroDocumento";
            this.colNumeroDocumento.ReadOnly = true;
            this.colNumeroDocumento.Width = 150;
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
            // colDNIlciente
            // 
            this.colDNIlciente.HeaderText = "Dni cliente";
            this.colDNIlciente.Name = "colDNIlciente";
            this.colDNIlciente.ReadOnly = true;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FillWeight = 150F;
            this.colNombreCliente.HeaderText = "Nombre del cliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.ReadOnly = true;
            this.colNombreCliente.Width = 150;
            // 
            // colCodProd
            // 
            this.colCodProd.FillWeight = 150F;
            this.colCodProd.HeaderText = "Codigo de producto";
            this.colCodProd.Name = "colCodProd";
            this.colCodProd.ReadOnly = true;
            this.colCodProd.Width = 150;
            // 
            // colNomProducto
            // 
            this.colNomProducto.FillWeight = 150F;
            this.colNomProducto.HeaderText = "Nombre de producto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.ReadOnly = true;
            this.colNomProducto.Width = 150;
            // 
            // colCate
            // 
            this.colCate.HeaderText = "Categoria";
            this.colCate.Name = "colCate";
            this.colCate.ReadOnly = true;
            // 
            // colPrecioCom
            // 
            this.colPrecioCom.HeaderText = "Precio venta";
            this.colPrecioCom.Name = "colPrecioCom";
            this.colPrecioCom.ReadOnly = true;
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
            // formReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(661, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ibtnBuscaFecha);
            this.Controls.Add(this.ibtnDescargaExcel);
            this.Controls.Add(this.lblRV);
            this.Controls.Add(this.lblRV2);
            this.Controls.Add(this.txtBuscarPor);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dgReporteVentas);
            this.Controls.Add(this.lblReporteVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.formReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DataGridView dgReporteVentas;
        private System.Windows.Forms.Label lblReporteVentas;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label lblRV2;
        private System.Windows.Forms.Label lblRV;
        private FontAwesome.Sharp.IconButton ibtnDescargaExcel;
        private FontAwesome.Sharp.IconButton ibtnBuscaFecha;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNIlciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}