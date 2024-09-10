namespace CapaPresentacion
{
    partial class formCompras
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
            this.ibtnRegis = new FontAwesome.Sharp.IconButton();
            this.ibtnVerDetalle = new FontAwesome.Sharp.IconButton();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ibtnRegis
            // 
            this.ibtnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRegis.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegis.ForeColor = System.Drawing.Color.White;
            this.ibtnRegis.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnRegis.IconColor = System.Drawing.Color.Black;
            this.ibtnRegis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegis.Location = new System.Drawing.Point(200, 10);
            this.ibtnRegis.Name = "ibtnRegis";
            this.ibtnRegis.Size = new System.Drawing.Size(151, 40);
            this.ibtnRegis.TabIndex = 1;
            this.ibtnRegis.Text = "Registrar Compra";
            this.ibtnRegis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnRegis.UseVisualStyleBackColor = true;
            this.ibtnRegis.Click += new System.EventHandler(this.ibtnRegis_Click);
            // 
            // ibtnVerDetalle
            // 
            this.ibtnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVerDetalle.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVerDetalle.ForeColor = System.Drawing.Color.White;
            this.ibtnVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnVerDetalle.IconColor = System.Drawing.Color.Black;
            this.ibtnVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVerDetalle.Location = new System.Drawing.Point(402, 10);
            this.ibtnVerDetalle.Name = "ibtnVerDetalle";
            this.ibtnVerDetalle.Size = new System.Drawing.Size(151, 40);
            this.ibtnVerDetalle.TabIndex = 2;
            this.ibtnVerDetalle.Text = "Ver detalle compra";
            this.ibtnVerDetalle.UseVisualStyleBackColor = true;
            this.ibtnVerDetalle.Click += new System.EventHandler(this.ibtnVerDetalle_Click);
            // 
            // panelCompras
            // 
            this.panelCompras.Location = new System.Drawing.Point(12, 57);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(784, 463);
            this.panelCompras.TabIndex = 3;
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(808, 522);
            this.Controls.Add(this.panelCompras);
            this.Controls.Add(this.ibtnVerDetalle);
            this.Controls.Add(this.ibtnRegis);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formCompras";
            this.Text = "formCompras";
            this.Load += new System.EventHandler(this.formCompras_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnRegis;
        private FontAwesome.Sharp.IconButton ibtnVerDetalle;
        private System.Windows.Forms.Panel panelCompras;
    }
}