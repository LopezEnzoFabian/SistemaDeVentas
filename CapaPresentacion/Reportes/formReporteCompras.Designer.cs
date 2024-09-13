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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ibtnBuscarPorFec = new FontAwesome.Sharp.IconButton();
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProvee = new System.Windows.Forms.ComboBox();
            this.ibtnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRepoCompras
            // 
            this.lblRepoCompras.AutoSize = true;
            this.lblRepoCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepoCompras.ForeColor = System.Drawing.Color.Cyan;
            this.lblRepoCompras.Location = new System.Drawing.Point(338, 9);
            this.lblRepoCompras.Name = "lblRepoCompras";
            this.lblRepoCompras.Size = new System.Drawing.Size(185, 24);
            this.lblRepoCompras.TabIndex = 0;
            this.lblRepoCompras.Text = "Reporte de Compras";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 249);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(172, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(419, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha fin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(476, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // ibtnBuscarPorFec
            // 
            this.ibtnBuscarPorFec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarPorFec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarPorFec.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarPorFec.IconColor = System.Drawing.Color.White;
            this.ibtnBuscarPorFec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarPorFec.IconSize = 20;
            this.ibtnBuscarPorFec.Location = new System.Drawing.Point(625, 41);
            this.ibtnBuscarPorFec.Name = "ibtnBuscarPorFec";
            this.ibtnBuscarPorFec.Size = new System.Drawing.Size(31, 30);
            this.ibtnBuscarPorFec.TabIndex = 46;
            this.ibtnBuscarPorFec.UseVisualStyleBackColor = false;
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
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.ForeColor = System.Drawing.Color.Cyan;
            this.lblProveedor.Location = new System.Drawing.Point(302, 91);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 47;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cbProvee
            // 
            this.cbProvee.FormattingEnabled = true;
            this.cbProvee.Location = new System.Drawing.Point(364, 83);
            this.cbProvee.Name = "cbProvee";
            this.cbProvee.Size = new System.Drawing.Size(121, 21);
            this.cbProvee.TabIndex = 48;
            // 
            // ibtnBuscarProveedor
            // 
            this.ibtnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarProveedor.IconColor = System.Drawing.Color.White;
            this.ibtnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarProveedor.IconSize = 20;
            this.ibtnBuscarProveedor.Location = new System.Drawing.Point(502, 82);
            this.ibtnBuscarProveedor.Name = "ibtnBuscarProveedor";
            this.ibtnBuscarProveedor.Size = new System.Drawing.Size(31, 30);
            this.ibtnBuscarProveedor.TabIndex = 49;
            this.ibtnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // formReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(840, 385);
            this.Controls.Add(this.ibtnBuscarProveedor);
            this.Controls.Add(this.cbProvee);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.ibtnBuscarPorFec);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRepoCompras);
            this.Name = "formReporteCompra";
            this.Text = "Reporte de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepoCompras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private FontAwesome.Sharp.IconButton ibtnBuscarPorFec;
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
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbProvee;
        private FontAwesome.Sharp.IconButton ibtnBuscarProveedor;
    }
}