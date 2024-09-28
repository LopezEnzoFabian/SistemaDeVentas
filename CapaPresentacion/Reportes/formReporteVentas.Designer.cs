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
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dgReporteVentas = new System.Windows.Forms.DataGridView();
            this.colFechaDeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReporteVentas = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.ibtnBuscarPor = new FontAwesome.Sharp.IconButton();
            this.lblRV2 = new System.Windows.Forms.Label();
            this.lblRV = new System.Windows.Forms.Label();
            this.ibtnDescargaExcel = new FontAwesome.Sharp.IconButton();
            this.icbtnBuscarFecha = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(90, 81);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(229, 20);
            this.dtFechaFin.TabIndex = 55;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(90, 55);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(229, 20);
            this.dtFechaInicio.TabIndex = 54;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.ForeColor = System.Drawing.Color.Cyan;
            this.lblFechaFin.Location = new System.Drawing.Point(12, 88);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(51, 13);
            this.lblFechaFin.TabIndex = 53;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Cyan;
            this.lblFechaInicio.Location = new System.Drawing.Point(9, 61);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(79, 13);
            this.lblFechaInicio.TabIndex = 52;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // dgReporteVentas
            // 
            this.dgReporteVentas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaDeRegistro,
            this.colTipoDocumento,
            this.colNumeroDocumento,
            this.colMontoTotal,
            this.colUsuarioRegistro,
            this.colDocumentoProveedor,
            this.colRazonSocial,
            this.colCodProd,
            this.colNombreCliente,
            this.colNomPro,
            this.colCate,
            this.colPrecioCom});
            this.dgReporteVentas.Location = new System.Drawing.Point(-1, 194);
            this.dgReporteVentas.Name = "dgReporteVentas";
            this.dgReporteVentas.Size = new System.Drawing.Size(651, 253);
            this.dgReporteVentas.TabIndex = 51;
            // 
            // colFechaDeRegistro
            // 
            this.colFechaDeRegistro.HeaderText = "Fecha de registro";
            this.colFechaDeRegistro.Name = "colFechaDeRegistro";
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.HeaderText = "TIpo documento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            // 
            // colNumeroDocumento
            // 
            this.colNumeroDocumento.HeaderText = "Numero de factura";
            this.colNumeroDocumento.Name = "colNumeroDocumento";
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.HeaderText = "Monto Total";
            this.colMontoTotal.Name = "colMontoTotal";
            // 
            // colUsuarioRegistro
            // 
            this.colUsuarioRegistro.HeaderText = "Usuario Registro";
            this.colUsuarioRegistro.Name = "colUsuarioRegistro";
            // 
            // colDocumentoProveedor
            // 
            this.colDocumentoProveedor.HeaderText = "Documento del proveedor";
            this.colDocumentoProveedor.Name = "colDocumentoProveedor";
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.HeaderText = "Razon Social";
            this.colRazonSocial.Name = "colRazonSocial";
            // 
            // colCodProd
            // 
            this.colCodProd.HeaderText = "Codigo de producto";
            this.colCodProd.Name = "colCodProd";
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.HeaderText = "Nombre del cliente";
            this.colNombreCliente.Name = "colNombreCliente";
            // 
            // colNomPro
            // 
            this.colNomPro.HeaderText = "Nombre de producto";
            this.colNomPro.Name = "colNomPro";
            // 
            // colCate
            // 
            this.colCate.HeaderText = "Categoria";
            this.colCate.Name = "colCate";
            // 
            // colPrecioCom
            // 
            this.colPrecioCom.HeaderText = "Precio compra";
            this.colPrecioCom.Name = "colPrecioCom";
            // 
            // lblReporteVentas
            // 
            this.lblReporteVentas.AutoSize = true;
            this.lblReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteVentas.ForeColor = System.Drawing.Color.Cyan;
            this.lblReporteVentas.Location = new System.Drawing.Point(255, 9);
            this.lblReporteVentas.Name = "lblReporteVentas";
            this.lblReporteVentas.Size = new System.Drawing.Size(167, 24);
            this.lblReporteVentas.TabIndex = 50;
            this.lblReporteVentas.Text = "Reporte de Ventas";
            this.lblReporteVentas.Click += new System.EventHandler(this.lblRepoCompras_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.ForeColor = System.Drawing.Color.Cyan;
            this.lblBuscarPor.Location = new System.Drawing.Point(9, 160);
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
            this.cbBuscarPor.Location = new System.Drawing.Point(9, 148);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(160, 21);
            this.cbBuscarPor.TabIndex = 61;
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(195, 148);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(124, 20);
            this.txtBuscarPor.TabIndex = 62;
            // 
            // ibtnBuscarPor
            // 
            this.ibtnBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarPor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarPor.IconColor = System.Drawing.Color.Cyan;
            this.ibtnBuscarPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarPor.IconSize = 20;
            this.ibtnBuscarPor.Location = new System.Drawing.Point(342, 139);
            this.ibtnBuscarPor.Name = "ibtnBuscarPor";
            this.ibtnBuscarPor.Size = new System.Drawing.Size(40, 30);
            this.ibtnBuscarPor.TabIndex = 63;
            this.ibtnBuscarPor.UseVisualStyleBackColor = false;
            // 
            // lblRV2
            // 
            this.lblRV2.AutoSize = true;
            this.lblRV2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRV2.Location = new System.Drawing.Point(9, 36);
            this.lblRV2.Name = "lblRV2";
            this.lblRV2.Size = new System.Drawing.Size(64, 13);
            this.lblRV2.TabIndex = 64;
            this.lblRV2.Text = "Buscar por :";
            // 
            // lblRV
            // 
            this.lblRV.AutoSize = true;
            this.lblRV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRV.Location = new System.Drawing.Point(6, 122);
            this.lblRV.Name = "lblRV";
            this.lblRV.Size = new System.Drawing.Size(64, 13);
            this.lblRV.TabIndex = 65;
            this.lblRV.Text = "Buscar por :";
            this.lblRV.Click += new System.EventHandler(this.lblRV_Click);
            // 
            // ibtnDescargaExcel
            // 
            this.ibtnDescargaExcel.AutoSize = true;
            this.ibtnDescargaExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnDescargaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnDescargaExcel.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtnDescargaExcel.ForeColor = System.Drawing.Color.Aqua;
            this.ibtnDescargaExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnDescargaExcel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibtnDescargaExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDescargaExcel.IconSize = 30;
            this.ibtnDescargaExcel.Location = new System.Drawing.Point(560, 143);
            this.ibtnDescargaExcel.Name = "ibtnDescargaExcel";
            this.ibtnDescargaExcel.Size = new System.Drawing.Size(73, 36);
            this.ibtnDescargaExcel.TabIndex = 66;
            this.ibtnDescargaExcel.Text = "Excel";
            this.ibtnDescargaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDescargaExcel.UseVisualStyleBackColor = true;
            // 
            // icbtnBuscarFecha
            // 
            this.icbtnBuscarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.icbtnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.icbtnBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.icbtnBuscarFecha.IconColor = System.Drawing.Color.Cyan;
            this.icbtnBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnBuscarFecha.IconSize = 20;
            this.icbtnBuscarFecha.Location = new System.Drawing.Point(342, 71);
            this.icbtnBuscarFecha.Name = "icbtnBuscarFecha";
            this.icbtnBuscarFecha.Size = new System.Drawing.Size(40, 30);
            this.icbtnBuscarFecha.TabIndex = 67;
            this.icbtnBuscarFecha.UseVisualStyleBackColor = false;
            // 
            // formReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(645, 447);
            this.Controls.Add(this.icbtnBuscarFecha);
            this.Controls.Add(this.ibtnDescargaExcel);
            this.Controls.Add(this.lblRV);
            this.Controls.Add(this.lblRV2);
            this.Controls.Add(this.ibtnBuscarPor);
            this.Controls.Add(this.txtBuscarPor);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dgReporteVentas);
            this.Controls.Add(this.lblReporteVentas);
            this.Name = "formReporteVentas";
            this.Text = "Reporte de Ventas";
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
        private FontAwesome.Sharp.IconButton ibtnBuscarPor;
        private System.Windows.Forms.Label lblRV2;
        private System.Windows.Forms.Label lblRV;
        private FontAwesome.Sharp.IconButton ibtnDescargaExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCom;
        private FontAwesome.Sharp.IconButton icbtnBuscarFecha;
    }
}