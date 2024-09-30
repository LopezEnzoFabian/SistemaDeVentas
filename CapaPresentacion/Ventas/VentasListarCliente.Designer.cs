namespace CapaPresentacion.Ventas
{
    partial class VentasListarCliente
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
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.colSleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.btnclean = new FontAwesome.Sharp.IconButton();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.AllowUserToDeleteRows = false;
            this.dgListaClientes.AllowUserToResizeColumns = false;
            this.dgListaClientes.AllowUserToResizeRows = false;
            this.dgListaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSleccionar,
            this.colNombreCompleto,
            this.colDNI,
            this.col,
            this.colTelefono,
            this.colDomicilio,
            this.colCiudad,
            this.colLocalidad});
            this.dgListaClientes.Location = new System.Drawing.Point(0, 76);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.RowHeadersVisible = false;
            this.dgListaClientes.Size = new System.Drawing.Size(810, 150);
            this.dgListaClientes.TabIndex = 0;
            this.dgListaClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgListaClientes_CellPainting);
            // 
            // colSleccionar
            // 
            this.colSleccionar.FillWeight = 35F;
            this.colSleccionar.HeaderText = "";
            this.colSleccionar.Name = "colSleccionar";
            this.colSleccionar.Width = 30;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.FillWeight = 89.65737F;
            this.colNombreCompleto.HeaderText = "Nombre completo";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.Width = 150;
            // 
            // colDNI
            // 
            this.colDNI.FillWeight = 89.65737F;
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            // 
            // col
            // 
            this.col.FillWeight = 89.65737F;
            this.col.HeaderText = "Email";
            this.col.Name = "col";
            this.col.Width = 76;
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 89.65737F;
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colDomicilio
            // 
            this.colDomicilio.FillWeight = 89.65737F;
            this.colDomicilio.HeaderText = "Domicilio";
            this.colDomicilio.Name = "colDomicilio";
            // 
            // colCiudad
            // 
            this.colCiudad.FillWeight = 89.65737F;
            this.colCiudad.HeaderText = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            // 
            // colLocalidad
            // 
            this.colLocalidad.FillWeight = 89.65737F;
            this.colLocalidad.HeaderText = "Localidad";
            this.colLocalidad.Name = "colLocalidad";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.Aqua;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(550, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(32, 30);
            this.btnsearch.TabIndex = 75;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclean
            // 
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnclean.IconColor = System.Drawing.Color.Aqua;
            this.btnclean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclean.IconSize = 20;
            this.btnclean.Location = new System.Drawing.Point(587, 15);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(40, 28);
            this.btnclean.TabIndex = 74;
            this.btnclean.UseVisualStyleBackColor = true;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "DNI",
            "Nombre",
            "Email",
            "Estado"});
            this.cbFiltro.Location = new System.Drawing.Point(275, 17);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(122, 25);
            this.cbFiltro.TabIndex = 73;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(414, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(122, 25);
            this.txtBuscar.TabIndex = 72;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFiltrar.Location = new System.Drawing.Point(189, 21);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(71, 16);
            this.lblFiltrar.TabIndex = 71;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // VentasListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(813, 226);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.dgListaClientes);
            this.Name = "VentasListarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaClientes;
        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnclean;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridViewButtonColumn colSleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalidad;
    }
}