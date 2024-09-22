namespace CapaPresentacion.Ventas
{
    partial class DetalleVenta
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
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.btnclean = new FontAwesome.Sharp.IconButton();
            this.txtBuscarNumFactura = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTotalCambio = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgListaDetalleVenta = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminarPro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.lblPrecioCom = new System.Windows.Forms.Label();
            this.lblTipoFACTURA = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtPrecioCom = new System.Windows.Forms.TextBox();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblNumeroDeDocumento = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.ibtnPDFDetalleCompra = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaDetalleVenta)).BeginInit();
            this.gbInformacionVenta.SuspendLayout();
            this.gbInformacionCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.Cyan;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(426, 37);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 30);
            this.btnsearch.TabIndex = 75;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // btnclean
            // 
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnclean.IconColor = System.Drawing.Color.Cyan;
            this.btnclean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclean.IconSize = 20;
            this.btnclean.Location = new System.Drawing.Point(463, 39);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(39, 28);
            this.btnclean.TabIndex = 74;
            this.btnclean.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNumFactura
            // 
            this.txtBuscarNumFactura.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNumFactura.Location = new System.Drawing.Point(290, 41);
            this.txtBuscarNumFactura.Name = "txtBuscarNumFactura";
            this.txtBuscarNumFactura.Size = new System.Drawing.Size(121, 25);
            this.txtBuscarNumFactura.TabIndex = 72;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFiltro.Location = new System.Drawing.Point(158, 49);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(119, 17);
            this.lblFiltro.TabIndex = 71;
            this.lblFiltro.Text = "Numero de factura";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 439);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 84;
            // 
            // lblTotalCambio
            // 
            this.lblTotalCambio.AutoSize = true;
            this.lblTotalCambio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalCambio.Location = new System.Drawing.Point(209, 423);
            this.lblTotalCambio.Name = "lblTotalCambio";
            this.lblTotalCambio.Size = new System.Drawing.Size(68, 13);
            this.lblTotalCambio.TabIndex = 83;
            this.lblTotalCambio.Text = "Total cambio";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 439);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 82;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPago.Location = new System.Drawing.Point(113, 423);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(58, 13);
            this.lblTotalPago.TabIndex = 81;
            this.lblTotalPago.Text = "Total pago";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.ForeColor = System.Drawing.Color.White;
            this.lblMontoTotal.Location = new System.Drawing.Point(13, 423);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(60, 13);
            this.lblMontoTotal.TabIndex = 80;
            this.lblMontoTotal.Text = "Monto total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 439);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 79;
            // 
            // dgListaDetalleVenta
            // 
            this.dgListaDetalleVenta.AllowUserToOrderColumns = true;
            this.dgListaDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgListaDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colPrecioCompra,
            this.colCPrecioVenta,
            this.colCantidad,
            this.colSubTotal,
            this.colEliminarPro});
            this.dgListaDetalleVenta.Location = new System.Drawing.Point(12, 261);
            this.dgListaDetalleVenta.Name = "dgListaDetalleVenta";
            this.dgListaDetalleVenta.ReadOnly = true;
            this.dgListaDetalleVenta.Size = new System.Drawing.Size(620, 150);
            this.dgListaDetalleVenta.TabIndex = 77;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "idProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            this.colIdProducto.Width = 84;
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
            // colCPrecioVenta
            // 
            this.colCPrecioVenta.HeaderText = "Precio Venta";
            this.colCPrecioVenta.Name = "colCPrecioVenta";
            this.colCPrecioVenta.ReadOnly = true;
            this.colCPrecioVenta.Visible = false;
            this.colCPrecioVenta.Width = 96;
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 84.5141F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 101;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 84.5141F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 101;
            // 
            // colEliminarPro
            // 
            this.colEliminarPro.HeaderText = "Eliminar";
            this.colEliminarPro.Name = "colEliminarPro";
            this.colEliminarPro.ReadOnly = true;
            this.colEliminarPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEliminarPro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.lblPrecioCom);
            this.gbInformacionVenta.Controls.Add(this.lblTipoFACTURA);
            this.gbInformacionVenta.Controls.Add(this.lblCod);
            this.gbInformacionVenta.Controls.Add(this.txtPrecioCom);
            this.gbInformacionVenta.Controls.Add(this.txtTipoDoc);
            this.gbInformacionVenta.Controls.Add(this.txtFechaVenta);
            this.gbInformacionVenta.ForeColor = System.Drawing.Color.White;
            this.gbInformacionVenta.Location = new System.Drawing.Point(116, 75);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Size = new System.Drawing.Size(433, 87);
            this.gbInformacionVenta.TabIndex = 76;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "información de venta";
            // 
            // lblPrecioCom
            // 
            this.lblPrecioCom.AutoSize = true;
            this.lblPrecioCom.Location = new System.Drawing.Point(307, 32);
            this.lblPrecioCom.Name = "lblPrecioCom";
            this.lblPrecioCom.Size = new System.Drawing.Size(96, 13);
            this.lblPrecioCom.TabIndex = 50;
            this.lblPrecioCom.Text = "Nombre de usuario";
            // 
            // lblTipoFACTURA
            // 
            this.lblTipoFACTURA.AutoSize = true;
            this.lblTipoFACTURA.Location = new System.Drawing.Point(159, 32);
            this.lblTipoFACTURA.Name = "lblTipoFACTURA";
            this.lblTipoFACTURA.Size = new System.Drawing.Size(79, 13);
            this.lblTipoFACTURA.TabIndex = 49;
            this.lblTipoFACTURA.Text = "Tipo de factura";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(8, 32);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(37, 13);
            this.lblCod.TabIndex = 48;
            this.lblCod.Text = "Fecha";
            // 
            // txtPrecioCom
            // 
            this.txtPrecioCom.Location = new System.Drawing.Point(310, 48);
            this.txtPrecioCom.Name = "txtPrecioCom";
            this.txtPrecioCom.ReadOnly = true;
            this.txtPrecioCom.Size = new System.Drawing.Size(108, 20);
            this.txtPrecioCom.TabIndex = 4;
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(162, 48);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.ReadOnly = true;
            this.txtTipoDoc.Size = new System.Drawing.Size(122, 20);
            this.txtTipoDoc.TabIndex = 3;
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Location = new System.Drawing.Point(11, 48);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.ReadOnly = true;
            this.txtFechaVenta.Size = new System.Drawing.Size(124, 20);
            this.txtFechaVenta.TabIndex = 2;
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Controls.Add(this.lblNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.lblNumeroDeDocumento);
            this.gbInformacionCliente.Controls.Add(this.txtNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.txtDNI);
            this.gbInformacionCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.gbInformacionCliente.Location = new System.Drawing.Point(116, 168);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(433, 87);
            this.gbInformacionCliente.TabIndex = 85;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "información del cliente";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(210, 32);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreCompleto.TabIndex = 49;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // lblNumeroDeDocumento
            // 
            this.lblNumeroDeDocumento.AutoSize = true;
            this.lblNumeroDeDocumento.Location = new System.Drawing.Point(24, 32);
            this.lblNumeroDeDocumento.Name = "lblNumeroDeDocumento";
            this.lblNumeroDeDocumento.Size = new System.Drawing.Size(115, 13);
            this.lblNumeroDeDocumento.TabIndex = 48;
            this.lblNumeroDeDocumento.Text = "Numero de documento";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(213, 48);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.ReadOnly = true;
            this.txtNombreCompleto.Size = new System.Drawing.Size(151, 20);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(27, 48);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(128, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Detalle de Venta";
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDetalleVenta.Location = new System.Drawing.Point(12, 9);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(153, 24);
            this.lblDetalleVenta.TabIndex = 87;
            this.lblDetalleVenta.Text = "Detalle de ventas";
            // 
            // ibtnPDFDetalleCompra
            // 
            this.ibtnPDFDetalleCompra.AutoSize = true;
            this.ibtnPDFDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPDFDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnPDFDetalleCompra.ForeColor = System.Drawing.Color.Aqua;
            this.ibtnPDFDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnPDFDetalleCompra.IconColor = System.Drawing.Color.Red;
            this.ibtnPDFDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPDFDetalleCompra.IconSize = 30;
            this.ibtnPDFDetalleCompra.Location = new System.Drawing.Point(534, 423);
            this.ibtnPDFDetalleCompra.Name = "ibtnPDFDetalleCompra";
            this.ibtnPDFDetalleCompra.Size = new System.Drawing.Size(98, 38);
            this.ibtnPDFDetalleCompra.TabIndex = 88;
            this.ibtnPDFDetalleCompra.Text = "Descargar";
            this.ibtnPDFDetalleCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPDFDetalleCompra.UseVisualStyleBackColor = true;
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(644, 472);
            this.Controls.Add(this.ibtnPDFDetalleCompra);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblTotalCambio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgListaDetalleVenta);
            this.Controls.Add(this.gbInformacionVenta);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.txtBuscarNumFactura);
            this.Controls.Add(this.lblFiltro);
            this.Name = "DetalleVenta";
            this.Text = "DetalleVenta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaDetalleVenta)).EndInit();
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnclean;
        private System.Windows.Forms.TextBox txtBuscarNumFactura;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTotalCambio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgListaDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminarPro;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.Label lblPrecioCom;
        private System.Windows.Forms.Label lblTipoFACTURA;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtPrecioCom;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblNumeroDeDocumento;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetalleVenta;
        private FontAwesome.Sharp.IconButton ibtnPDFDetalleCompra;
    }
}