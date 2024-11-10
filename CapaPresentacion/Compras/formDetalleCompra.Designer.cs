namespace CapaPresentacion
{
    partial class formDetalleCompra
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
            this.gbInfoProve = new System.Windows.Forms.GroupBox();
            this.txtRazonSoc = new System.Windows.Forms.TextBox();
            this.txtDNIproveedor = new System.Windows.Forms.TextBox();
            this.lblRazonSoc = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtTIpofactura = new System.Windows.Forms.TextBox();
            this.txtUsuariocompra = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblDetalleCompra = new System.Windows.Forms.Label();
            this.txtBuscarFactura = new System.Windows.Forms.TextBox();
            this.lblDocNum = new System.Windows.Forms.Label();
            this.dgDetalleCompra = new System.Windows.Forms.DataGridView();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblDetallePago = new System.Windows.Forms.Label();
            this.txtnumerofactura = new System.Windows.Forms.TextBox();
            this.ibtnPDFDetalleCompra = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new FontAwesome.Sharp.IconButton();
            this.txtLimpiar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoProve.SuspendLayout();
            this.gbInfoCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoProve
            // 
            this.gbInfoProve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoProve.Controls.Add(this.txtRazonSoc);
            this.gbInfoProve.Controls.Add(this.txtDNIproveedor);
            this.gbInfoProve.Controls.Add(this.lblRazonSoc);
            this.gbInfoProve.Controls.Add(this.lblNumDoc);
            this.gbInfoProve.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProve.ForeColor = System.Drawing.Color.Black;
            this.gbInfoProve.Location = new System.Drawing.Point(15, 162);
            this.gbInfoProve.Name = "gbInfoProve";
            this.gbInfoProve.Size = new System.Drawing.Size(429, 83);
            this.gbInfoProve.TabIndex = 4;
            this.gbInfoProve.TabStop = false;
            this.gbInfoProve.Text = "información de proveedor";
            // 
            // txtRazonSoc
            // 
            this.txtRazonSoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSoc.Location = new System.Drawing.Point(195, 46);
            this.txtRazonSoc.Multiline = true;
            this.txtRazonSoc.Name = "txtRazonSoc";
            this.txtRazonSoc.ReadOnly = true;
            this.txtRazonSoc.Size = new System.Drawing.Size(223, 21);
            this.txtRazonSoc.TabIndex = 48;
            // 
            // txtDNIproveedor
            // 
            this.txtDNIproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNIproveedor.Location = new System.Drawing.Point(9, 47);
            this.txtDNIproveedor.Multiline = true;
            this.txtDNIproveedor.Name = "txtDNIproveedor";
            this.txtDNIproveedor.ReadOnly = true;
            this.txtDNIproveedor.Size = new System.Drawing.Size(180, 21);
            this.txtDNIproveedor.TabIndex = 47;
            // 
            // lblRazonSoc
            // 
            this.lblRazonSoc.AutoSize = true;
            this.lblRazonSoc.Location = new System.Drawing.Point(192, 26);
            this.lblRazonSoc.Name = "lblRazonSoc";
            this.lblRazonSoc.Size = new System.Drawing.Size(90, 15);
            this.lblRazonSoc.TabIndex = 1;
            this.lblRazonSoc.Text = "Razon social";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(6, 26);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(135, 15);
            this.lblNumDoc.TabIndex = 0;
            this.lblNumDoc.Text = "Numero documento";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoCompra.Controls.Add(this.lblUsuario);
            this.gbInfoCompra.Controls.Add(this.txtTIpofactura);
            this.gbInfoCompra.Controls.Add(this.txtUsuariocompra);
            this.gbInfoCompra.Controls.Add(this.lblTipoDoc);
            this.gbInfoCompra.Controls.Add(this.lblFecha);
            this.gbInfoCompra.Controls.Add(this.txtFecha);
            this.gbInfoCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.ForeColor = System.Drawing.Color.Black;
            this.gbInfoCompra.Location = new System.Drawing.Point(12, 80);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(432, 76);
            this.gbInfoCompra.TabIndex = 3;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "información de compra";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(288, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(133, 15);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Nombre de usuario";
            // 
            // txtTIpofactura
            // 
            this.txtTIpofactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTIpofactura.Location = new System.Drawing.Point(154, 42);
            this.txtTIpofactura.Multiline = true;
            this.txtTIpofactura.Name = "txtTIpofactura";
            this.txtTIpofactura.ReadOnly = true;
            this.txtTIpofactura.Size = new System.Drawing.Size(130, 21);
            this.txtTIpofactura.TabIndex = 5;
            // 
            // txtUsuariocompra
            // 
            this.txtUsuariocompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuariocompra.Location = new System.Drawing.Point(291, 42);
            this.txtUsuariocompra.Multiline = true;
            this.txtUsuariocompra.Name = "txtUsuariocompra";
            this.txtUsuariocompra.ReadOnly = true;
            this.txtUsuariocompra.Size = new System.Drawing.Size(130, 21);
            this.txtUsuariocompra.TabIndex = 4;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(151, 26);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(108, 15);
            this.lblTipoDoc.TabIndex = 3;
            this.lblTipoDoc.Text = "Tipo de factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Location = new System.Drawing.Point(9, 42);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(130, 21);
            this.txtFecha.TabIndex = 1;
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.lblDetalleCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCompra.ForeColor = System.Drawing.Color.Black;
            this.lblDetalleCompra.Location = new System.Drawing.Point(7, 47);
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(221, 28);
            this.lblDetalleCompra.TabIndex = 5;
            this.lblDetalleCompra.Text = "Detalle de la compra";
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFactura.Location = new System.Drawing.Point(281, 15);
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.Size = new System.Drawing.Size(130, 25);
            this.txtBuscarFactura.TabIndex = 46;
            // 
            // lblDocNum
            // 
            this.lblDocNum.AutoSize = true;
            this.lblDocNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocNum.ForeColor = System.Drawing.Color.Black;
            this.lblDocNum.Location = new System.Drawing.Point(134, 24);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.Size = new System.Drawing.Size(141, 16);
            this.lblDocNum.TabIndex = 49;
            this.lblDocNum.Text = "Numero de factura";
            // 
            // dgDetalleCompra
            // 
            this.dgDetalleCompra.AllowUserToAddRows = false;
            this.dgDetalleCompra.AllowUserToDeleteRows = false;
            this.dgDetalleCompra.AllowUserToResizeColumns = false;
            this.dgDetalleCompra.AllowUserToResizeRows = false;
            this.dgDetalleCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colPrecioCompra,
            this.colCant,
            this.colSubTotal});
            this.dgDetalleCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDetalleCompra.Location = new System.Drawing.Point(0, 265);
            this.dgDetalleCompra.Name = "dgDetalleCompra";
            this.dgDetalleCompra.ReadOnly = true;
            this.dgDetalleCompra.RowHeadersVisible = false;
            this.dgDetalleCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDetalleCompra.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDetalleCompra.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgDetalleCompra.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalleCompra.Size = new System.Drawing.Size(662, 197);
            this.dgDetalleCompra.TabIndex = 50;
            this.dgDetalleCompra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgDetalleCompra_CellPainting);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.Black;
            this.lblMontoTotal.Location = new System.Drawing.Point(508, 96);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(84, 15);
            this.lblMontoTotal.TabIndex = 52;
            this.lblMontoTotal.Text = "Monto Total";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMontoTotal.BackColor = System.Drawing.Color.White;
            this.txtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMontoTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMontoTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMontoTotal.Location = new System.Drawing.Point(511, 122);
            this.txtMontoTotal.Multiline = true;
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(81, 21);
            this.txtMontoTotal.TabIndex = 51;
            this.txtMontoTotal.Text = "0";
            // 
            // lblDetallePago
            // 
            this.lblDetallePago.AutoSize = true;
            this.lblDetallePago.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.lblDetallePago.ForeColor = System.Drawing.Color.Black;
            this.lblDetallePago.Location = new System.Drawing.Point(459, 51);
            this.lblDetallePago.Name = "lblDetallePago";
            this.lblDetallePago.Size = new System.Drawing.Size(161, 24);
            this.lblDetallePago.TabIndex = 54;
            this.lblDetallePago.Text = "Detalle de pago";
            // 
            // txtnumerofactura
            // 
            this.txtnumerofactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtnumerofactura.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnumerofactura.Location = new System.Drawing.Point(511, 186);
            this.txtnumerofactura.Multiline = true;
            this.txtnumerofactura.Name = "txtnumerofactura";
            this.txtnumerofactura.ReadOnly = true;
            this.txtnumerofactura.Size = new System.Drawing.Size(40, 19);
            this.txtnumerofactura.TabIndex = 55;
            this.txtnumerofactura.Text = "0";
            this.txtnumerofactura.Visible = false;
            // 
            // ibtnPDFDetalleCompra
            // 
            this.ibtnPDFDetalleCompra.AutoSize = true;
            this.ibtnPDFDetalleCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnPDFDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPDFDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnPDFDetalleCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnPDFDetalleCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnPDFDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnPDFDetalleCompra.IconColor = System.Drawing.Color.Red;
            this.ibtnPDFDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPDFDetalleCompra.IconSize = 30;
            this.ibtnPDFDetalleCompra.Location = new System.Drawing.Point(294, 468);
            this.ibtnPDFDetalleCompra.Name = "ibtnPDFDetalleCompra";
            this.ibtnPDFDetalleCompra.Size = new System.Drawing.Size(81, 56);
            this.ibtnPDFDetalleCompra.TabIndex = 53;
            this.ibtnPDFDetalleCompra.Text = "Descargar";
            this.ibtnPDFDetalleCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnPDFDetalleCompra.UseVisualStyleBackColor = false;
            this.ibtnPDFDetalleCompra.Click += new System.EventHandler(this.ibtnPDFDetalleCompra_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.txtBuscar.IconColor = System.Drawing.Color.Aqua;
            this.txtBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtBuscar.IconSize = 20;
            this.txtBuscar.Location = new System.Drawing.Point(426, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(31, 28);
            this.txtBuscar.TabIndex = 48;
            this.txtBuscar.UseVisualStyleBackColor = false;
            this.txtBuscar.Click += new System.EventHandler(this.ibtnBuscar_Click);
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtLimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.txtLimpiar.IconColor = System.Drawing.Color.Aqua;
            this.txtLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtLimpiar.IconSize = 20;
            this.txtLimpiar.Location = new System.Drawing.Point(463, 13);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(33, 28);
            this.txtLimpiar.TabIndex = 47;
            this.txtLimpiar.UseVisualStyleBackColor = false;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(487, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "$:";
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 84.5141F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 101;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.FillWeight = 84.5141F;
            this.colPrecioCompra.HeaderText = "Precio Compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            this.colPrecioCompra.Width = 101;
            // 
            // colCant
            // 
            this.colCant.HeaderText = "Cantidad";
            this.colCant.Name = "colCant";
            this.colCant.ReadOnly = true;
            this.colCant.Width = 96;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 84.5141F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 101;
            // 
            // formDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumerofactura);
            this.Controls.Add(this.lblDetallePago);
            this.Controls.Add(this.ibtnPDFDetalleCompra);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.dgDetalleCompra);
            this.Controls.Add(this.lblDocNum);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.txtBuscarFactura);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.gbInfoProve);
            this.Controls.Add(this.gbInfoCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDetalleCompra";
            this.Text = "formDetalleCompra";
            this.Load += new System.EventHandler(this.formDetalleCompra_Load);
            this.gbInfoProve.ResumeLayout(false);
            this.gbInfoProve.PerformLayout();
            this.gbInfoCompra.ResumeLayout(false);
            this.gbInfoCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoProve;
        private System.Windows.Forms.TextBox txtRazonSoc;
        private System.Windows.Forms.TextBox txtDNIproveedor;
        private System.Windows.Forms.Label lblRazonSoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.TextBox txtTIpofactura;
        private System.Windows.Forms.TextBox txtUsuariocompra;
        private FontAwesome.Sharp.IconButton txtBuscar;
        private FontAwesome.Sharp.IconButton txtLimpiar;
        private System.Windows.Forms.TextBox txtBuscarFactura;
        private System.Windows.Forms.Label lblDocNum;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgDetalleCompra;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private FontAwesome.Sharp.IconButton ibtnPDFDetalleCompra;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblDetallePago;
        private System.Windows.Forms.TextBox txtnumerofactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}