﻿namespace CapaPresentacion.Compras
{
    partial class formRegistrarCompra
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
            this.panelRegistrarCompra = new System.Windows.Forms.Panel();
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            this.dgListarUsuario = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPrecioVen = new System.Windows.Forms.Label();
            this.lblPrecioCom = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtPrecioVen = new System.Windows.Forms.TextBox();
            this.txtPrecioCom = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.gbInfoProve = new System.Windows.Forms.GroupBox();
            this.txtRazonSoc = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.lblRazonSoc = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbTIpoDoc = new System.Windows.Forms.ComboBox();
            this.lblRegistrarCompra = new System.Windows.Forms.Label();
            this.panelRegistrarCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarUsuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.gbInfoProve.SuspendLayout();
            this.gbInfoCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistrarCompra
            // 
            this.panelRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.panelRegistrarCompra.Controls.Add(this.lblTotalPag);
            this.panelRegistrarCompra.Controls.Add(this.textBox1);
            this.panelRegistrarCompra.Controls.Add(this.ibtnRegistrar);
            this.panelRegistrarCompra.Controls.Add(this.ibtnAgregar);
            this.panelRegistrarCompra.Controls.Add(this.dgListarUsuario);
            this.panelRegistrarCompra.Controls.Add(this.groupBox2);
            this.panelRegistrarCompra.Controls.Add(this.gbInfoProve);
            this.panelRegistrarCompra.Controls.Add(this.gbInfoCompra);
            this.panelRegistrarCompra.Controls.Add(this.lblRegistrarCompra);
            this.panelRegistrarCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistrarCompra.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrarCompra.Name = "panelRegistrarCompra";
            this.panelRegistrarCompra.Size = new System.Drawing.Size(778, 436);
            this.panelRegistrarCompra.TabIndex = 1;
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.ForeColor = System.Drawing.Color.White;
            this.lblTotalPag.Location = new System.Drawing.Point(684, 303);
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(70, 13);
            this.lblTotalPag.TabIndex = 42;
            this.lblTotalPag.Text = "Total a pagar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "0";
            // 
            // ibtnRegistrar
            // 
            this.ibtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.ibtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.ibtnRegistrar.IconColor = System.Drawing.Color.White;
            this.ibtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrar.Location = new System.Drawing.Point(687, 345);
            this.ibtnRegistrar.Name = "ibtnRegistrar";
            this.ibtnRegistrar.Size = new System.Drawing.Size(75, 65);
            this.ibtnRegistrar.TabIndex = 40;
            this.ibtnRegistrar.Text = "Registrar";
            this.ibtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // ibtnAgregar
            // 
            this.ibtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAgregar.ForeColor = System.Drawing.Color.White;
            this.ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ibtnAgregar.IconColor = System.Drawing.Color.White;
            this.ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgregar.IconSize = 35;
            this.ibtnAgregar.Location = new System.Drawing.Point(687, 189);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(75, 53);
            this.ibtnAgregar.TabIndex = 39;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgListarUsuario
            // 
            this.dgListarUsuario.AllowUserToOrderColumns = true;
            this.dgListarUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.colIdProducto,
            this.colProducto,
            this.colPrecioCompra,
            this.colCPrecioVenta,
            this.colCantidad,
            this.colSubTotal});
            this.dgListarUsuario.Location = new System.Drawing.Point(8, 267);
            this.dgListarUsuario.Name = "dgListarUsuario";
            this.dgListarUsuario.ReadOnly = true;
            this.dgListarUsuario.Size = new System.Drawing.Size(667, 155);
            this.dgListarUsuario.TabIndex = 38;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 57.2977F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 68;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCant);
            this.groupBox2.Controls.Add(this.lblPrecioVen);
            this.groupBox2.Controls.Add(this.lblPrecioCom);
            this.groupBox2.Controls.Add(this.lblProducto);
            this.groupBox2.Controls.Add(this.lblCod);
            this.groupBox2.Controls.Add(this.nudCant);
            this.groupBox2.Controls.Add(this.ibtnSearch);
            this.groupBox2.Controls.Add(this.txtPrecioVen);
            this.groupBox2.Controls.Add(this.txtPrecioCom);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Controls.Add(this.txtCodProd);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 102);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "información de producto";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(569, 31);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 52;
            this.lblCant.Text = "Cantidad";
            // 
            // lblPrecioVen
            // 
            this.lblPrecioVen.AutoSize = true;
            this.lblPrecioVen.Location = new System.Drawing.Point(474, 31);
            this.lblPrecioVen.Name = "lblPrecioVen";
            this.lblPrecioVen.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioVen.TabIndex = 51;
            this.lblPrecioVen.Text = "Precio Venta";
            // 
            // lblPrecioCom
            // 
            this.lblPrecioCom.AutoSize = true;
            this.lblPrecioCom.Location = new System.Drawing.Point(381, 31);
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
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(8, 32);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(100, 13);
            this.lblCod.TabIndex = 48;
            this.lblCod.Text = "Codigo de producto";
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(572, 47);
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
            this.ibtnSearch.IconColor = System.Drawing.Color.White;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.IconSize = 20;
            this.ibtnSearch.Location = new System.Drawing.Point(143, 48);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(34, 21);
            this.ibtnSearch.TabIndex = 47;
            this.ibtnSearch.UseVisualStyleBackColor = false;
            // 
            // txtPrecioVen
            // 
            this.txtPrecioVen.Location = new System.Drawing.Point(477, 47);
            this.txtPrecioVen.Name = "txtPrecioVen";
            this.txtPrecioVen.Size = new System.Drawing.Size(87, 20);
            this.txtPrecioVen.TabIndex = 5;
            // 
            // txtPrecioCom
            // 
            this.txtPrecioCom.Location = new System.Drawing.Point(384, 47);
            this.txtPrecioCom.Name = "txtPrecioCom";
            this.txtPrecioCom.Size = new System.Drawing.Size(87, 20);
            this.txtPrecioCom.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(188, 48);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(190, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(11, 48);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(128, 20);
            this.txtCodProd.TabIndex = 2;
            // 
            // gbInfoProve
            // 
            this.gbInfoProve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.gbInfoProve.Controls.Add(this.txtRazonSoc);
            this.gbInfoProve.Controls.Add(this.txtNumDoc);
            this.gbInfoProve.Controls.Add(this.btnsearch);
            this.gbInfoProve.Controls.Add(this.lblRazonSoc);
            this.gbInfoProve.Controls.Add(this.lblNumDoc);
            this.gbInfoProve.ForeColor = System.Drawing.Color.White;
            this.gbInfoProve.Location = new System.Drawing.Point(326, 53);
            this.gbInfoProve.Name = "gbInfoProve";
            this.gbInfoProve.Size = new System.Drawing.Size(349, 100);
            this.gbInfoProve.TabIndex = 36;
            this.gbInfoProve.TabStop = false;
            this.gbInfoProve.Text = "información de proveedor";
            // 
            // txtRazonSoc
            // 
            this.txtRazonSoc.Location = new System.Drawing.Point(182, 53);
            this.txtRazonSoc.Name = "txtRazonSoc";
            this.txtRazonSoc.Size = new System.Drawing.Size(147, 20);
            this.txtRazonSoc.TabIndex = 48;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(9, 53);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(130, 20);
            this.txtNumDoc.TabIndex = 47;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(145, 53);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 20);
            this.btnsearch.TabIndex = 46;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // lblRazonSoc
            // 
            this.lblRazonSoc.AutoSize = true;
            this.lblRazonSoc.Location = new System.Drawing.Point(179, 33);
            this.lblRazonSoc.Name = "lblRazonSoc";
            this.lblRazonSoc.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSoc.TabIndex = 1;
            this.lblRazonSoc.Text = "Razon social";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(6, 33);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(100, 13);
            this.lblNumDoc.TabIndex = 0;
            this.lblNumDoc.Text = "Numero documento";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.gbInfoCompra.Controls.Add(this.lblTipoDoc);
            this.gbInfoCompra.Controls.Add(this.lblFecha);
            this.gbInfoCompra.Controls.Add(this.txtFecha);
            this.gbInfoCompra.Controls.Add(this.cbTIpoDoc);
            this.gbInfoCompra.ForeColor = System.Drawing.Color.White;
            this.gbInfoCompra.Location = new System.Drawing.Point(8, 53);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(312, 100);
            this.gbInfoCompra.TabIndex = 35;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "información de compra";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(154, 33);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDoc.TabIndex = 3;
            this.lblTipoDoc.Text = "Tipo Documento";
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
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(9, 54);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(130, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // cbTIpoDoc
            // 
            this.cbTIpoDoc.FormattingEnabled = true;
            this.cbTIpoDoc.Location = new System.Drawing.Point(157, 54);
            this.cbTIpoDoc.Name = "cbTIpoDoc";
            this.cbTIpoDoc.Size = new System.Drawing.Size(143, 21);
            this.cbTIpoDoc.TabIndex = 0;
            // 
            // lblRegistrarCompra
            // 
            this.lblRegistrarCompra.BackColor = System.Drawing.Color.Black;
            this.lblRegistrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.lblRegistrarCompra.Location = new System.Drawing.Point(3, 5);
            this.lblRegistrarCompra.Name = "lblRegistrarCompra";
            this.lblRegistrarCompra.Size = new System.Drawing.Size(182, 28);
            this.lblRegistrarCompra.TabIndex = 34;
            this.lblRegistrarCompra.Text = "Registrar Compra";
            // 
            // formRegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.panelRegistrarCompra);
            this.Name = "formRegistrarCompra";
            this.Text = "formRegistrarCompra";
            this.panelRegistrarCompra.ResumeLayout(false);
            this.panelRegistrarCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarUsuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.gbInfoProve.ResumeLayout(false);
            this.gbInfoProve.PerformLayout();
            this.gbInfoCompra.ResumeLayout(false);
            this.gbInfoCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistrarCompra;
        private System.Windows.Forms.Label lblTotalPag;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibtnRegistrar;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private System.Windows.Forms.DataGridView dgListarUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPrecioVen;
        private System.Windows.Forms.Label lblPrecioCom;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.NumericUpDown nudCant;
        private FontAwesome.Sharp.IconButton ibtnSearch;
        private System.Windows.Forms.TextBox txtPrecioVen;
        private System.Windows.Forms.TextBox txtPrecioCom;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.GroupBox gbInfoProve;
        private System.Windows.Forms.TextBox txtRazonSoc;
        private System.Windows.Forms.TextBox txtNumDoc;
        private FontAwesome.Sharp.IconButton btnsearch;
        private System.Windows.Forms.Label lblRazonSoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cbTIpoDoc;
        private System.Windows.Forms.Label lblRegistrarCompra;
    }
}