﻿namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUSER = new System.Windows.Forms.Label();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.barraDeMenus = new System.Windows.Forms.MenuStrip();
            this.menuProductosVer = new FontAwesome.Sharp.IconMenuItem();
            this.menuEstadisticas = new FontAwesome.Sharp.IconMenuItem();
            this.menuBackup = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraDeMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contenedor.Location = new System.Drawing.Point(172, 31);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(662, 578);
            this.contenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ibtnSalir.IconColor = System.Drawing.Color.Cyan;
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 50;
            this.ibtnSalir.Location = new System.Drawing.Point(12, 525);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(105, 74);
            this.ibtnSalir.TabIndex = 3;
            this.ibtnSalir.Text = "Cerrar sesión";
            this.ibtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnSalir.UseVisualStyleBackColor = true;
            this.ibtnSalir.Click += new System.EventHandler(this.ibtnSalir_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.Cyan;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(811, -1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 31);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido:";
            // 
            // lblUSER
            // 
            this.lblUSER.AutoSize = true;
            this.lblUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSER.ForeColor = System.Drawing.Color.Lime;
            this.lblUSER.Location = new System.Drawing.Point(12, 499);
            this.lblUSER.Name = "lblUSER";
            this.lblUSER.Size = new System.Drawing.Size(58, 16);
            this.lblUSER.TabIndex = 5;
            this.lblUSER.Text = "usuario";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.menuUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 55;
            this.menuUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(166, 24);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.menuProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProductos.IconSize = 55;
            this.menuProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(166, 24);
            this.menuProductos.Text = "Productos";
            this.menuProductos.Click += new System.EventHandler(this.menuProductos_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuCompras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.menuCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 55;
            this.menuCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(166, 24);
            this.menuCompras.Text = "Compras";
            this.menuCompras.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.School;
            this.menuVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 55;
            this.menuVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(166, 24);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuVentas.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 55;
            this.menuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(166, 24);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 55;
            this.menuProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(166, 24);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuReportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.menuReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 55;
            this.menuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(166, 24);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuAcercade
            // 
            this.menuAcercade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuAcercade.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.menuAcercade.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercade.IconSize = 55;
            this.menuAcercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(166, 24);
            this.menuAcercade.Text = "Acerca de";
            this.menuAcercade.Click += new System.EventHandler(this.menuAcercade_Click);
            // 
            // barraDeMenus
            // 
            this.barraDeMenus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.barraDeMenus.AutoSize = false;
            this.barraDeMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.barraDeMenus.Dock = System.Windows.Forms.DockStyle.None;
            this.barraDeMenus.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuProductos,
            this.menuCompras,
            this.menuVentas,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuProductosVer,
            this.menuEstadisticas,
            this.menuBackup,
            this.menuAcercade});
            this.barraDeMenus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.barraDeMenus.Location = new System.Drawing.Point(-4, 193);
            this.barraDeMenus.Name = "barraDeMenus";
            this.barraDeMenus.Size = new System.Drawing.Size(173, 274);
            this.barraDeMenus.TabIndex = 2;
            // 
            // menuProductosVer
            // 
            this.menuProductosVer.ForeColor = System.Drawing.SystemColors.Control;
            this.menuProductosVer.IconChar = FontAwesome.Sharp.IconChar.BagShopping;
            this.menuProductosVer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuProductosVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProductosVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuProductosVer.Name = "menuProductosVer";
            this.menuProductosVer.Size = new System.Drawing.Size(166, 24);
            this.menuProductosVer.Text = "Ver productos";
            this.menuProductosVer.Click += new System.EventHandler(this.menuProductosVer_Click);
            // 
            // menuEstadisticas
            // 
            this.menuEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuEstadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.menuEstadisticas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuEstadisticas.Name = "menuEstadisticas";
            this.menuEstadisticas.Size = new System.Drawing.Size(166, 24);
            this.menuEstadisticas.Text = "Estadisticas";
            this.menuEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuEstadisticas.Click += new System.EventHandler(this.menuEstadisticas_Click);
            // 
            // menuBackup
            // 
            this.menuBackup.ForeColor = System.Drawing.Color.White;
            this.menuBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.menuBackup.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBackup.Name = "menuBackup";
            this.menuBackup.Size = new System.Drawing.Size(166, 24);
            this.menuBackup.Text = "Back up";
            this.menuBackup.Click += new System.EventHandler(this.menuBackup_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(846, 625);
            this.ControlBox = false;
            this.Controls.Add(this.barraDeMenus);
            this.Controls.Add(this.lblUSER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ibtnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroHub";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraDeMenus.ResumeLayout(false);
            this.barraDeMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUSER;
        private System.Windows.Forms.MenuStrip barraDeMenus;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuProductos;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private FontAwesome.Sharp.IconMenuItem menuVerProductos;
        private FontAwesome.Sharp.IconMenuItem menuProductosVer;
        private FontAwesome.Sharp.IconMenuItem menuEstadisticas;
        private FontAwesome.Sharp.IconMenuItem menuBackup;
    }
}

