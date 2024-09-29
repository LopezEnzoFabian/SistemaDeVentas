namespace CapaPresentacion.Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.dgRegistrarCompra = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.lblCodProd = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.ibtnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtPrecioVen = new System.Windows.Forms.TextBox();
            this.txtPrecioCom = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.gbInfoProve = new System.Windows.Forms.GroupBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.txtRazonSoc = new System.Windows.Forms.TextBox();
            this.lblRazonSoc = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblTipoFac = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbTIpoFac = new System.Windows.Forms.ComboBox();
            this.lblRegistrarCompra = new System.Windows.Forms.Label();
            this.ibtnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistrarCompra)).BeginInit();
            this.gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.gbInfoProve.SuspendLayout();
            this.gbInfoCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPag.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPag.Location = new System.Drawing.Point(528, 285);
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(96, 15);
            this.lblTotalPag.TabIndex = 51;
            this.lblTotalPag.Text = "Total a pagar";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(531, 303);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(79, 20);
            this.txtTotalPagar.TabIndex = 50;
            // 
            // dgRegistrarCompra
            // 
            this.dgRegistrarCompra.AllowUserToDeleteRows = false;
            this.dgRegistrarCompra.AllowUserToResizeColumns = false;
            this.dgRegistrarCompra.AllowUserToResizeRows = false;
            this.dgRegistrarCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgRegistrarCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRegistrarCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgRegistrarCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBorrar,
            this.colIdProducto,
            this.colProducto,
            this.colPrecioCompra,
            this.colCPrecioVenta,
            this.colCantidad,
            this.colSubTotal});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistrarCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgRegistrarCompra.EnableHeadersVisualStyles = false;
            this.dgRegistrarCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgRegistrarCompra.Location = new System.Drawing.Point(4, 285);
            this.dgRegistrarCompra.MultiSelect = false;
            this.dgRegistrarCompra.Name = "dgRegistrarCompra";
            this.dgRegistrarCompra.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistrarCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRegistrarCompra.RowHeadersVisible = false;
            this.dgRegistrarCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgRegistrarCompra.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRegistrarCompra.Size = new System.Drawing.Size(514, 171);
            this.dgRegistrarCompra.TabIndex = 47;
            this.dgRegistrarCompra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgRegistrarCompra_CellPainting);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FillWeight = 35F;
            this.btnBorrar.HeaderText = "";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.ReadOnly = true;
            this.btnBorrar.Width = 40;
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
            // gbInfoProducto
            // 
            this.gbInfoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoProducto.Controls.Add(this.lblCant);
            this.gbInfoProducto.Controls.Add(this.lblPrecioVen);
            this.gbInfoProducto.Controls.Add(this.lblPrecioCom);
            this.gbInfoProducto.Controls.Add(this.lblProducto);
            this.gbInfoProducto.Controls.Add(this.lblCodProd);
            this.gbInfoProducto.Controls.Add(this.nudCant);
            this.gbInfoProducto.Controls.Add(this.ibtnBuscarProducto);
            this.gbInfoProducto.Controls.Add(this.txtPrecioVen);
            this.gbInfoProducto.Controls.Add(this.txtPrecioCom);
            this.gbInfoProducto.Controls.Add(this.txtProducto);
            this.gbInfoProducto.Controls.Add(this.txtCodProd);
            this.gbInfoProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.ForeColor = System.Drawing.Color.Black;
            this.gbInfoProducto.Location = new System.Drawing.Point(12, 135);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(612, 85);
            this.gbInfoProducto.TabIndex = 46;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "información de producto";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(529, 32);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(66, 15);
            this.lblCant.TabIndex = 52;
            this.lblCant.Text = "Cantidad";
            // 
            // lblPrecioVen
            // 
            this.lblPrecioVen.AutoSize = true;
            this.lblPrecioVen.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVen.Location = new System.Drawing.Point(437, 32);
            this.lblPrecioVen.Name = "lblPrecioVen";
            this.lblPrecioVen.Size = new System.Drawing.Size(90, 15);
            this.lblPrecioVen.TabIndex = 51;
            this.lblPrecioVen.Text = "Precio venta";
            // 
            // lblPrecioCom
            // 
            this.lblPrecioCom.AutoSize = true;
            this.lblPrecioCom.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCom.Location = new System.Drawing.Point(333, 32);
            this.lblPrecioCom.Name = "lblPrecioCom";
            this.lblPrecioCom.Size = new System.Drawing.Size(102, 15);
            this.lblPrecioCom.TabIndex = 50;
            this.lblPrecioCom.Text = "Precio compra";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(154, 32);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(65, 15);
            this.lblProducto.TabIndex = 49;
            this.lblProducto.Text = "Producto";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(8, 32);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(137, 15);
            this.lblCodProd.TabIndex = 48;
            this.lblCodProd.Text = "Codigo de producto";
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(532, 48);
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
            this.nudCant.Size = new System.Drawing.Size(80, 21);
            this.nudCant.TabIndex = 4;
            this.nudCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ibtnBuscarProducto
            // 
            this.ibtnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.ibtnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscarProducto.IconColor = System.Drawing.Color.Aqua;
            this.ibtnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscarProducto.IconSize = 20;
            this.ibtnBuscarProducto.Location = new System.Drawing.Point(287, 49);
            this.ibtnBuscarProducto.Name = "ibtnBuscarProducto";
            this.ibtnBuscarProducto.Size = new System.Drawing.Size(34, 21);
            this.ibtnBuscarProducto.TabIndex = 47;
            this.ibtnBuscarProducto.UseVisualStyleBackColor = false;
            this.ibtnBuscarProducto.Click += new System.EventHandler(this.ibtnBuscarProducto_Click);
            // 
            // txtPrecioVen
            // 
            this.txtPrecioVen.Location = new System.Drawing.Point(440, 48);
            this.txtPrecioVen.Name = "txtPrecioVen";
            this.txtPrecioVen.Size = new System.Drawing.Size(87, 21);
            this.txtPrecioVen.TabIndex = 5;
            this.txtPrecioVen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVen_KeyPress);
            // 
            // txtPrecioCom
            // 
            this.txtPrecioCom.Location = new System.Drawing.Point(336, 48);
            this.txtPrecioCom.Name = "txtPrecioCom";
            this.txtPrecioCom.Size = new System.Drawing.Size(98, 21);
            this.txtPrecioCom.TabIndex = 4;
            this.txtPrecioCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCom_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(157, 48);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(124, 21);
            this.txtProducto.TabIndex = 3;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(11, 48);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ReadOnly = true;
            this.txtCodProd.Size = new System.Drawing.Size(128, 21);
            this.txtCodProd.TabIndex = 2;
            // 
            // gbInfoProve
            // 
            this.gbInfoProve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoProve.Controls.Add(this.txtNumDoc);
            this.gbInfoProve.Controls.Add(this.lblNumDoc);
            this.gbInfoProve.Controls.Add(this.btnBuscarProveedor);
            this.gbInfoProve.Controls.Add(this.txtRazonSoc);
            this.gbInfoProve.Controls.Add(this.lblRazonSoc);
            this.gbInfoProve.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProve.ForeColor = System.Drawing.Color.Black;
            this.gbInfoProve.Location = new System.Drawing.Point(331, 40);
            this.gbInfoProve.Name = "gbInfoProve";
            this.gbInfoProve.Size = new System.Drawing.Size(293, 89);
            this.gbInfoProve.TabIndex = 45;
            this.gbInfoProve.TabStop = false;
            this.gbInfoProve.Text = "información de proveedor";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(130, 51);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.ReadOnly = true;
            this.txtNumDoc.Size = new System.Drawing.Size(115, 21);
            this.txtNumDoc.TabIndex = 50;
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoc.Location = new System.Drawing.Point(127, 33);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(156, 15);
            this.lblNumDoc.TabIndex = 49;
            this.lblNumDoc.Text = "Numero de documento";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.Aqua;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 20;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(255, 51);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(31, 20);
            this.btnBuscarProveedor.TabIndex = 46;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtRazonSoc
            // 
            this.txtRazonSoc.Location = new System.Drawing.Point(6, 51);
            this.txtRazonSoc.Name = "txtRazonSoc";
            this.txtRazonSoc.ReadOnly = true;
            this.txtRazonSoc.Size = new System.Drawing.Size(118, 21);
            this.txtRazonSoc.TabIndex = 48;
            // 
            // lblRazonSoc
            // 
            this.lblRazonSoc.AutoSize = true;
            this.lblRazonSoc.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSoc.Location = new System.Drawing.Point(6, 33);
            this.lblRazonSoc.Name = "lblRazonSoc";
            this.lblRazonSoc.Size = new System.Drawing.Size(90, 15);
            this.lblRazonSoc.TabIndex = 1;
            this.lblRazonSoc.Text = "Razon social";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoCompra.Controls.Add(this.dtFechaCompra);
            this.gbInfoCompra.Controls.Add(this.lblTipoFac);
            this.gbInfoCompra.Controls.Add(this.lblFecha);
            this.gbInfoCompra.Controls.Add(this.cbTIpoFac);
            this.gbInfoCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.ForeColor = System.Drawing.Color.Black;
            this.gbInfoCompra.Location = new System.Drawing.Point(12, 40);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(312, 89);
            this.gbInfoCompra.TabIndex = 44;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "información de compra";
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Location = new System.Drawing.Point(8, 56);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(137, 21);
            this.dtFechaCompra.TabIndex = 4;
            // 
            // lblTipoFac
            // 
            this.lblTipoFac.AutoSize = true;
            this.lblTipoFac.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFac.Location = new System.Drawing.Point(154, 33);
            this.lblTipoFac.Name = "lblTipoFac";
            this.lblTipoFac.Size = new System.Drawing.Size(108, 15);
            this.lblTipoFac.TabIndex = 3;
            this.lblTipoFac.Text = "Tipo de factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(6, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // cbTIpoFac
            // 
            this.cbTIpoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTIpoFac.FormattingEnabled = true;
            this.cbTIpoFac.Items.AddRange(new object[] {
            "Factura A",
            "Factura B"});
            this.cbTIpoFac.Location = new System.Drawing.Point(157, 54);
            this.cbTIpoFac.Name = "cbTIpoFac";
            this.cbTIpoFac.Size = new System.Drawing.Size(143, 23);
            this.cbTIpoFac.TabIndex = 0;
            // 
            // lblRegistrarCompra
            // 
            this.lblRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.lblRegistrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarCompra.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrarCompra.Location = new System.Drawing.Point(12, 9);
            this.lblRegistrarCompra.Name = "lblRegistrarCompra";
            this.lblRegistrarCompra.Size = new System.Drawing.Size(182, 28);
            this.lblRegistrarCompra.TabIndex = 43;
            this.lblRegistrarCompra.Text = "Registrar Compra";
            // 
            // ibtnRegistrarCompra
            // 
            this.ibtnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnRegistrarCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegistrarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.ibtnRegistrarCompra.IconColor = System.Drawing.Color.Aqua;
            this.ibtnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrarCompra.IconSize = 40;
            this.ibtnRegistrarCompra.Location = new System.Drawing.Point(537, 355);
            this.ibtnRegistrarCompra.Name = "ibtnRegistrarCompra";
            this.ibtnRegistrarCompra.Size = new System.Drawing.Size(80, 65);
            this.ibtnRegistrarCompra.TabIndex = 40;
            this.ibtnRegistrarCompra.Text = "Registrar";
            this.ibtnRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnRegistrarCompra.UseVisualStyleBackColor = false;
            this.ibtnRegistrarCompra.Click += new System.EventHandler(this.ibtnRegistrarCompra_Click);
            // 
            // ibtnAgregar
            // 
            this.ibtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ibtnAgregar.IconColor = System.Drawing.Color.Aqua;
            this.ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgregar.IconSize = 35;
            this.ibtnAgregar.Location = new System.Drawing.Point(299, 226);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(75, 53);
            this.ibtnAgregar.TabIndex = 48;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnAgregar.UseVisualStyleBackColor = false;
            this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
            // 
            // formRegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.lblTotalPag);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.ibtnRegistrarCompra);
            this.Controls.Add(this.ibtnAgregar);
            this.Controls.Add(this.dgRegistrarCompra);
            this.Controls.Add(this.gbInfoProducto);
            this.Controls.Add(this.gbInfoProve);
            this.Controls.Add(this.gbInfoCompra);
            this.Controls.Add(this.lblRegistrarCompra);
            this.Name = "formRegistrarCompra";
            this.Text = "Registrar Compra";
            this.Load += new System.EventHandler(this.formRegistrarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistrarCompra)).EndInit();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.gbInfoProve.ResumeLayout(false);
            this.gbInfoProve.PerformLayout();
            this.gbInfoCompra.ResumeLayout(false);
            this.gbInfoCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPag;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private FontAwesome.Sharp.IconButton ibtnRegistrarCompra;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private System.Windows.Forms.DataGridView dgRegistrarCompra;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPrecioVen;
        private System.Windows.Forms.Label lblPrecioCom;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.NumericUpDown nudCant;
        private FontAwesome.Sharp.IconButton ibtnBuscarProducto;
        private System.Windows.Forms.TextBox txtPrecioVen;
        private System.Windows.Forms.TextBox txtPrecioCom;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.GroupBox gbInfoProve;
        private System.Windows.Forms.TextBox txtRazonSoc;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.Label lblRazonSoc;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.Label lblTipoFac;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cbTIpoFac;
        private System.Windows.Forms.Label lblRegistrarCompra;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}