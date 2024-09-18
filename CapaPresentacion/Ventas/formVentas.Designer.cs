namespace CapaPresentacion
{
    partial class formVentas
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
            this.panelCompras = new System.Windows.Forms.Panel();
            this.ibtnDetalleVenta = new FontAwesome.Sharp.IconButton();
            this.ibtnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panelCompras
            // 
            this.panelCompras.Location = new System.Drawing.Point(8, 59);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(720, 463);
            this.panelCompras.TabIndex = 6;
            // 
            // ibtnDetalleVenta
            // 
            this.ibtnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDetalleVenta.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDetalleVenta.ForeColor = System.Drawing.Color.White;
            this.ibtnDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.ibtnDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDetalleVenta.Location = new System.Drawing.Point(365, 12);
            this.ibtnDetalleVenta.Name = "ibtnDetalleVenta";
            this.ibtnDetalleVenta.Size = new System.Drawing.Size(198, 40);
            this.ibtnDetalleVenta.TabIndex = 5;
            this.ibtnDetalleVenta.Text = "Ver detalle compra";
            this.ibtnDetalleVenta.UseVisualStyleBackColor = true;
            this.ibtnDetalleVenta.Click += new System.EventHandler(this.ibtnDetalleVenta_Click);
            // 
            // ibtnRegistrarVenta
            // 
            this.ibtnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRegistrarVenta.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.ibtnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.ibtnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrarVenta.Location = new System.Drawing.Point(140, 12);
            this.ibtnRegistrarVenta.Name = "ibtnRegistrarVenta";
            this.ibtnRegistrarVenta.Size = new System.Drawing.Size(198, 40);
            this.ibtnRegistrarVenta.TabIndex = 4;
            this.ibtnRegistrarVenta.Text = "Registrar Venta";
            this.ibtnRegistrarVenta.UseVisualStyleBackColor = true;
            this.ibtnRegistrarVenta.Click += new System.EventHandler(this.ibtnRegistrarVenta_Click);
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(740, 423);
            this.Controls.Add(this.ibtnDetalleVenta);
            this.Controls.Add(this.panelCompras);
            this.Controls.Add(this.ibtnRegistrarVenta);
            this.Name = "formVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.formVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCompras;
        private FontAwesome.Sharp.IconButton ibtnDetalleVenta;
        private FontAwesome.Sharp.IconButton ibtnRegistrarVenta;
    }
}