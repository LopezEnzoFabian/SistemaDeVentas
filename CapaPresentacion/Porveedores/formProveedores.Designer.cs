﻿namespace CapaPresentacion
{
    partial class formProveedores
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
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblListaPorveedor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgListarUsuario = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtRazonS = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblRazonS = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIdPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSolcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.White;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(513, 7);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 30);
            this.btnsearch.TabIndex = 70;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // btnclean
            // 
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnclean.IconColor = System.Drawing.Color.White;
            this.btnclean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclean.IconSize = 20;
            this.btnclean.Location = new System.Drawing.Point(550, 9);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(39, 28);
            this.btnclean.TabIndex = 69;
            this.btnclean.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(612, 84);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(612, 130);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(612, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 20);
            this.txtID.TabIndex = 64;
            this.txtID.Visible = false;
            // 
            // lblListaPorveedor
            // 
            this.lblListaPorveedor.AutoEllipsis = true;
            this.lblListaPorveedor.BackColor = System.Drawing.SystemColors.Window;
            this.lblListaPorveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListaPorveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPorveedor.Location = new System.Drawing.Point(28, 224);
            this.lblListaPorveedor.Name = "lblListaPorveedor";
            this.lblListaPorveedor.Size = new System.Drawing.Size(190, 28);
            this.lblListaPorveedor.TabIndex = 63;
            this.lblListaPorveedor.Text = "Lista de proveedores";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstado.Location = new System.Drawing.Point(398, 81);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.TabIndex = 61;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(401, 101);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(131, 25);
            this.cbEstado.TabIndex = 60;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(238, 11);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 25);
            this.cbFiltro.TabIndex = 59;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(377, 11);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 25);
            this.txtBuscar.TabIndex = 58;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFiltrar.Location = new System.Drawing.Point(152, 15);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(66, 17);
            this.lblFiltrar.TabIndex = 57;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // dgListarUsuario
            // 
            this.dgListarUsuario.AllowUserToOrderColumns = true;
            this.dgListarUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.colIdPro,
            this.colDNI,
            this.colRazonSolcial,
            this.colEmail,
            this.colTel,
            this.colEstado,
            this.colEstadoValor});
            this.dgListarUsuario.Location = new System.Drawing.Point(12, 255);
            this.dgListarUsuario.Name = "dgListarUsuario";
            this.dgListarUsuario.ReadOnly = true;
            this.dgListarUsuario.Size = new System.Drawing.Size(749, 238);
            this.dgListarUsuario.TabIndex = 56;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(238, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 25);
            this.txtEmail.TabIndex = 53;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(75, 81);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(131, 25);
            this.txtDNI.TabIndex = 50;
            // 
            // txtRazonS
            // 
            this.txtRazonS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonS.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonS.Location = new System.Drawing.Point(75, 130);
            this.txtRazonS.Name = "txtRazonS";
            this.txtRazonS.Size = new System.Drawing.Size(131, 25);
            this.txtRazonS.TabIndex = 49;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(235, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDNI.Location = new System.Drawing.Point(72, 61);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(30, 17);
            this.lblDNI.TabIndex = 47;
            this.lblDNI.Text = "DNI";
            // 
            // lblRazonS
            // 
            this.lblRazonS.AutoSize = true;
            this.lblRazonS.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRazonS.Location = new System.Drawing.Point(72, 110);
            this.lblRazonS.Name = "lblRazonS";
            this.lblRazonS.Size = new System.Drawing.Size(81, 17);
            this.lblRazonS.TabIndex = 46;
            this.lblRazonS.Text = "Razon social";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(238, 81);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(131, 25);
            this.txtTel.TabIndex = 72;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTel.Location = new System.Drawing.Point(235, 61);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(59, 17);
            this.lblTel.TabIndex = 71;
            this.lblTel.Text = "Telefono";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 57.2977F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 68;
            // 
            // colIdPro
            // 
            this.colIdPro.HeaderText = "id proveedor";
            this.colIdPro.Name = "colIdPro";
            this.colIdPro.ReadOnly = true;
            this.colIdPro.Visible = false;
            this.colIdPro.Width = 84;
            // 
            // colDNI
            // 
            this.colDNI.FillWeight = 84.5141F;
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.Width = 101;
            // 
            // colRazonSolcial
            // 
            this.colRazonSolcial.FillWeight = 84.5141F;
            this.colRazonSolcial.HeaderText = "Razon Social";
            this.colRazonSolcial.Name = "colRazonSolcial";
            this.colRazonSolcial.ReadOnly = true;
            this.colRazonSolcial.Width = 101;
            // 
            // colEmail
            // 
            this.colEmail.FillWeight = 84.5141F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 101;
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Telefono";
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            this.colTel.Visible = false;
            this.colTel.Width = 96;
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 84.5141F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 101;
            // 
            // colEstadoValor
            // 
            this.colEstadoValor.FillWeight = 84.5141F;
            this.colEstadoValor.HeaderText = "EstadoValor";
            this.colEstadoValor.Name = "colEstadoValor";
            this.colEstadoValor.ReadOnly = true;
            this.colEstadoValor.Visible = false;
            this.colEstadoValor.Width = 101;
            // 
            // formProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(773, 500);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblListaPorveedor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.dgListarUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtRazonS);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblRazonS);
            this.Name = "formProveedores";
            this.Text = "formProveedores";
            this.Load += new System.EventHandler(this.formProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnclean;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblListaPorveedor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridView dgListarUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtRazonS;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblRazonS;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSolcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoValor;
    }
}