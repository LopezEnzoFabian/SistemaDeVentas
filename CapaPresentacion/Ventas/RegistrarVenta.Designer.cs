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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.txtPagacon = new System.Windows.Forms.TextBox();
            this.dgRegistrarVenta = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblTipoFac = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbTIpoFac = new System.Windows.Forms.ComboBox();
            this.lblRegistrarCompra = new System.Windows.Forms.Label();
            this.ibtnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistrarVenta)).BeginInit();
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
            this.lblTotalPag.Location = new System.Drawing.Point(533, 346);
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(67, 15);
            this.lblTotalPag.TabIndex = 60;
            this.lblTotalPag.Text = "Paga con";
            // 
            // txtPagacon
            // 
            this.txtPagacon.Location = new System.Drawing.Point(536, 364);
            this.txtPagacon.Multiline = true;
            this.txtPagacon.Name = "txtPagacon";
            this.txtPagacon.Size = new System.Drawing.Size(95, 30);
            this.txtPagacon.TabIndex = 59;
            // 
            // dgRegistrarVenta
            // 
            this.dgRegistrarVenta.AllowUserToDeleteRows = false;
            this.dgRegistrarVenta.AllowUserToResizeColumns = false;
            this.dgRegistrarVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRegistrarVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRegistrarVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgRegistrarVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistrarVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRegistrarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgRegistrarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBorrar,
            this.colProducto,
            this.colCantidad,
            this.colCliente,
            this.colPrecioCompra,
            this.colCodigo,
            this.colSubTotal,
            this.colIdProducto});
            this.dgRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistrarVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRegistrarVenta.EnableHeadersVisualStyles = false;
            this.dgRegistrarVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgRegistrarVenta.Location = new System.Drawing.Point(1, 293);
            this.dgRegistrarVenta.MultiSelect = false;
            this.dgRegistrarVenta.Name = "dgRegistrarVenta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistrarVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgRegistrarVenta.RowHeadersVisible = false;
            this.dgRegistrarVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgRegistrarVenta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgRegistrarVenta.Size = new System.Drawing.Size(514, 233);
            this.dgRegistrarVenta.TabIndex = 57;
            this.dgRegistrarVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgRegistrarVenta_CellPainting);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FillWeight = 35F;
            this.btnBorrar.HeaderText = "";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Width = 30;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 84.5141F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Width = 101;
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 84.5141F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 101;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.FillWeight = 84.5141F;
            this.colPrecioCompra.HeaderText = "Precio Venta";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.Width = 101;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 84.5141F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Width = 101;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "idProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = false;
            this.colIdProducto.Width = 84;
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
            this.gbInfoProducto.Location = new System.Drawing.Point(11, 143);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(639, 85);
            this.gbInfoProducto.TabIndex = 56;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "información de producto";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(546, 32);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(66, 15);
            this.lblCant.TabIndex = 52;
            this.lblCant.Text = "Cantidad";
            // 
            // lblPrecioVen
            // 
            this.lblPrecioVen.AutoSize = true;
            this.lblPrecioVen.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVen.Location = new System.Drawing.Point(446, 32);
            this.lblPrecioVen.Name = "lblPrecioVen";
            this.lblPrecioVen.Size = new System.Drawing.Size(90, 15);
            this.lblPrecioVen.TabIndex = 51;
            this.lblPrecioVen.Text = "Precio venta";
            // 
            // lblPrecioCom
            // 
            this.lblPrecioCom.AutoSize = true;
            this.lblPrecioCom.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCom.Location = new System.Drawing.Point(338, 32);
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
            this.nudCant.Location = new System.Drawing.Point(549, 48);
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
            this.ibtnBuscarProducto.Location = new System.Drawing.Point(301, 48);
            this.ibtnBuscarProducto.Name = "ibtnBuscarProducto";
            this.ibtnBuscarProducto.Size = new System.Drawing.Size(34, 21);
            this.ibtnBuscarProducto.TabIndex = 47;
            this.ibtnBuscarProducto.UseVisualStyleBackColor = false;
            this.ibtnBuscarProducto.Click += new System.EventHandler(this.ibtnBuscarProducto_Click);
            // 
            // txtPrecioVen
            // 
            this.txtPrecioVen.Location = new System.Drawing.Point(449, 48);
            this.txtPrecioVen.Name = "txtPrecioVen";
            this.txtPrecioVen.ReadOnly = true;
            this.txtPrecioVen.Size = new System.Drawing.Size(87, 21);
            this.txtPrecioVen.TabIndex = 5;
            // 
            // txtPrecioCom
            // 
            this.txtPrecioCom.Location = new System.Drawing.Point(341, 48);
            this.txtPrecioCom.Name = "txtPrecioCom";
            this.txtPrecioCom.ReadOnly = true;
            this.txtPrecioCom.Size = new System.Drawing.Size(98, 21);
            this.txtPrecioCom.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(157, 48);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(138, 21);
            this.txtProducto.TabIndex = 3;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(11, 48);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ReadOnly = true;
            this.txtCodProd.Size = new System.Drawing.Size(134, 21);
            this.txtCodProd.TabIndex = 2;
            // 
            // gbInfoProve
            // 
            this.gbInfoProve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.gbInfoProve.Controls.Add(this.txtNombre);
            this.gbInfoProve.Controls.Add(this.lblNombre);
            this.gbInfoProve.Controls.Add(this.btnBuscarCliente);
            this.gbInfoProve.Controls.Add(this.txtDNI);
            this.gbInfoProve.Controls.Add(this.lblDNI);
            this.gbInfoProve.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProve.ForeColor = System.Drawing.Color.Black;
            this.gbInfoProve.Location = new System.Drawing.Point(330, 48);
            this.gbInfoProve.Name = "gbInfoProve";
            this.gbInfoProve.Size = new System.Drawing.Size(320, 89);
            this.gbInfoProve.TabIndex = 55;
            this.gbInfoProve.TabStop = false;
            this.gbInfoProve.Text = "información de cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(146, 21);
            this.txtNombre.TabIndex = 50;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(127, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Text = "Nombre";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.Aqua;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 20;
            this.btnBuscarCliente.Location = new System.Drawing.Point(283, 51);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(31, 20);
            this.btnBuscarCliente.TabIndex = 46;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(6, 51);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(118, 21);
            this.txtDNI.TabIndex = 48;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(6, 33);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 15);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "Dni";
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
            this.gbInfoCompra.Location = new System.Drawing.Point(11, 48);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(312, 89);
            this.gbInfoCompra.TabIndex = 54;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "información de venta";
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
            "Factura B",
            "Factura C"});
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
            this.lblRegistrarCompra.Location = new System.Drawing.Point(11, 17);
            this.lblRegistrarCompra.Name = "lblRegistrarCompra";
            this.lblRegistrarCompra.Size = new System.Drawing.Size(182, 28);
            this.lblRegistrarCompra.TabIndex = 53;
            this.lblRegistrarCompra.Text = "Registrar Venta";
            // 
            // ibtnRegistrarVenta
            // 
            this.ibtnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnRegistrarVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegistrarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.ibtnRegistrarVenta.IconColor = System.Drawing.Color.Aqua;
            this.ibtnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrarVenta.IconSize = 40;
            this.ibtnRegistrarVenta.Location = new System.Drawing.Point(543, 460);
            this.ibtnRegistrarVenta.Name = "ibtnRegistrarVenta";
            this.ibtnRegistrarVenta.Size = new System.Drawing.Size(80, 56);
            this.ibtnRegistrarVenta.TabIndex = 52;
            this.ibtnRegistrarVenta.Text = "Registrar";
            this.ibtnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnRegistrarVenta.UseVisualStyleBackColor = false;
            this.ibtnRegistrarVenta.Click += new System.EventHandler(this.ibtnRegistrarVenta_Click);
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
            this.ibtnAgregar.Location = new System.Drawing.Point(298, 234);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(75, 53);
            this.ibtnAgregar.TabIndex = 58;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnAgregar.UseVisualStyleBackColor = false;
            this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(527, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Total a pagar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 30);
            this.textBox1.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(533, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(536, 415);
            this.txtCambio.Multiline = true;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(95, 30);
            this.txtCambio.TabIndex = 63;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotalPag);
            this.Controls.Add(this.txtPagacon);
            this.Controls.Add(this.ibtnRegistrarVenta);
            this.Controls.Add(this.ibtnAgregar);
            this.Controls.Add(this.dgRegistrarVenta);
            this.Controls.Add(this.gbInfoProducto);
            this.Controls.Add(this.gbInfoProve);
            this.Controls.Add(this.gbInfoCompra);
            this.Controls.Add(this.lblRegistrarCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarVenta";
            this.Text = "RegistrarVenta";
            this.Load += new System.EventHandler(this.RegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistrarVenta)).EndInit();
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
        private System.Windows.Forms.TextBox txtPagacon;
        private FontAwesome.Sharp.IconButton ibtnRegistrarVenta;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private System.Windows.Forms.DataGridView dgRegistrarVenta;
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.Label lblTipoFac;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cbTIpoFac;
        private System.Windows.Forms.Label lblRegistrarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
    }
}