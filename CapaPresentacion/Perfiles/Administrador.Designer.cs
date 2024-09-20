namespace CapaPresentacion.Perfiles
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.AutoSize = true;
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Location = new System.Drawing.Point(176, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(984, 675);
            this.contenedor.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuProductos,
            this.menuCompras,
            this.menuVentas,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcercade});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 178);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(173, 384);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuUsuarios.IconColor = System.Drawing.Color.White;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(166, 24);
            this.menuUsuarios.Text = "Usuarios";
            // 
            // menuProductos
            // 
            this.menuProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.menuProductos.IconColor = System.Drawing.Color.White;
            this.menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(166, 24);
            this.menuProductos.Text = "Productos";
            // 
            // menuCompras
            // 
            this.menuCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuCompras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.menuCompras.IconColor = System.Drawing.Color.White;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(166, 24);
            this.menuCompras.Text = "Compras";
            // 
            // menuVentas
            // 
            this.menuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.School;
            this.menuVentas.IconColor = System.Drawing.Color.White;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(166, 24);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuClientes
            // 
            this.menuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuClientes.IconColor = System.Drawing.Color.White;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(166, 24);
            this.menuClientes.Text = "Clientes";
            // 
            // menuProveedores
            // 
            this.menuProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuProveedores.IconColor = System.Drawing.Color.White;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(166, 24);
            this.menuProveedores.Text = "Proveedores";
            // 
            // menuReportes
            // 
            this.menuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.menuReportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.menuReportes.IconColor = System.Drawing.Color.White;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(166, 24);
            this.menuReportes.Text = "Reportes";
            // 
            // menuAcercade
            // 
            this.menuAcercade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuAcercade.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuAcercade.IconColor = System.Drawing.Color.WhiteSmoke;
            this.menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(166, 24);
            this.menuAcercade.Text = "Acerca de";
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ibtnSalir.IconColor = System.Drawing.Color.Cyan;
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 30;
            this.ibtnSalir.Location = new System.Drawing.Point(12, 497);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(89, 52);
            this.ibtnSalir.TabIndex = 7;
            this.ibtnSalir.Text = "Cerrar sesión";
            this.ibtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnSalir.UseVisualStyleBackColor = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ibtnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuProductos;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private FontAwesome.Sharp.IconButton ibtnSalir;
    }
}