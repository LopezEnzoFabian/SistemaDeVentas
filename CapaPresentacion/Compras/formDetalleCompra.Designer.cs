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
            this.gbInfoProve = new System.Windows.Forms.GroupBox();
            this.txtRazonSoc = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.lblRazonSoc = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblDetalleCompra = new System.Windows.Forms.Label();
            this.ibtnBuscar = new FontAwesome.Sharp.IconButton();
            this.ibtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.lblDocNum = new System.Windows.Forms.Label();
            this.dgDetalleCompra = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ibtnPDFDetalleCompra = new FontAwesome.Sharp.IconButton();
            this.gbInfoProve.SuspendLayout();
            this.gbInfoCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleCompra)).BeginInit();
            this.SuspendLayout();
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
            this.gbInfoProve.Location = new System.Drawing.Point(101, 177);
            this.gbInfoProve.Name = "gbInfoProve";
            this.gbInfoProve.Size = new System.Drawing.Size(562, 83);
            this.gbInfoProve.TabIndex = 4;
            this.gbInfoProve.TabStop = false;
            this.gbInfoProve.Text = "información de proveedor";
            // 
            // txtRazonSoc
            // 
            this.txtRazonSoc.Location = new System.Drawing.Point(195, 46);
            this.txtRazonSoc.Name = "txtRazonSoc";
            this.txtRazonSoc.Size = new System.Drawing.Size(130, 20);
            this.txtRazonSoc.TabIndex = 48;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(9, 47);
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
            this.btnsearch.Location = new System.Drawing.Point(145, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 21);
            this.btnsearch.TabIndex = 46;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // lblRazonSoc
            // 
            this.lblRazonSoc.AutoSize = true;
            this.lblRazonSoc.Location = new System.Drawing.Point(192, 26);
            this.lblRazonSoc.Name = "lblRazonSoc";
            this.lblRazonSoc.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSoc.TabIndex = 1;
            this.lblRazonSoc.Text = "Razon social";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(6, 26);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(100, 13);
            this.lblNumDoc.TabIndex = 0;
            this.lblNumDoc.Text = "Numero documento";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.gbInfoCompra.Controls.Add(this.lblUsuario);
            this.gbInfoCompra.Controls.Add(this.textBox2);
            this.gbInfoCompra.Controls.Add(this.txtUsuario);
            this.gbInfoCompra.Controls.Add(this.lblTipoDoc);
            this.gbInfoCompra.Controls.Add(this.lblFecha);
            this.gbInfoCompra.Controls.Add(this.txtFecha);
            this.gbInfoCompra.ForeColor = System.Drawing.Color.White;
            this.gbInfoCompra.Location = new System.Drawing.Point(101, 96);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(562, 76);
            this.gbInfoCompra.TabIndex = 3;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "información de compra";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(345, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(348, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(192, 26);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDoc.TabIndex = 3;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(9, 42);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(130, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.BackColor = System.Drawing.Color.Black;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCompra.ForeColor = System.Drawing.Color.White;
            this.lblDetalleCompra.Location = new System.Drawing.Point(105, 21);
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(194, 28);
            this.lblDetalleCompra.TabIndex = 5;
            this.lblDetalleCompra.Text = "Detalle de compra";
            // 
            // ibtnBuscar
            // 
            this.ibtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnBuscar.IconColor = System.Drawing.Color.White;
            this.ibtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBuscar.IconSize = 20;
            this.ibtnBuscar.Location = new System.Drawing.Point(513, 60);
            this.ibtnBuscar.Name = "ibtnBuscar";
            this.ibtnBuscar.Size = new System.Drawing.Size(31, 30);
            this.ibtnBuscar.TabIndex = 48;
            this.ibtnBuscar.UseVisualStyleBackColor = false;
            // 
            // ibtnLimpiar
            // 
            this.ibtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnLimpiar.IconColor = System.Drawing.Color.White;
            this.ibtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiar.IconSize = 20;
            this.ibtnLimpiar.Location = new System.Drawing.Point(550, 62);
            this.ibtnLimpiar.Name = "ibtnLimpiar";
            this.ibtnLimpiar.Size = new System.Drawing.Size(39, 28);
            this.ibtnLimpiar.TabIndex = 47;
            this.ibtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtDocNum
            // 
            this.txtDocNum.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocNum.Location = new System.Drawing.Point(368, 64);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(130, 25);
            this.txtDocNum.TabIndex = 46;
            // 
            // lblDocNum
            // 
            this.lblDocNum.AutoSize = true;
            this.lblDocNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDocNum.Location = new System.Drawing.Point(246, 76);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.Size = new System.Drawing.Size(115, 13);
            this.lblDocNum.TabIndex = 49;
            this.lblDocNum.Text = "Numero de documento";
            // 
            // dgDetalleCompra
            // 
            this.dgDetalleCompra.AllowUserToOrderColumns = true;
            this.dgDetalleCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colPrecioCompra,
            this.colCant,
            this.colSubTotal});
            this.dgDetalleCompra.Location = new System.Drawing.Point(101, 266);
            this.dgDetalleCompra.Name = "dgDetalleCompra";
            this.dgDetalleCompra.ReadOnly = true;
            this.dgDetalleCompra.Size = new System.Drawing.Size(562, 138);
            this.dgDetalleCompra.TabIndex = 50;
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
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMontoTotal.Location = new System.Drawing.Point(98, 419);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(64, 13);
            this.lblMontoTotal.TabIndex = 52;
            this.lblMontoTotal.Text = "Monto Total";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 435);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 51;
            this.textBox3.Text = "0";
            // 
            // ibtnPDFDetalleCompra
            // 
            this.ibtnPDFDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPDFDetalleCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.ibtnPDFDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.File;
            this.ibtnPDFDetalleCompra.IconColor = System.Drawing.Color.White;
            this.ibtnPDFDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPDFDetalleCompra.IconSize = 30;
            this.ibtnPDFDetalleCompra.Location = new System.Drawing.Point(540, 419);
            this.ibtnPDFDetalleCompra.Name = "ibtnPDFDetalleCompra";
            this.ibtnPDFDetalleCompra.Size = new System.Drawing.Size(123, 36);
            this.ibtnPDFDetalleCompra.TabIndex = 53;
            this.ibtnPDFDetalleCompra.Text = "descargar PDF";
            this.ibtnPDFDetalleCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPDFDetalleCompra.UseVisualStyleBackColor = true;
            // 
            // formDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(753, 461);
            this.Controls.Add(this.ibtnPDFDetalleCompra);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dgDetalleCompra);
            this.Controls.Add(this.lblDocNum);
            this.Controls.Add(this.ibtnBuscar);
            this.Controls.Add(this.ibtnLimpiar);
            this.Controls.Add(this.txtDocNum);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.gbInfoProve);
            this.Controls.Add(this.gbInfoCompra);
            this.Name = "formDetalleCompra";
            this.Text = "formDetalleCompra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox txtNumDoc;
        private FontAwesome.Sharp.IconButton btnsearch;
        private System.Windows.Forms.Label lblRazonSoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton ibtnBuscar;
        private FontAwesome.Sharp.IconButton ibtnLimpiar;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.Label lblDocNum;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgDetalleCompra;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton ibtnPDFDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}