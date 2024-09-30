namespace CapaPresentacion.Compras
{
    partial class ComprasListarProveedorcs
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
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.btnclean = new FontAwesome.Sharp.IconButton();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgListaProveedores = new System.Windows.Forms.DataGridView();
            this.colSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProveedores)).BeginInit();
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
            this.btnsearch.Location = new System.Drawing.Point(551, 7);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(32, 30);
            this.btnsearch.TabIndex = 87;
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
            this.btnclean.Location = new System.Drawing.Point(588, 9);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(40, 28);
            this.btnclean.TabIndex = 86;
            this.btnclean.UseVisualStyleBackColor = true;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Email",
            "Razon social",
            "telefono",
            "DNI",
            "ciudad",
            "direccion"});
            this.cbFiltro.Location = new System.Drawing.Point(276, 11);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(122, 25);
            this.cbFiltro.TabIndex = 85;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(415, 11);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(122, 25);
            this.txtBuscar.TabIndex = 84;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFiltrar.Location = new System.Drawing.Point(185, 20);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(71, 16);
            this.lblFiltrar.TabIndex = 83;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // dgListaProveedores
            // 
            this.dgListaProveedores.AllowUserToDeleteRows = false;
            this.dgListaProveedores.AllowUserToResizeColumns = false;
            this.dgListaProveedores.AllowUserToResizeRows = false;
            this.dgListaProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgListaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgListaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeleccionar,
            this.colNombre,
            this.colRazonSocial,
            this.colTelefono,
            this.colEmail,
            this.colCiudad,
            this.colDireccion});
            this.dgListaProveedores.Location = new System.Drawing.Point(1, 70);
            this.dgListaProveedores.Name = "dgListaProveedores";
            this.dgListaProveedores.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaProveedores.RowHeadersVisible = false;
            this.dgListaProveedores.Size = new System.Drawing.Size(810, 150);
            this.dgListaProveedores.TabIndex = 82;
            this.dgListaProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgListaProveedores_CellPainting);
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.FillWeight = 35F;
            this.colSeleccionar.HeaderText = "";
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.ReadOnly = true;
            this.colSeleccionar.Width = 30;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "DNI";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 110;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.HeaderText = "Razon social";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.ReadOnly = true;
            this.colRazonSocial.Width = 110;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 109;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 109;
            // 
            // colCiudad
            // 
            this.colCiudad.HeaderText = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.ReadOnly = true;
            this.colCiudad.Width = 109;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Width = 110;
            // 
            // ComprasListarProveedorcs
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
            this.Controls.Add(this.dgListaProveedores);
            this.Name = "ComprasListarProveedorcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnclean;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridView dgListaProveedores;
        private System.Windows.Forms.DataGridViewButtonColumn colSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
    }
}