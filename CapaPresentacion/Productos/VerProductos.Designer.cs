﻿namespace CapaPresentacion.Productos
{
    partial class VerProductos
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
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.colNombreDeProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListaProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.Aqua;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(461, 22);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(32, 30);
            this.btnsearch.TabIndex = 87;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnclean.IconColor = System.Drawing.Color.Aqua;
            this.btnclean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclean.IconSize = 20;
            this.btnclean.Location = new System.Drawing.Point(498, 24);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(40, 28);
            this.btnclean.TabIndex = 86;
            this.btnclean.UseVisualStyleBackColor = false;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nombre de producto",
            "Codigo",
            "Categoria",
            "Descripcion",
            ""});
            this.cbFiltro.Location = new System.Drawing.Point(177, 26);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(142, 25);
            this.cbFiltro.TabIndex = 85;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(325, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(122, 25);
            this.txtBuscar.TabIndex = 84;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.Color.Black;
            this.lblFiltrar.Location = new System.Drawing.Point(100, 30);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(71, 16);
            this.lblFiltrar.TabIndex = 83;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.AllowUserToDeleteRows = false;
            this.dgListaClientes.AllowUserToOrderColumns = true;
            this.dgListaClientes.AllowUserToResizeColumns = false;
            this.dgListaClientes.AllowUserToResizeRows = false;
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreDeProducto,
            this.colIdCategoria,
            this.colCodigo,
            this.colDescripcion,
            this.colPrecioVenta,
            this.colStock});
            this.dgListaClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgListaClientes.Location = new System.Drawing.Point(12, 109);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.RowHeadersVisible = false;
            this.dgListaClientes.Size = new System.Drawing.Size(622, 399);
            this.dgListaClientes.TabIndex = 82;
            this.dgListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaClientes_CellContentClick);
            // 
            // colNombreDeProducto
            // 
            this.colNombreDeProducto.FillWeight = 150F;
            this.colNombreDeProducto.HeaderText = "Nombre de producto";
            this.colNombreDeProducto.Name = "colNombreDeProducto";
            this.colNombreDeProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNombreDeProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNombreDeProducto.Width = 150;
            // 
            // colIdCategoria
            // 
            this.colIdCategoria.FillWeight = 28.62944F;
            this.colIdCategoria.HeaderText = "Categoria";
            this.colIdCategoria.Name = "colIdCategoria";
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 28.62944F;
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCodigo.Width = 50;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FillWeight = 28.62944F;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 150;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.FillWeight = 28.62944F;
            this.colPrecioVenta.HeaderText = "Precio venta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.Width = 80;
            // 
            // colStock
            // 
            this.colStock.FillWeight = 28.62944F;
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Width = 50;
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProductos.ForeColor = System.Drawing.Color.Black;
            this.lblListaProductos.Location = new System.Drawing.Point(12, 73);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(205, 24);
            this.lblListaProductos.TabIndex = 88;
            this.lblListaProductos.Text = "Lista de productos";
            // 
            // VerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(643, 520);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.dgListaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerProductos";
            this.Text = "VerProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnclean;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}