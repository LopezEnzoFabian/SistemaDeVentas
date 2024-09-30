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
            this.ibtnRegistrarCom = new FontAwesome.Sharp.IconButton();
            this.ibtnVerDetalle = new FontAwesome.Sharp.IconButton();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ibtnRegistrarCom
            // 
            this.ibtnRegistrarCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnRegistrarCom.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegistrarCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnRegistrarCom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnRegistrarCom.IconColor = System.Drawing.Color.Black;
            this.ibtnRegistrarCom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistrarCom.Location = new System.Drawing.Point(150, 4);
            this.ibtnRegistrarCom.Name = "ibtnRegistrarCom";
            this.ibtnRegistrarCom.Size = new System.Drawing.Size(151, 40);
            this.ibtnRegistrarCom.TabIndex = 1;
            this.ibtnRegistrarCom.Text = "Registrar Compra";
            this.ibtnRegistrarCom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnRegistrarCom.UseVisualStyleBackColor = true;
            this.ibtnRegistrarCom.Click += new System.EventHandler(this.ibtnRegis_Click);
            // 
            // ibtnVerDetalle
            // 
            this.ibtnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnVerDetalle.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVerDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnVerDetalle.IconColor = System.Drawing.Color.Black;
            this.ibtnVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVerDetalle.Location = new System.Drawing.Point(352, 4);
            this.ibtnVerDetalle.Name = "ibtnVerDetalle";
            this.ibtnVerDetalle.Size = new System.Drawing.Size(151, 40);
            this.ibtnVerDetalle.TabIndex = 2;
            this.ibtnVerDetalle.Text = "Ver detalle compra";
            this.ibtnVerDetalle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnVerDetalle.UseVisualStyleBackColor = true;
            this.ibtnVerDetalle.Click += new System.EventHandler(this.ibtnVerDetalle_Click);
            // 
            // panelCompras
            // 
            this.panelCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.panelCompras.Location = new System.Drawing.Point(2, 50);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(657, 528);
            this.panelCompras.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una opcion";
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(662, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCompras);
            this.Controls.Add(this.ibtnVerDetalle);
            this.Controls.Add(this.ibtnRegistrarCom);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCompras";
            this.Text = "formCompras";
            this.Load += new System.EventHandler(this.formCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnRegistrarCom;
        private FontAwesome.Sharp.IconButton ibtnVerDetalle;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Label label1;
    }
}