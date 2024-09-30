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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dgReporteVentas = new System.Windows.Forms.DataGridView();
            this.colFechaDeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtFechaFin.Location = new System.Drawing.Point(223, 100);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(229, 20);
            this.dtFechaFin.TabIndex = 55;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(223, 74);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(229, 20);
            this.dtFechaInicio.TabIndex = 54;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFin.Location = new System.Drawing.Point(145, 105);
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
            this.lblFechaInicio.Location = new System.Drawing.Point(106, 79);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(117, 15);
            this.lblFechaInicio.TabIndex = 52;
            this.lblFechaInicio.Text = "Fecha de inicio :";
            // 
            // dgReporteVentas
            // 
            this.dgReporteVentas.AllowUserToDeleteRows = false;
            this.dgReporteVentas.AllowUserToResizeColumns = false;
            this.dgReporteVentas.AllowUserToResizeRows = false;
            this.dgReporteVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgReporteVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReporteVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgReporteVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaDeRegistro,
            this.colNomPro,
            this.colCodProd,
            this.colPrecioCom,
            this.colMontoTotal,
            this.colNombreCliente,
            this.colTipoDocumento,
            this.colNumeroDocumento,
            this.colUsuarioRegistro,
            this.colCate});
            this.dgReporteVentas.Location = new System.Drawing.Point(2, 204);
            this.dgReporteVentas.Name = "dgReporteVentas";
            this.dgReporteVentas.ReadOnly = true;
            this.dgReporteVentas.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgReporteVentas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgReporteVentas.Size = new System.Drawing.Size(658, 254);
            this.dgReporteVentas.TabIndex = 51;
            // 
            // colFechaDeRegistro
            // 
            this.colFechaDeRegistro.FillWeight = 120F;
            this.colFechaDeRegistro.HeaderText = "Fecha de registro";
            this.colFechaDeRegistro.Name = "colFechaDeRegistro";
            this.colFechaDeRegistro.ReadOnly = true;
            this.colFechaDeRegistro.Width = 120;
            // 
            // colNomPro
            // 
            this.colNomPro.FillWeight = 150F;
            this.colNomPro.HeaderText = "Nombre de producto";
            this.colNomPro.Name = "colNomPro";
            this.colNomPro.ReadOnly = true;
            this.colNomPro.Width = 150;
            // 
            // colCodProd
            // 
            this.colCodProd.FillWeight = 150F;
            this.colCodProd.HeaderText = "Codigo de producto";
            this.colCodProd.Name = "colCodProd";
            this.colCodProd.ReadOnly = true;
            this.colCodProd.Width = 150;
            // 
            // colPrecioCom
            // 
            this.colPrecioCom.HeaderText = "Precio venta";
            this.colPrecioCom.Name = "colPrecioCom";
            this.colPrecioCom.ReadOnly = true;
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.HeaderText = "Monto Total";
            this.colMontoTotal.Name = "colMontoTotal";
            this.colMontoTotal.ReadOnly = true;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FillWeight = 150F;
            this.colNombreCliente.HeaderText = "Nombre del cliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.ReadOnly = true;
            this.colNombreCliente.Width = 150;
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
            // colUsuarioRegistro
            // 
            this.colUsuarioRegistro.FillWeight = 150F;
            this.colUsuarioRegistro.HeaderText = "Usuario Registro";
            this.colUsuarioRegistro.Name = "colUsuarioRegistro";
            this.colUsuarioRegistro.ReadOnly = true;
            this.colUsuarioRegistro.Width = 150;
            // 
            // colCate
            // 
            this.colCate.HeaderText = "Categoria";
            this.colCate.Name = "colCate";
            this.colCate.ReadOnly = true;
            // 
            // lblReporteVentas
            // 
            this.lblReporteVentas.AutoSize = true;
            this.lblReporteVentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteVentas.ForeColor = System.Drawing.Color.Black;
            this.lblReporteVentas.Location = new System.Drawing.Point(255, 9);
            this.lblReporteVentas.Name = "lblReporteVentas";
            this.lblReporteVentas.Size = new System.Drawing.Size(185, 24);
            this.lblReporteVentas.TabIndex = 50;
            this.lblReporteVentas.Text = "Reporte de Ventas";
            this.lblReporteVentas.Click += new System.EventHandler(this.lblRepoCompras_Click);
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
            this.cbBuscarPor.Location = new System.Drawing.Point(15, 177);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(160, 21);
            this.cbBuscarPor.TabIndex = 61;
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(190, 178);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(124, 20);
            this.txtBuscarPor.TabIndex = 62;
            this.txtBuscarPor.TextChanged += new System.EventHandler(this.txtBuscarPor_TextChanged);
            // 
            // ibtnBuscarPor
            // 
            this.ibtnBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarPor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarPor.IconColor = System.Drawing.Color.Cyan;
            this.ibtnBuscarPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarPor.IconSize = 20;
            this.ibtnBuscarPor.Location = new System.Drawing.Point(320, 170);
            this.ibtnBuscarPor.Name = "ibtnBuscarPor";
            this.ibtnBuscarPor.Size = new System.Drawing.Size(27, 28);
            this.ibtnBuscarPor.TabIndex = 63;
            this.ibtnBuscarPor.UseVisualStyleBackColor = false;
            this.ibtnBuscarPor.Click += new System.EventHandler(this.ibtnBuscarPor_Click);
            // 
            // lblRV2
            // 
            this.lblRV2.AutoSize = true;
            this.lblRV2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRV2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRV2.Location = new System.Drawing.Point(106, 46);
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
            this.lblRV.Location = new System.Drawing.Point(12, 151);
            this.lblRV.Name = "lblRV";
            this.lblRV.Size = new System.Drawing.Size(90, 15);
            this.lblRV.TabIndex = 65;
            this.lblRV.Text = "Buscar por :";
            this.lblRV.Click += new System.EventHandler(this.lblRV_Click);
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
            this.ibtnDescargaExcel.IconSize = 30;
            this.ibtnDescargaExcel.Location = new System.Drawing.Point(592, 464);
            this.ibtnDescargaExcel.Name = "ibtnDescargaExcel";
            this.ibtnDescargaExcel.Size = new System.Drawing.Size(57, 55);
            this.ibtnDescargaExcel.TabIndex = 66;
            this.ibtnDescargaExcel.Text = "Excel";
            this.ibtnDescargaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnDescargaExcel.UseVisualStyleBackColor = false;
            this.ibtnDescargaExcel.Click += new System.EventHandler(this.ibtnDescargaExcel_Click);
            // 
            // icbtnBuscarFecha
            // 
            this.icbtnBuscarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.icbtnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.icbtnBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.icbtnBuscarFecha.IconColor = System.Drawing.Color.Cyan;
            this.icbtnBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnBuscarFecha.IconSize = 20;
            this.icbtnBuscarFecha.Location = new System.Drawing.Point(458, 93);
            this.icbtnBuscarFecha.Name = "icbtnBuscarFecha";
            this.icbtnBuscarFecha.Size = new System.Drawing.Size(32, 27);
            this.icbtnBuscarFecha.TabIndex = 67;
            this.icbtnBuscarFecha.UseVisualStyleBackColor = false;
            this.icbtnBuscarFecha.Click += new System.EventHandler(this.icbtnBuscarFecha_Click);
            // 
            // formReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(661, 528);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private FontAwesome.Sharp.IconButton icbtnBuscarFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCate;
    }
}