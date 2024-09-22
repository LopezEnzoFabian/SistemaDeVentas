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
            this.lblRepoCompras = new System.Windows.Forms.Label();
            this.dgReporteCompras = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProvee = new System.Windows.Forms.ComboBox();
            this.ibtnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.ibtnDescargaExcel = new FontAwesome.Sharp.IconButton();
            this.lblRV = new System.Windows.Forms.Label();
            this.ibtnBuscarPor = new FontAwesome.Sharp.IconButton();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRepoCompras
            // 
            this.lblRepoCompras.AutoSize = true;
            this.lblRepoCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepoCompras.ForeColor = System.Drawing.Color.Cyan;
            this.lblRepoCompras.Location = new System.Drawing.Point(255, 9);
            this.lblRepoCompras.Name = "lblRepoCompras";
            this.lblRepoCompras.Size = new System.Drawing.Size(185, 24);
            this.lblRepoCompras.TabIndex = 0;
            this.lblRepoCompras.Text = "Reporte de Compras";
            // 
            // dgReporteCompras
            // 
            this.dgReporteCompras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgReporteCompras.Location = new System.Drawing.Point(3, 178);
            this.dgReporteCompras.Name = "dgReporteCompras";
            this.dgReporteCompras.Size = new System.Drawing.Size(638, 215);
            this.dgReporteCompras.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(214, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha fin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(271, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.ForeColor = System.Drawing.Color.Cyan;
            this.lblProveedor.Location = new System.Drawing.Point(409, 76);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 47;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cbProvee
            // 
            this.cbProvee.FormattingEnabled = true;
            this.cbProvee.Location = new System.Drawing.Point(471, 69);
            this.cbProvee.Name = "cbProvee";
            this.cbProvee.Size = new System.Drawing.Size(100, 21);
            this.cbProvee.TabIndex = 48;
            // 
            // ibtnBuscarProveedor
            // 
            this.ibtnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarProveedor.IconColor = System.Drawing.Color.Cyan;
            this.ibtnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarProveedor.IconSize = 20;
            this.ibtnBuscarProveedor.Location = new System.Drawing.Point(577, 63);
            this.ibtnBuscarProveedor.Name = "ibtnBuscarProveedor";
            this.ibtnBuscarProveedor.Size = new System.Drawing.Size(40, 30);
            this.ibtnBuscarProveedor.TabIndex = 49;
            this.ibtnBuscarProveedor.UseVisualStyleBackColor = false;
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
            this.ibtnDescargaExcel.Location = new System.Drawing.Point(559, 399);
            this.ibtnDescargaExcel.Name = "ibtnDescargaExcel";
            this.ibtnDescargaExcel.Size = new System.Drawing.Size(75, 38);
            this.ibtnDescargaExcel.TabIndex = 67;
            this.ibtnDescargaExcel.Text = "Excel";
            this.ibtnDescargaExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDescargaExcel.UseVisualStyleBackColor = true;
            // 
            // lblRV
            // 
            this.lblRV.AutoSize = true;
            this.lblRV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRV.Location = new System.Drawing.Point(9, 121);
            this.lblRV.Name = "lblRV";
            this.lblRV.Size = new System.Drawing.Size(64, 13);
            this.lblRV.TabIndex = 71;
            this.lblRV.Text = "Buscar por :";
            // 
            // ibtnBuscarPor
            // 
            this.ibtnBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarPor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarPor.IconColor = System.Drawing.Color.Cyan;
            this.ibtnBuscarPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarPor.IconSize = 20;
            this.ibtnBuscarPor.Location = new System.Drawing.Point(271, 142);
            this.ibtnBuscarPor.Name = "ibtnBuscarPor";
            this.ibtnBuscarPor.Size = new System.Drawing.Size(31, 30);
            this.ibtnBuscarPor.TabIndex = 70;
            this.ibtnBuscarPor.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(141, 147);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(124, 20);
            this.txtBuscarPor.TabIndex = 69;
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Items.AddRange(new object[] {
            "Fecha de registro",
            "Tipo de documento",
            "Numero de factura"});
            this.cbBuscarPor.Location = new System.Drawing.Point(12, 147);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.cbBuscarPor.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Buscar por :";
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
            // formReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(645, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRV);
            this.Controls.Add(this.ibtnBuscarPor);
            this.Controls.Add(this.txtBuscarPor);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.ibtnDescargaExcel);
            this.Controls.Add(this.ibtnBuscarProveedor);
            this.Controls.Add(this.cbProvee);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReporteCompras);
            this.Controls.Add(this.lblRepoCompras);
            this.Name = "formReporteCompra";
            this.Text = "Reporte de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepoCompras;
        private System.Windows.Forms.DataGridView dgReporteCompras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbProvee;
        private FontAwesome.Sharp.IconButton ibtnBuscarProveedor;
        private FontAwesome.Sharp.IconButton ibtnDescargaExcel;
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
        private System.Windows.Forms.Label lblRV;
        private FontAwesome.Sharp.IconButton ibtnBuscarPor;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.Label label1;
    }
}