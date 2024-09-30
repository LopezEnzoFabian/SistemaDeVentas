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
            this.ibtnBuscar = new FontAwesome.Sharp.IconButton();
            this.ibtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblDocNum = new System.Windows.Forms.Label();
            this.dgDetalleCompra = new System.Windows.Forms.DataGridView();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.ibtnPDFDetalleCompra = new FontAwesome.Sharp.IconButton();
            this.lblDetallePago = new System.Windows.Forms.Label();
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
            this.txtRazonSoc.Location = new System.Drawing.Point(195, 46);
            this.txtRazonSoc.Name = "txtRazonSoc";
            this.txtRazonSoc.ReadOnly = true;
            this.txtRazonSoc.Size = new System.Drawing.Size(223, 21);
            this.txtRazonSoc.TabIndex = 48;
            // 
            // txtDNIproveedor
            // 
            this.txtDNIproveedor.Location = new System.Drawing.Point(9, 47);
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
            this.txtTIpofactura.Location = new System.Drawing.Point(154, 42);
            this.txtTIpofactura.Name = "txtTIpofactura";
            this.txtTIpofactura.ReadOnly = true;
            this.txtTIpofactura.Size = new System.Drawing.Size(130, 21);
            this.txtTIpofactura.TabIndex = 5;
            // 
            // txtUsuariocompra
            // 
            this.txtUsuariocompra.Location = new System.Drawing.Point(291, 42);
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
            this.txtFecha.Location = new System.Drawing.Point(9, 42);
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
            // ibtnBuscar
            // 
            this.ibtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscar.IconColor = System.Drawing.Color.Aqua;
            this.ibtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscar.IconSize = 20;
            this.ibtnBuscar.Location = new System.Drawing.Point(426, 11);
            this.ibtnBuscar.Name = "ibtnBuscar";
            this.ibtnBuscar.Size = new System.Drawing.Size(31, 30);
            this.ibtnBuscar.TabIndex = 48;
            this.ibtnBuscar.UseVisualStyleBackColor = false;
            this.ibtnBuscar.Click += new System.EventHandler(this.ibtnBuscar_Click);
            // 
            // ibtnLimpiar
            // 
            this.ibtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnLimpiar.IconColor = System.Drawing.Color.Aqua;
            this.ibtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiar.IconSize = 20;
            this.ibtnLimpiar.Location = new System.Drawing.Point(463, 13);
            this.ibtnLimpiar.Name = "ibtnLimpiar";
            this.ibtnLimpiar.Size = new System.Drawing.Size(39, 28);
            this.ibtnLimpiar.TabIndex = 47;
            this.ibtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(281, 15);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(130, 25);
            this.txtNumeroFactura.TabIndex = 46;
            this.txtNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocNum_KeyPress);
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
            this.dgDetalleCompra.AllowUserToOrderColumns = true;
            this.dgDetalleCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.colEliminar,
            this.colProducto,
            this.colDescripcion,
            this.colCodigo,
            this.colCant,
            this.colPrecioCompra,
            this.colSubTotal});
            this.dgDetalleCompra.Location = new System.Drawing.Point(0, 265);
            this.dgDetalleCompra.Name = "dgDetalleCompra";
            this.dgDetalleCompra.ReadOnly = true;
            this.dgDetalleCompra.RowHeadersVisible = false;
            this.dgDetalleCompra.Size = new System.Drawing.Size(661, 187);
            this.dgDetalleCompra.TabIndex = 50;
            this.dgDetalleCompra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgDetalleCompra_CellPainting);
            // 
            // colEliminar
            // 
            this.colEliminar.FillWeight = 35F;
            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Width = 30;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 84.5141F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 101;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colCant
            // 
            this.colCant.HeaderText = "Cantidad";
            this.colCant.Name = "colCant";
            this.colCant.ReadOnly = true;
            this.colCant.Width = 96;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.FillWeight = 84.5141F;
            this.colPrecioCompra.HeaderText = "Precio Compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            this.colPrecioCompra.Width = 101;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 84.5141F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 101;
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
            this.txtMontoTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMontoTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMontoTotal.Location = new System.Drawing.Point(511, 114);
            this.txtMontoTotal.Multiline = true;
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(75, 30);
            this.txtMontoTotal.TabIndex = 51;
            this.txtMontoTotal.Text = "0";
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
            this.ibtnPDFDetalleCompra.Location = new System.Drawing.Point(303, 458);
            this.ibtnPDFDetalleCompra.Name = "ibtnPDFDetalleCompra";
            this.ibtnPDFDetalleCompra.Size = new System.Drawing.Size(83, 56);
            this.ibtnPDFDetalleCompra.TabIndex = 53;
            this.ibtnPDFDetalleCompra.Text = "Descargar";
            this.ibtnPDFDetalleCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnPDFDetalleCompra.UseVisualStyleBackColor = false;
            this.ibtnPDFDetalleCompra.Click += new System.EventHandler(this.ibtnPDFDetalleCompra_Click);
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
            // formDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 526);
            this.Controls.Add(this.lblDetallePago);
            this.Controls.Add(this.ibtnPDFDetalleCompra);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.dgDetalleCompra);
            this.Controls.Add(this.lblDocNum);
            this.Controls.Add(this.ibtnBuscar);
            this.Controls.Add(this.ibtnLimpiar);
            this.Controls.Add(this.txtNumeroFactura);
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
        private FontAwesome.Sharp.IconButton ibtnBuscar;
        private FontAwesome.Sharp.IconButton ibtnLimpiar;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblDocNum;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgDetalleCompra;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private FontAwesome.Sharp.IconButton ibtnPDFDetalleCompra;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblDetallePago;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}