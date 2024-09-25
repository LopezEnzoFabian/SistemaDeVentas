namespace CapaPresentacion.Ventas
{
    partial class RegistrarVenta
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
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.ibtnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregarVenta = new FontAwesome.Sharp.IconButton();
            this.dgRegistrarVenta = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminarPro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPrecioVen = new System.Windows.Forms.Label();
            this.lblPrecioCom = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtPrecioVen = new System.Windows.Forms.TextBox();
            this.txtPrecioCom = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.gbInfoCliente = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.gbInfoVenta = new System.Windows.Forms.GroupBox();
            this.dtFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblTipoFac = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbTIpoFac = new System.Windows.Forms.ComboBox();
            this.lblRegistrarVenta = new System.Windows.Forms.Label();
            this.lblPagaCon = new System.Windows.Forms.Label();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistrarVenta)).BeginInit();
            this.gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.gbInfoCliente.SuspendLayout();
            this.gbInfoVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.ForeColor = System.Drawing.Color.White;
            this.lblTotalPag.Location = new System.Drawing.Point(557, 291);
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(70, 13);
            this.lblTotalPag.TabIndex = 51;
            this.lblTotalPag.Text = "Total a pagar";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(560, 307);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(75, 20);
            this.txtTotalPagar.TabIndex = 50;
            // 
            // ibtnRegistrarVenta
            // 
            this.ibtnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnRegistrarVenta.ForeColor = System.Drawing.Color.Aqua;
            this.ibtnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.ibtnRegistrarVenta.IconColor = System.Drawing.Color.Aqua;
            this.ibtnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrarVenta.Location = new System.Drawing.Point(561, 414);
            this.ibtnRegistrarVenta.Name = "ibtnRegistrarVenta";
            this.ibtnRegistrarVenta.Size = new System.Drawing.Size(78, 75);
            this.ibtnRegistrarVenta.TabIndex = 49;
            this.ibtnRegistrarVenta.Text = "Registrar venta";
            this.ibtnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // ibtnAgregarVenta
            // 
            this.ibtnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnAgregarVenta.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtnAgregarVenta.ForeColor = System.Drawing.Color.Aqua;
            this.ibtnAgregarVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ibtnAgregarVenta.IconColor = System.Drawing.Color.Aqua;
            this.ibtnAgregarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgregarVenta.IconSize = 35;
            this.ibtnAgregarVenta.Location = new System.Drawing.Point(298, 240);
            this.ibtnAgregarVenta.Name = "ibtnAgregarVenta";
            this.ibtnAgregarVenta.Size = new System.Drawing.Size(112, 53);
            this.ibtnAgregarVenta.TabIndex = 48;
            this.ibtnAgregarVenta.Text = "Agregar prodcuto";
            this.ibtnAgregarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnAgregarVenta.UseVisualStyleBackColor = true;
            // 
            // dgRegistrarVenta
            // 
            this.dgRegistrarVenta.AllowUserToOrderColumns = true;
            this.dgRegistrarVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgRegistrarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistrarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colPrecioCompra,
            this.colCPrecioVenta,
            this.colCantidad,
            this.colSubTotal,
            this.colEliminarPro});
            this.dgRegistrarVenta.Location = new System.Drawing.Point(14, 299);
            this.dgRegistrarVenta.Name = "dgRegistrarVenta";
            this.dgRegistrarVenta.ReadOnly = true;
            this.dgRegistrarVenta.Size = new System.Drawing.Size(541, 190);
            this.dgRegistrarVenta.TabIndex = 47;
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
            // gbInfoProducto
            // 
            this.gbInfoProducto.Controls.Add(this.lblCant);
            this.gbInfoProducto.Controls.Add(this.lblPrecioVen);
            this.gbInfoProducto.Controls.Add(this.lblPrecioCom);
            this.gbInfoProducto.Controls.Add(this.lblProducto);
            this.gbInfoProducto.Controls.Add(this.lblCodProducto);
            this.gbInfoProducto.Controls.Add(this.nudCant);
            this.gbInfoProducto.Controls.Add(this.ibtnSearch);
            this.gbInfoProducto.Controls.Add(this.txtPrecioVen);
            this.gbInfoProducto.Controls.Add(this.txtPrecioCom);
            this.gbInfoProducto.Controls.Add(this.txtProducto);
            this.gbInfoProducto.Controls.Add(this.txtCodProd);
            this.gbInfoProducto.ForeColor = System.Drawing.Color.White;
            this.gbInfoProducto.Location = new System.Drawing.Point(14, 132);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(624, 87);
            this.gbInfoProducto.TabIndex = 46;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "información de producto";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(509, 32);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 52;
            this.lblCant.Text = "Cantidad";
            // 
            // lblPrecioVen
            // 
            this.lblPrecioVen.AutoSize = true;
            this.lblPrecioVen.Location = new System.Drawing.Point(414, 32);
            this.lblPrecioVen.Name = "lblPrecioVen";
            this.lblPrecioVen.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioVen.TabIndex = 51;
            this.lblPrecioVen.Text = "Precio Venta";
            // 
            // lblPrecioCom
            // 
            this.lblPrecioCom.AutoSize = true;
            this.lblPrecioCom.Location = new System.Drawing.Point(321, 32);
            this.lblPrecioCom.Name = "lblPrecioCom";
            this.lblPrecioCom.Size = new System.Drawing.Size(75, 13);
            this.lblPrecioCom.TabIndex = 50;
            this.lblPrecioCom.Text = "Precio compra";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(185, 32);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 49;
            this.lblProducto.Text = "Producto";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(8, 32);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(100, 13);
            this.lblCodProducto.TabIndex = 48;
            this.lblCodProducto.Text = "Codigo de producto";
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(512, 48);
            this.nudCant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(80, 20);
            this.nudCant.TabIndex = 4;
            this.nudCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSearch.ForeColor = System.Drawing.Color.White;
            this.ibtnSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnSearch.IconColor = System.Drawing.Color.Aqua;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.IconSize = 20;
            this.ibtnSearch.Location = new System.Drawing.Point(143, 48);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(34, 21);
            this.ibtnSearch.TabIndex = 47;
            this.ibtnSearch.UseVisualStyleBackColor = false;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // txtPrecioVen
            // 
            this.txtPrecioVen.Location = new System.Drawing.Point(417, 48);
            this.txtPrecioVen.Name = "txtPrecioVen";
            this.txtPrecioVen.Size = new System.Drawing.Size(87, 20);
            this.txtPrecioVen.TabIndex = 5;
            // 
            // txtPrecioCom
            // 
            this.txtPrecioCom.Location = new System.Drawing.Point(324, 48);
            this.txtPrecioCom.Name = "txtPrecioCom";
            this.txtPrecioCom.Size = new System.Drawing.Size(87, 20);
            this.txtPrecioCom.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(188, 48);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(122, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(11, 48);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(126, 20);
            this.txtCodProd.TabIndex = 2;
            // 
            // gbInfoCliente
            // 
            this.gbInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.gbInfoCliente.Controls.Add(this.txtNombreCliente);
            this.gbInfoCliente.Controls.Add(this.txtNumDoc);
            this.gbInfoCliente.Controls.Add(this.btnsearch);
            this.gbInfoCliente.Controls.Add(this.lblNombreCompleto);
            this.gbInfoCliente.Controls.Add(this.lblNumDoc);
            this.gbInfoCliente.ForeColor = System.Drawing.Color.White;
            this.gbInfoCliente.Location = new System.Drawing.Point(332, 39);
            this.gbInfoCliente.Name = "gbInfoCliente";
            this.gbInfoCliente.Size = new System.Drawing.Size(306, 100);
            this.gbInfoCliente.TabIndex = 45;
            this.gbInfoCliente.TabStop = false;
            this.gbInfoCliente.Text = "información del cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(161, 53);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(132, 20);
            this.txtNombreCliente.TabIndex = 48;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(9, 53);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(109, 20);
            this.txtNumDoc.TabIndex = 47;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.Aqua;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(124, 53);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 20);
            this.btnsearch.TabIndex = 46;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(158, 33);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(6, 33);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(23, 13);
            this.lblNumDoc.TabIndex = 0;
            this.lblNumDoc.Text = "Dni";
            // 
            // gbInfoVenta
            // 
            this.gbInfoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.gbInfoVenta.Controls.Add(this.dtFechaVenta);
            this.gbInfoVenta.Controls.Add(this.lblTipoFac);
            this.gbInfoVenta.Controls.Add(this.lblFecha);
            this.gbInfoVenta.Controls.Add(this.cbTIpoFac);
            this.gbInfoVenta.ForeColor = System.Drawing.Color.White;
            this.gbInfoVenta.Location = new System.Drawing.Point(12, 40);
            this.gbInfoVenta.Name = "gbInfoVenta";
            this.gbInfoVenta.Size = new System.Drawing.Size(312, 86);
            this.gbInfoVenta.TabIndex = 44;
            this.gbInfoVenta.TabStop = false;
            this.gbInfoVenta.Text = "información de la venta";
            // 
            // dtFechaVenta
            // 
            this.dtFechaVenta.Location = new System.Drawing.Point(9, 54);
            this.dtFechaVenta.Name = "dtFechaVenta";
            this.dtFechaVenta.Size = new System.Drawing.Size(130, 20);
            this.dtFechaVenta.TabIndex = 4;
            // 
            // lblTipoFac
            // 
            this.lblTipoFac.AutoSize = true;
            this.lblTipoFac.Location = new System.Drawing.Point(158, 32);
            this.lblTipoFac.Name = "lblTipoFac";
            this.lblTipoFac.Size = new System.Drawing.Size(79, 13);
            this.lblTipoFac.TabIndex = 3;
            this.lblTipoFac.Text = "Tipo de factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // cbTIpoFac
            // 
            this.cbTIpoFac.FormattingEnabled = true;
            this.cbTIpoFac.Location = new System.Drawing.Point(161, 53);
            this.cbTIpoFac.Name = "cbTIpoFac";
            this.cbTIpoFac.Size = new System.Drawing.Size(143, 21);
            this.cbTIpoFac.TabIndex = 0;
            // 
            // lblRegistrarVenta
            // 
            this.lblRegistrarVenta.BackColor = System.Drawing.Color.Black;
            this.lblRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.lblRegistrarVenta.Location = new System.Drawing.Point(12, 9);
            this.lblRegistrarVenta.Name = "lblRegistrarVenta";
            this.lblRegistrarVenta.Size = new System.Drawing.Size(182, 28);
            this.lblRegistrarVenta.TabIndex = 43;
            this.lblRegistrarVenta.Text = "Registrar Venta";
            // 
            // lblPagaCon
            // 
            this.lblPagaCon.AutoSize = true;
            this.lblPagaCon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPagaCon.Location = new System.Drawing.Point(557, 330);
            this.lblPagaCon.Name = "lblPagaCon";
            this.lblPagaCon.Size = new System.Drawing.Size(59, 13);
            this.lblPagaCon.TabIndex = 52;
            this.lblPagaCon.Text = "Paga con :";
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(560, 346);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(77, 20);
            this.txtPagaCon.TabIndex = 53;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(561, 388);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(77, 20);
            this.txtCambio.TabIndex = 55;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCambio.Location = new System.Drawing.Point(560, 372);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(42, 13);
            this.lblCambio.TabIndex = 54;
            this.lblCambio.Text = "Cambio";
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(644, 500);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.lblPagaCon);
            this.Controls.Add(this.lblTotalPag);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.ibtnRegistrarVenta);
            this.Controls.Add(this.ibtnAgregarVenta);
            this.Controls.Add(this.dgRegistrarVenta);
            this.Controls.Add(this.gbInfoProducto);
            this.Controls.Add(this.gbInfoCliente);
            this.Controls.Add(this.gbInfoVenta);
            this.Controls.Add(this.lblRegistrarVenta);
            this.Name = "RegistrarVenta";
            this.Text = "RegistrarVenta";
            this.Load += new System.EventHandler(this.RegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistrarVenta)).EndInit();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.gbInfoCliente.ResumeLayout(false);
            this.gbInfoCliente.PerformLayout();
            this.gbInfoVenta.ResumeLayout(false);
            this.gbInfoVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPag;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private FontAwesome.Sharp.IconButton ibtnRegistrarVenta;
        private FontAwesome.Sharp.IconButton ibtnAgregarVenta;
        private System.Windows.Forms.DataGridView dgRegistrarVenta;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPrecioVen;
        private System.Windows.Forms.Label lblPrecioCom;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.NumericUpDown nudCant;
        private FontAwesome.Sharp.IconButton ibtnSearch;
        private System.Windows.Forms.TextBox txtPrecioVen;
        private System.Windows.Forms.TextBox txtPrecioCom;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.GroupBox gbInfoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNumDoc;
        private FontAwesome.Sharp.IconButton btnsearch;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.GroupBox gbInfoVenta;
        private System.Windows.Forms.Label lblTipoFac;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cbTIpoFac;
        private System.Windows.Forms.Label lblRegistrarVenta;
        private System.Windows.Forms.Label lblPagaCon;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminarPro;
        private System.Windows.Forms.DateTimePicker dtFechaVenta;
    }
}