namespace CapaPresentacion
{
    partial class formReportes
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
            this.ibtnVerDetalle = new FontAwesome.Sharp.IconButton();
            this.ibtnRegis = new FontAwesome.Sharp.IconButton();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.btnVentasRepo = new FontAwesome.Sharp.IconButton();
            this.btnComprasRepo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // ibtnVerDetalle
            // 
            this.ibtnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVerDetalle.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVerDetalle.ForeColor = System.Drawing.Color.White;
            this.ibtnVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnVerDetalle.IconColor = System.Drawing.Color.Black;
            this.ibtnVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVerDetalle.Location = new System.Drawing.Point(296, -22);
            this.ibtnVerDetalle.Name = "ibtnVerDetalle";
            this.ibtnVerDetalle.Size = new System.Drawing.Size(10, 10);
            this.ibtnVerDetalle.TabIndex = 5;
            this.ibtnVerDetalle.Text = "Ver detalle compra";
            this.ibtnVerDetalle.UseVisualStyleBackColor = true;
            // 
            // ibtnRegis
            // 
            this.ibtnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRegis.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegis.ForeColor = System.Drawing.Color.White;
            this.ibtnRegis.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnRegis.IconColor = System.Drawing.Color.Black;
            this.ibtnRegis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegis.Location = new System.Drawing.Point(94, -22);
            this.ibtnRegis.Name = "ibtnRegis";
            this.ibtnRegis.Size = new System.Drawing.Size(10, 10);
            this.ibtnRegis.TabIndex = 4;
            this.ibtnRegis.Text = "Registrar Compra";
            this.ibtnRegis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnRegis.UseVisualStyleBackColor = true;
            // 
            // panelReportes
            // 
            this.panelReportes.Location = new System.Drawing.Point(5, 86);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(801, 357);
            this.panelReportes.TabIndex = 8;
            // 
            // btnVentasRepo
            // 
            this.btnVentasRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasRepo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasRepo.ForeColor = System.Drawing.Color.White;
            this.btnVentasRepo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVentasRepo.IconColor = System.Drawing.Color.Black;
            this.btnVentasRepo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentasRepo.Location = new System.Drawing.Point(368, 4);
            this.btnVentasRepo.Name = "btnVentasRepo";
            this.btnVentasRepo.Size = new System.Drawing.Size(203, 40);
            this.btnVentasRepo.TabIndex = 7;
            this.btnVentasRepo.Text = "Reporte Ventas";
            this.btnVentasRepo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentasRepo.UseVisualStyleBackColor = true;
            this.btnVentasRepo.Click += new System.EventHandler(this.btnVentasRepo_Click);
            // 
            // btnComprasRepo
            // 
            this.btnComprasRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasRepo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprasRepo.ForeColor = System.Drawing.Color.White;
            this.btnComprasRepo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnComprasRepo.IconColor = System.Drawing.Color.Black;
            this.btnComprasRepo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprasRepo.Location = new System.Drawing.Point(150, 4);
            this.btnComprasRepo.Name = "btnComprasRepo";
            this.btnComprasRepo.Size = new System.Drawing.Size(212, 40);
            this.btnComprasRepo.TabIndex = 6;
            this.btnComprasRepo.Text = "Reporte Compras";
            this.btnComprasRepo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprasRepo.UseVisualStyleBackColor = true;
            this.btnComprasRepo.Click += new System.EventHandler(this.btnComprasRepo_Click);
            // 
            // formReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(818, 482);
            this.Controls.Add(this.panelReportes);
            this.Controls.Add(this.btnVentasRepo);
            this.Controls.Add(this.btnComprasRepo);
            this.Controls.Add(this.ibtnVerDetalle);
            this.Controls.Add(this.ibtnRegis);
            this.Name = "formReportes";
            this.Text = "formReportes";
            this.Load += new System.EventHandler(this.formReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnVerDetalle;
        private FontAwesome.Sharp.IconButton ibtnRegis;
        private System.Windows.Forms.Panel panelReportes;
        private FontAwesome.Sharp.IconButton btnVentasRepo;
        private FontAwesome.Sharp.IconButton btnComprasRepo;
    }
}