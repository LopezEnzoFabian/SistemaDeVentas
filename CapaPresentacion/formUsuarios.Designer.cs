﻿namespace CapaPresentacion
{
    partial class formUsuarios
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblConfContra = new System.Windows.Forms.Label();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnclean = new FontAwesome.Sharp.IconButton();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgListarUsuario = new System.Windows.Forms.DataGridView();
            this.Tbt_pass = new RoundedTextBox();
            this.Tbt_confirmpass = new RoundedTextBox();
            this.Tbt_email = new RoundedTextBox();
            this.Tbt_Nombre = new RoundedTextBox();
            this.roundedButton1 = new RoundedButton();
            this.txtDNI = new RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(10, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDNI.Location = new System.Drawing.Point(13, 76);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 16);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(13, 102);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContra.Location = new System.Drawing.Point(13, 132);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(74, 16);
            this.lblContra.TabIndex = 14;
            this.lblContra.Text = "Contraseña";
            // 
            // lblConfContra
            // 
            this.lblConfContra.AutoSize = true;
            this.lblConfContra.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfContra.Location = new System.Drawing.Point(10, 160);
            this.lblConfContra.Name = "lblConfContra";
            this.lblConfContra.Size = new System.Drawing.Size(134, 16);
            this.lblConfContra.TabIndex = 16;
            this.lblConfContra.Text = "Confirmar contraseña";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.White;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(525, 8);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 30);
            this.btnsearch.TabIndex = 45;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(164, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Filtrar por";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscar.Location = new System.Drawing.Point(389, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 23);
            this.txtBuscar.TabIndex = 31;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nombre",
            "DNI",
            "Rol",
            "Estado",
            "Email"});
            this.cbFiltro.Location = new System.Drawing.Point(250, 12);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cbFiltro.TabIndex = 33;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(439, 98);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(162, 24);
            this.cbEstado.TabIndex = 34;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(386, 101);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 16);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRol.Location = new System.Drawing.Point(386, 50);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 16);
            this.lblRol.TabIndex = 36;
            this.lblRol.Text = "Rol";
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoEllipsis = true;
            this.lblListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaUsuarios.Location = new System.Drawing.Point(13, 237);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(160, 28);
            this.lblListaUsuarios.TabIndex = 38;
            this.lblListaUsuarios.Text = "Lista de usuarios";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtID.Location = new System.Drawing.Point(83, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 23);
            this.txtID.TabIndex = 39;
            this.txtID.Visible = false;
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador",
            "Supervisor"});
            this.cbRol.Location = new System.Drawing.Point(418, 47);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(183, 24);
            this.cbRol.TabIndex = 40;
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(586, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(586, 206);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(586, 166);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnclean
            // 
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclean.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnclean.IconColor = System.Drawing.Color.White;
            this.btnclean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclean.IconSize = 20;
            this.btnclean.Location = new System.Drawing.Point(562, 10);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(39, 28);
            this.btnclean.TabIndex = 44;
            this.btnclean.UseVisualStyleBackColor = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.FillWeight = 84.5141F;
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 84.5141F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // colRol
            // 
            this.colRol.FillWeight = 84.5141F;
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 84.5141F;
            this.colNombre.HeaderText = "Nombre completo";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colContraseña
            // 
            this.colContraseña.HeaderText = "Contraseña";
            this.colContraseña.Name = "colContraseña";
            this.colContraseña.ReadOnly = true;
            this.colContraseña.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.FillWeight = 84.5141F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colDNI
            // 
            this.colDNI.FillWeight = 84.5141F;
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "id Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            this.colUsuario.Visible = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 57.2977F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            // 
            // dgListarUsuario
            // 
            this.dgListarUsuario.AllowUserToOrderColumns = true;
            this.dgListarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListarUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListarUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.colUsuario,
            this.colDNI,
            this.colEmail,
            this.colContraseña,
            this.colNombre,
            this.idRol,
            this.colRol,
            this.Estado,
            this.EstadoValor});
            this.dgListarUsuario.Location = new System.Drawing.Point(13, 268);
            this.dgListarUsuario.Name = "dgListarUsuario";
            this.dgListarUsuario.ReadOnly = true;
            this.dgListarUsuario.Size = new System.Drawing.Size(717, 212);
            this.dgListarUsuario.TabIndex = 28;
            this.dgListarUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarUsuario_CellContentClick);
            // 
            // Tbt_pass
            // 
            this.Tbt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbt_pass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbt_pass.Location = new System.Drawing.Point(142, 132);
            this.Tbt_pass.Name = "Tbt_pass";
            this.Tbt_pass.Size = new System.Drawing.Size(195, 20);
            this.Tbt_pass.TabIndex = 51;
            // 
            // Tbt_confirmpass
            // 
            this.Tbt_confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbt_confirmpass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbt_confirmpass.Location = new System.Drawing.Point(142, 158);
            this.Tbt_confirmpass.Name = "Tbt_confirmpass";
            this.Tbt_confirmpass.Size = new System.Drawing.Size(195, 20);
            this.Tbt_confirmpass.TabIndex = 50;
            // 
            // Tbt_email
            // 
            this.Tbt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbt_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbt_email.Location = new System.Drawing.Point(70, 102);
            this.Tbt_email.Name = "Tbt_email";
            this.Tbt_email.Size = new System.Drawing.Size(267, 20);
            this.Tbt_email.TabIndex = 49;
            // 
            // Tbt_Nombre
            // 
            this.Tbt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbt_Nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbt_Nombre.Location = new System.Drawing.Point(70, 46);
            this.Tbt_Nombre.Name = "Tbt_Nombre";
            this.Tbt_Nombre.Size = new System.Drawing.Size(267, 20);
            this.Tbt_Nombre.TabIndex = 48;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.roundedButton1.BorderRadius = 16;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundedButton1.Icon = null;
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.roundedButton1.Location = new System.Drawing.Point(624, 16);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(86, 29);
            this.roundedButton1.TabIndex = 47;
            this.roundedButton1.Text = "Agregar";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDNI.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDNI.Location = new System.Drawing.Point(70, 72);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(267, 20);
            this.txtDNI.TabIndex = 46;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // formUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(742, 490);
            this.Controls.Add(this.Tbt_pass);
            this.Controls.Add(this.Tbt_confirmpass);
            this.Controls.Add(this.Tbt_email);
            this.Controls.Add(this.Tbt_Nombre);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgListarUsuario);
            this.Controls.Add(this.lblConfContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.formUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblConfContra;
        private FontAwesome.Sharp.IconButton btnsearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbRol;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnclean;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridView dgListarUsuario;
        private RoundedTextBox txtDNI;
        private RoundedButton roundedButton1;
        private RoundedTextBox Tbt_Nombre;
        private RoundedTextBox Tbt_email;
        private RoundedTextBox Tbt_confirmpass;
        private RoundedTextBox Tbt_pass;
    }
}