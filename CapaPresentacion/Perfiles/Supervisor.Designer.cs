namespace CapaPresentacion.Perfiles
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 173);
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
            this.contenedor.Location = new System.Drawing.Point(175, 1);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(623, 464);
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
            this.menuReportes,
            this.menuAcercade});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(-1, 174);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(173, 291);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
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
            this.ibtnSalir.Location = new System.Drawing.Point(12, 397);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(89, 52);
            this.ibtnSalir.TabIndex = 6;
            this.ibtnSalir.Text = "Cerrar sesiòn";
            this.ibtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnSalir.UseVisualStyleBackColor = false;
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.ibtnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Supervisor";
            this.Text = "Supervisor";
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
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private FontAwesome.Sharp.IconButton ibtnSalir;
    }
}