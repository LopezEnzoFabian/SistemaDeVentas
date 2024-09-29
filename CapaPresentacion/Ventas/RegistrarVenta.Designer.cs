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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.dgRegistrarVenta = new System.Windows.Forms.DataGridView();
            this.colEliminarPro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ibtnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregarVenta = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistrarVenta)).BeginInit();
            this.gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.gbInfoCliente.SuspendLayout();
            this.gbInfoVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPag
            // 
            resources.ApplyResources(this.lblTotalPag, "lblTotalPag");
            this.lblTotalPag.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPag.Name = "lblTotalPag";
            // 
            // txtTotalPagar
            // 
            resources.ApplyResources(this.txtTotalPagar, "txtTotalPagar");
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            // 
            // dgRegistrarVenta
            // 
            resources.ApplyResources(this.dgRegistrarVenta, "dgRegistrarVenta");
            this.dgRegistrarVenta.AllowUserToDeleteRows = false;
            this.dgRegistrarVenta.AllowUserToResizeColumns = false;
            this.dgRegistrarVenta.AllowUserToResizeRows = false;
            this.dgRegistrarVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgRegistrarVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistrarVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgRegistrarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgRegistrarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEliminarPro,
            this.colIdProducto,
            this.colProducto,
            this.colPrecioCompra,
            this.colCPrecioVenta,
            this.colCantidad,
            this.colSubTotal});
            this.dgRegistrarVenta.Name = "dgRegistrarVenta";
            this.dgRegistrarVenta.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistrarVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgRegistrarVenta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            // 
            // colEliminarPro
            // 
            this.colEliminarPro.FillWeight = 40F;
            resources.ApplyResources(this.colEliminarPro, "colEliminarPro");
            this.colEliminarPro.Name = "colEliminarPro";
            this.colEliminarPro.ReadOnly = true;
            this.colEliminarPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEliminarPro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colIdProducto
            // 
            resources.ApplyResources(this.colIdProducto, "colIdProducto");
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 84.5141F;
            resources.ApplyResources(this.colProducto, "colProducto");
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.FillWeight = 84.5141F;
            resources.ApplyResources(this.colPrecioCompra, "colPrecioCompra");
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            // 
            // colCPrecioVenta
            // 
            resources.ApplyResources(this.colCPrecioVenta, "colCPrecioVenta");
            this.colCPrecioVenta.Name = "colCPrecioVenta";
            this.colCPrecioVenta.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 84.5141F;
            resources.ApplyResources(this.colCantidad, "colCantidad");
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 84.5141F;
            resources.ApplyResources(this.colSubTotal, "colSubTotal");
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // gbInfoProducto
            // 
            resources.ApplyResources(this.gbInfoProducto, "gbInfoProducto");
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
            this.gbInfoProducto.ForeColor = System.Drawing.Color.Black;
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.TabStop = false;
            // 
            // lblCant
            // 
            resources.ApplyResources(this.lblCant, "lblCant");
            this.lblCant.Name = "lblCant";
            // 
            // lblPrecioVen
            // 
            resources.ApplyResources(this.lblPrecioVen, "lblPrecioVen");
            this.lblPrecioVen.Name = "lblPrecioVen";
            // 
            // lblPrecioCom
            // 
            resources.ApplyResources(this.lblPrecioCom, "lblPrecioCom");
            this.lblPrecioCom.Name = "lblPrecioCom";
            // 
            // lblProducto
            // 
            resources.ApplyResources(this.lblProducto, "lblProducto");
            this.lblProducto.Name = "lblProducto";
            // 
            // lblCodProducto
            // 
            resources.ApplyResources(this.lblCodProducto, "lblCodProducto");
            this.lblCodProducto.Name = "lblCodProducto";
            // 
            // nudCant
            // 
            resources.ApplyResources(this.nudCant, "nudCant");
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
            this.nudCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ibtnSearch
            // 
            resources.ApplyResources(this.ibtnSearch, "ibtnSearch");
            this.ibtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnSearch.ForeColor = System.Drawing.Color.White;
            this.ibtnSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnSearch.IconColor = System.Drawing.Color.Aqua;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.IconSize = 20;
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.UseVisualStyleBackColor = false;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // txtPrecioVen
            // 
            resources.ApplyResources(this.txtPrecioVen, "txtPrecioVen");
            this.txtPrecioVen.Name = "txtPrecioVen";
            this.txtPrecioVen.ReadOnly = true;
            // 
            // txtPrecioCom
            // 
            resources.ApplyResources(this.txtPrecioCom, "txtPrecioCom");
            this.txtPrecioCom.Name = "txtPrecioCom";
            this.txtPrecioCom.ReadOnly = true;
            // 
            // txtProducto
            // 
            resources.ApplyResources(this.txtProducto, "txtProducto");
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            // 
            // txtCodProd
            // 
            resources.ApplyResources(this.txtCodProd, "txtCodProd");
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ReadOnly = true;
            // 
            // gbInfoCliente
            // 
            resources.ApplyResources(this.gbInfoCliente, "gbInfoCliente");
            this.gbInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoCliente.Controls.Add(this.txtNombreCliente);
            this.gbInfoCliente.Controls.Add(this.txtNumDoc);
            this.gbInfoCliente.Controls.Add(this.btnsearch);
            this.gbInfoCliente.Controls.Add(this.lblNombreCompleto);
            this.gbInfoCliente.Controls.Add(this.lblNumDoc);
            this.gbInfoCliente.ForeColor = System.Drawing.Color.Black;
            this.gbInfoCliente.Name = "gbInfoCliente";
            this.gbInfoCliente.TabStop = false;
            // 
            // txtNombreCliente
            // 
            resources.ApplyResources(this.txtNombreCliente, "txtNombreCliente");
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            // 
            // txtNumDoc
            // 
            resources.ApplyResources(this.txtNumDoc, "txtNumDoc");
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.ReadOnly = true;
            // 
            // btnsearch
            // 
            resources.ApplyResources(this.btnsearch, "btnsearch");
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.Aqua;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblNombreCompleto
            // 
            resources.ApplyResources(this.lblNombreCompleto, "lblNombreCompleto");
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            // 
            // lblNumDoc
            // 
            resources.ApplyResources(this.lblNumDoc, "lblNumDoc");
            this.lblNumDoc.Name = "lblNumDoc";
            // 
            // gbInfoVenta
            // 
            resources.ApplyResources(this.gbInfoVenta, "gbInfoVenta");
            this.gbInfoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoVenta.Controls.Add(this.dtFechaVenta);
            this.gbInfoVenta.Controls.Add(this.lblTipoFac);
            this.gbInfoVenta.Controls.Add(this.lblFecha);
            this.gbInfoVenta.Controls.Add(this.cbTIpoFac);
            this.gbInfoVenta.ForeColor = System.Drawing.Color.Black;
            this.gbInfoVenta.Name = "gbInfoVenta";
            this.gbInfoVenta.TabStop = false;
            // 
            // dtFechaVenta
            // 
            resources.ApplyResources(this.dtFechaVenta, "dtFechaVenta");
            this.dtFechaVenta.Name = "dtFechaVenta";
            // 
            // lblTipoFac
            // 
            resources.ApplyResources(this.lblTipoFac, "lblTipoFac");
            this.lblTipoFac.Name = "lblTipoFac";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.Name = "lblFecha";
            // 
            // cbTIpoFac
            // 
            resources.ApplyResources(this.cbTIpoFac, "cbTIpoFac");
            this.cbTIpoFac.FormattingEnabled = true;
            this.cbTIpoFac.Name = "cbTIpoFac";
            // 
            // lblRegistrarVenta
            // 
            resources.ApplyResources(this.lblRegistrarVenta, "lblRegistrarVenta");
            this.lblRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.lblRegistrarVenta.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrarVenta.Name = "lblRegistrarVenta";
            // 
            // lblPagaCon
            // 
            resources.ApplyResources(this.lblPagaCon, "lblPagaCon");
            this.lblPagaCon.ForeColor = System.Drawing.Color.Black;
            this.lblPagaCon.Name = "lblPagaCon";
            // 
            // txtPagaCon
            // 
            resources.ApplyResources(this.txtPagaCon, "txtPagaCon");
            this.txtPagaCon.Name = "txtPagaCon";
            // 
            // txtCambio
            // 
            resources.ApplyResources(this.txtCambio, "txtCambio");
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            // 
            // lblCambio
            // 
            resources.ApplyResources(this.lblCambio, "lblCambio");
            this.lblCambio.ForeColor = System.Drawing.Color.Black;
            this.lblCambio.Name = "lblCambio";
            // 
            // ibtnRegistrarVenta
            // 
            resources.ApplyResources(this.ibtnRegistrarVenta, "ibtnRegistrarVenta");
            this.ibtnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnRegistrarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.ibtnRegistrarVenta.IconColor = System.Drawing.Color.Aqua;
            this.ibtnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrarVenta.IconSize = 40;
            this.ibtnRegistrarVenta.Name = "ibtnRegistrarVenta";
            this.ibtnRegistrarVenta.UseVisualStyleBackColor = false;
            // 
            // ibtnAgregarVenta
            // 
            resources.ApplyResources(this.ibtnAgregarVenta, "ibtnAgregarVenta");
            this.ibtnAgregarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAgregarVenta.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtnAgregarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnAgregarVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ibtnAgregarVenta.IconColor = System.Drawing.Color.Aqua;
            this.ibtnAgregarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgregarVenta.IconSize = 35;
            this.ibtnAgregarVenta.Name = "ibtnAgregarVenta";
            this.ibtnAgregarVenta.UseVisualStyleBackColor = false;
            // 
            // RegistrarVenta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
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
        private System.Windows.Forms.DateTimePicker dtFechaVenta;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminarPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}