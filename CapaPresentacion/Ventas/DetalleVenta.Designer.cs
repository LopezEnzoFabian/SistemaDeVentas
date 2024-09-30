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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.btnclean = new FontAwesome.Sharp.IconButton();
            this.txtBuscarNumFactura = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtTotalcambio = new System.Windows.Forms.TextBox();
            this.lblTotalCambio = new System.Windows.Forms.Label();
            this.txtTotalpago = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtTotalmonto = new System.Windows.Forms.TextBox();
            this.dgListaDetalleVenta = new System.Windows.Forms.DataGridView();
            this.colEliminarPro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblTipoFACTURA = new System.Windows.Forms.Label();
            this.lblFechaventa = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtTipofactura = new System.Windows.Forms.TextBox();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblNumeroDeDocumento = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNIcliente = new System.Windows.Forms.TextBox();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.ibtnPDFDetalleVenta = new FontAwesome.Sharp.IconButton();
            this.lblDetallepago = new System.Windows.Forms.Label();
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
            this.btnsearch.Location = new System.Drawing.Point(414, 8);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 30);
            this.btnsearch.TabIndex = 75;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnclean.IconColor = System.Drawing.Color.Cyan;
            this.btnclean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclean.IconSize = 20;
            this.btnclean.Location = new System.Drawing.Point(451, 10);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(39, 28);
            this.btnclean.TabIndex = 74;
            this.btnclean.UseVisualStyleBackColor = false;
            // 
            // txtBuscarNumFactura
            // 
            this.txtBuscarNumFactura.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNumFactura.Location = new System.Drawing.Point(278, 12);
            this.txtBuscarNumFactura.Name = "txtBuscarNumFactura";
            this.txtBuscarNumFactura.Size = new System.Drawing.Size(121, 25);
            this.txtBuscarNumFactura.TabIndex = 72;
            this.txtBuscarNumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarNumFactura_KeyPress);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Black;
            this.lblFiltro.Location = new System.Drawing.Point(125, 21);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(147, 16);
            this.lblFiltro.TabIndex = 71;
            this.lblFiltro.Text = "Numero de factura";
            // 
            // txtTotalcambio
            // 
            this.txtTotalcambio.Location = new System.Drawing.Point(532, 206);
            this.txtTotalcambio.Name = "txtTotalcambio";
            this.txtTotalcambio.ReadOnly = true;
            this.txtTotalcambio.Size = new System.Drawing.Size(77, 20);
            this.txtTotalcambio.TabIndex = 84;
            // 
            // lblTotalCambio
            // 
            this.lblTotalCambio.AutoSize = true;
            this.lblTotalCambio.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCambio.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCambio.Location = new System.Drawing.Point(529, 190);
            this.lblTotalCambio.Name = "lblTotalCambio";
            this.lblTotalCambio.Size = new System.Drawing.Size(92, 15);
            this.lblTotalCambio.TabIndex = 83;
            this.lblTotalCambio.Text = "Total cambio";
            // 
            // txtTotalpago
            // 
            this.txtTotalpago.Location = new System.Drawing.Point(533, 153);
            this.txtTotalpago.Name = "txtTotalpago";
            this.txtTotalpago.ReadOnly = true;
            this.txtTotalpago.Size = new System.Drawing.Size(77, 20);
            this.txtTotalpago.TabIndex = 82;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPago.Location = new System.Drawing.Point(532, 135);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(77, 15);
            this.lblTotalPago.TabIndex = 81;
            this.lblTotalPago.Text = "Total pago";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.Black;
            this.lblMontoTotal.Location = new System.Drawing.Point(529, 87);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(81, 15);
            this.lblMontoTotal.TabIndex = 80;
            this.lblMontoTotal.Text = "Monto total";
            // 
            // txtTotalmonto
            // 
            this.txtTotalmonto.Location = new System.Drawing.Point(532, 103);
            this.txtTotalmonto.Name = "txtTotalmonto";
            this.txtTotalmonto.ReadOnly = true;
            this.txtTotalmonto.Size = new System.Drawing.Size(75, 20);
            this.txtTotalmonto.TabIndex = 79;
            // 
            // dgListaDetalleVenta
            // 
            this.dgListaDetalleVenta.AllowUserToDeleteRows = false;
            this.dgListaDetalleVenta.AllowUserToResizeColumns = false;
            this.dgListaDetalleVenta.AllowUserToResizeRows = false;
            this.dgListaDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgListaDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgListaDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEliminarPro,
            this.colProducto,
            this.colCategoria,
            this.colCantidad,
            this.colCPrecioVenta,
            this.colCliente,
            this.colSubTotal,
            this.colIdProducto});
            this.dgListaDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgListaDetalleVenta.Location = new System.Drawing.Point(2, 261);
            this.dgListaDetalleVenta.MultiSelect = false;
            this.dgListaDetalleVenta.Name = "dgListaDetalleVenta";
            this.dgListaDetalleVenta.ReadOnly = true;
            this.dgListaDetalleVenta.RowHeadersVisible = false;
            this.dgListaDetalleVenta.Size = new System.Drawing.Size(658, 181);
            this.dgListaDetalleVenta.TabIndex = 77;
            this.dgListaDetalleVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgListaDetalleVenta_CellPainting);
            // 
            // colEliminarPro
            // 
            this.colEliminarPro.FillWeight = 30F;
            this.colEliminarPro.HeaderText = "";
            this.colEliminarPro.Name = "colEliminarPro";
            this.colEliminarPro.ReadOnly = true;
            this.colEliminarPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEliminarPro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEliminarPro.Width = 30;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 84.5141F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 101;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 84.5141F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 101;
            // 
            // colCPrecioVenta
            // 
            this.colCPrecioVenta.HeaderText = "Precio Venta";
            this.colCPrecioVenta.Name = "colCPrecioVenta";
            this.colCPrecioVenta.ReadOnly = true;
            this.colCPrecioVenta.Width = 96;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 84.5141F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 101;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "idProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            this.colIdProducto.Width = 84;
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.lblNombreVendedor);
            this.gbInformacionVenta.Controls.Add(this.lblTipoFACTURA);
            this.gbInformacionVenta.Controls.Add(this.lblFechaventa);
            this.gbInformacionVenta.Controls.Add(this.txtNombreVendedor);
            this.gbInformacionVenta.Controls.Add(this.txtTipofactura);
            this.gbInformacionVenta.Controls.Add(this.txtFechaVenta);
            this.gbInformacionVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.ForeColor = System.Drawing.Color.Black;
            this.gbInformacionVenta.Location = new System.Drawing.Point(12, 75);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Size = new System.Drawing.Size(448, 87);
            this.gbInformacionVenta.TabIndex = 76;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "información de venta";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(277, 32);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(150, 15);
            this.lblNombreVendedor.TabIndex = 50;
            this.lblNombreVendedor.Text = "Nombre del vendedor";
            // 
            // lblTipoFACTURA
            // 
            this.lblTipoFACTURA.AutoSize = true;
            this.lblTipoFACTURA.Location = new System.Drawing.Point(146, 32);
            this.lblTipoFACTURA.Name = "lblTipoFACTURA";
            this.lblTipoFACTURA.Size = new System.Drawing.Size(108, 15);
            this.lblTipoFACTURA.TabIndex = 49;
            this.lblTipoFACTURA.Text = "Tipo de factura";
            // 
            // lblFechaventa
            // 
            this.lblFechaventa.AutoSize = true;
            this.lblFechaventa.Location = new System.Drawing.Point(8, 32);
            this.lblFechaventa.Name = "lblFechaventa";
            this.lblFechaventa.Size = new System.Drawing.Size(108, 15);
            this.lblFechaventa.TabIndex = 48;
            this.lblFechaventa.Text = "Fecha de venta";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(280, 48);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.ReadOnly = true;
            this.txtNombreVendedor.Size = new System.Drawing.Size(152, 21);
            this.txtNombreVendedor.TabIndex = 4;
            // 
            // txtTipofactura
            // 
            this.txtTipofactura.Location = new System.Drawing.Point(149, 48);
            this.txtTipofactura.Name = "txtTipofactura";
            this.txtTipofactura.ReadOnly = true;
            this.txtTipofactura.Size = new System.Drawing.Size(122, 21);
            this.txtTipofactura.TabIndex = 3;
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Location = new System.Drawing.Point(11, 48);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.ReadOnly = true;
            this.txtFechaVenta.Size = new System.Drawing.Size(124, 21);
            this.txtFechaVenta.TabIndex = 2;
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Controls.Add(this.lblNombreCompleto);
            this.gbInformacionCliente.Controls.Add(this.lblNumeroDeDocumento);
            this.gbInformacionCliente.Controls.Add(this.txtNombreCliente);
            this.gbInformacionCliente.Controls.Add(this.txtDNIcliente);
            this.gbInformacionCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.ForeColor = System.Drawing.Color.Black;
            this.gbInformacionCliente.Location = new System.Drawing.Point(12, 168);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(448, 87);
            this.gbInformacionCliente.TabIndex = 85;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "información del cliente";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(232, 28);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(123, 15);
            this.lblNombreCompleto.TabIndex = 49;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // lblNumeroDeDocumento
            // 
            this.lblNumeroDeDocumento.AutoSize = true;
            this.lblNumeroDeDocumento.Location = new System.Drawing.Point(8, 28);
            this.lblNumeroDeDocumento.Name = "lblNumeroDeDocumento";
            this.lblNumeroDeDocumento.Size = new System.Drawing.Size(156, 15);
            this.lblNumeroDeDocumento.TabIndex = 48;
            this.lblNumeroDeDocumento.Text = "Numero de documento";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(234, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(195, 21);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtDNIcliente
            // 
            this.txtDNIcliente.Location = new System.Drawing.Point(11, 46);
            this.txtDNIcliente.Name = "txtDNIcliente";
            this.txtDNIcliente.ReadOnly = true;
            this.txtDNIcliente.Size = new System.Drawing.Size(217, 21);
            this.txtDNIcliente.TabIndex = 2;
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.ForeColor = System.Drawing.Color.Black;
            this.lblDetalleVenta.Location = new System.Drawing.Point(9, 48);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(190, 24);
            this.lblDetalleVenta.TabIndex = 87;
            this.lblDetalleVenta.Text = "Detalle de la venta";
            // 
            // ibtnPDFDetalleVenta
            // 
            this.ibtnPDFDetalleVenta.AutoSize = true;
            this.ibtnPDFDetalleVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnPDFDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPDFDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnPDFDetalleVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.ibtnPDFDetalleVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnPDFDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnPDFDetalleVenta.IconColor = System.Drawing.Color.Red;
            this.ibtnPDFDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPDFDetalleVenta.IconSize = 30;
            this.ibtnPDFDetalleVenta.Location = new System.Drawing.Point(300, 459);
            this.ibtnPDFDetalleVenta.Name = "ibtnPDFDetalleVenta";
            this.ibtnPDFDetalleVenta.Size = new System.Drawing.Size(82, 55);
            this.ibtnPDFDetalleVenta.TabIndex = 88;
            this.ibtnPDFDetalleVenta.Text = "Descargar";
            this.ibtnPDFDetalleVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnPDFDetalleVenta.UseVisualStyleBackColor = false;
            this.ibtnPDFDetalleVenta.Click += new System.EventHandler(this.ibtnPDFDetalleVenta_Click);
            // 
            // lblDetallepago
            // 
            this.lblDetallepago.AutoSize = true;
            this.lblDetallepago.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallepago.Location = new System.Drawing.Point(489, 48);
            this.lblDetallepago.Name = "lblDetallepago";
            this.lblDetallepago.Size = new System.Drawing.Size(161, 24);
            this.lblDetallepago.TabIndex = 89;
            this.lblDetallepago.Text = "Detalle de pago";
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 526);
            this.Controls.Add(this.lblDetallepago);
            this.Controls.Add(this.ibtnPDFDetalleVenta);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.txtTotalcambio);
            this.Controls.Add(this.lblTotalCambio);
            this.Controls.Add(this.txtTotalpago);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.txtTotalmonto);
            this.Controls.Add(this.dgListaDetalleVenta);
            this.Controls.Add(this.gbInformacionVenta);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.txtBuscarNumFactura);
            this.Controls.Add(this.lblFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox txtTotalcambio;
        private System.Windows.Forms.Label lblTotalCambio;
        private System.Windows.Forms.TextBox txtTotalpago;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtTotalmonto;
        private System.Windows.Forms.DataGridView dgListaDetalleVenta;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblTipoFACTURA;
        private System.Windows.Forms.Label lblFechaventa;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.TextBox txtTipofactura;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblNumeroDeDocumento;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDNIcliente;
        private System.Windows.Forms.Label lblDetalleVenta;
        private FontAwesome.Sharp.IconButton ibtnPDFDetalleVenta;
        private System.Windows.Forms.Label lblDetallepago;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminarPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
    }
}