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
            this.panelVentas = new System.Windows.Forms.Panel();
            this.ibtnDetalleVenta = new FontAwesome.Sharp.IconButton();
            this.ibtnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.panelVentas.Location = new System.Drawing.Point(0, 50);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(662, 526);
            this.panelVentas.TabIndex = 6;
            // 
            // ibtnDetalleVenta
            // 
            this.ibtnDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnDetalleVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDetalleVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.ibtnDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDetalleVenta.Location = new System.Drawing.Point(352, 4);
            this.ibtnDetalleVenta.Name = "ibtnDetalleVenta";
            this.ibtnDetalleVenta.Size = new System.Drawing.Size(248, 40);
            this.ibtnDetalleVenta.TabIndex = 5;
            this.ibtnDetalleVenta.Text = "Ver detalle de ventas";
            this.ibtnDetalleVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnDetalleVenta.UseVisualStyleBackColor = true;
            this.ibtnDetalleVenta.Click += new System.EventHandler(this.ibtnDetalleVenta_Click);
            // 
            // ibtnRegistrarVenta
            // 
            this.ibtnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnRegistrarVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegistrarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.ibtnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrarVenta.Location = new System.Drawing.Point(150, 4);
            this.ibtnRegistrarVenta.Name = "ibtnRegistrarVenta";
            this.ibtnRegistrarVenta.Size = new System.Drawing.Size(198, 40);
            this.ibtnRegistrarVenta.TabIndex = 4;
            this.ibtnRegistrarVenta.Text = "Registrar Ventas";
            this.ibtnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnRegistrarVenta.UseVisualStyleBackColor = true;
            this.ibtnRegistrarVenta.Click += new System.EventHandler(this.ibtnRegistrarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione una opcion";
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(662, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibtnDetalleVenta);
            this.Controls.Add(this.panelVentas);
            this.Controls.Add(this.ibtnRegistrarVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.formVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVentas;
        private FontAwesome.Sharp.IconButton ibtnDetalleVenta;
        private FontAwesome.Sharp.IconButton ibtnRegistrarVenta;
        private System.Windows.Forms.Label label1;
    }
}