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
            this.ibtnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.ibtnBuscarPorFec = new FontAwesome.Sharp.IconButton();
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
            this.colNomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReporteVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // ibtnBuscarProveedor
            // 
            this.ibtnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarProveedor.IconColor = System.Drawing.Color.White;
            this.ibtnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarProveedor.IconSize = 20;
            this.ibtnBuscarProveedor.Location = new System.Drawing.Point(496, 85);
            this.ibtnBuscarProveedor.Name = "ibtnBuscarProveedor";
            this.ibtnBuscarProveedor.Size = new System.Drawing.Size(31, 30);
            this.ibtnBuscarProveedor.TabIndex = 59;
            this.ibtnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(358, 86);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbProveedor.TabIndex = 58;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.ForeColor = System.Drawing.Color.Cyan;
            this.lblProveedor.Location = new System.Drawing.Point(296, 94);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 57;
            this.lblProveedor.Text = "Proveedor";
            // 
            // ibtnBuscarPorFec
            // 
            this.ibtnBuscarPorFec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarPorFec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarPorFec.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarPorFec.IconColor = System.Drawing.Color.White;
            this.ibtnBuscarPorFec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarPorFec.IconSize = 20;
            this.ibtnBuscarPorFec.Location = new System.Drawing.Point(592, 41);
            this.ibtnBuscarPorFec.Name = "ibtnBuscarPorFec";
            this.ibtnBuscarPorFec.Size = new System.Drawing.Size(31, 30);
            this.ibtnBuscarPorFec.TabIndex = 56;
            this.ibtnBuscarPorFec.UseVisualStyleBackColor = false;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(443, 45);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(143, 20);
            this.dtFechaFin.TabIndex = 55;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(221, 45);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(144, 20);
            this.dtFechaInicio.TabIndex = 54;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.ForeColor = System.Drawing.Color.Cyan;
            this.lblFechaFin.Location = new System.Drawing.Point(386, 52);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(51, 13);
            this.lblFechaFin.TabIndex = 53;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Cyan;
            this.lblFechaInicio.Location = new System.Drawing.Point(139, 51);
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
            this.colNomPro,
            this.colCate,
            this.colPrecioCom});
            this.dgReporteVentas.Location = new System.Drawing.Point(6, 134);
            this.dgReporteVentas.Name = "dgReporteVentas";
            this.dgReporteVentas.Size = new System.Drawing.Size(834, 241);
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
            this.colNumeroDocumento.HeaderText = "Numero de documento";
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
            this.lblReporteVentas.Location = new System.Drawing.Point(321, 9);
            this.lblReporteVentas.Name = "lblReporteVentas";
            this.lblReporteVentas.Size = new System.Drawing.Size(167, 24);
            this.lblReporteVentas.TabIndex = 50;
            this.lblReporteVentas.Text = "Reporte de Ventas";
            this.lblReporteVentas.Click += new System.EventHandler(this.lblRepoCompras_Click);
            // 
            // formReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(846, 377);
            this.Controls.Add(this.ibtnBuscarProveedor);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.ibtnBuscarPorFec);
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

        private FontAwesome.Sharp.IconButton ibtnBuscarProveedor;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private FontAwesome.Sharp.IconButton ibtnBuscarPorFec;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DataGridView dgReporteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCom;
        private System.Windows.Forms.Label lblReporteVentas;
    }
}