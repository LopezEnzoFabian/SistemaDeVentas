namespace CapaPresentacion.Productos
{
    partial class formProductos
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
            this.panelProductos = new System.Windows.Forms.Panel();
            this.ibtnCategorias = new FontAwesome.Sharp.IconButton();
            this.ibtnProductos = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.panelProductos.Location = new System.Drawing.Point(1, 50);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(643, 520);
            this.panelProductos.TabIndex = 6;
            // 
            // ibtnCategorias
            // 
            this.ibtnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ibtnCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCategorias.IconColor = System.Drawing.Color.Black;
            this.ibtnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCategorias.Location = new System.Drawing.Point(341, 4);
            this.ibtnCategorias.Name = "ibtnCategorias";
            this.ibtnCategorias.Size = new System.Drawing.Size(191, 40);
            this.ibtnCategorias.TabIndex = 5;
            this.ibtnCategorias.Text = "ABM categorias";
            this.ibtnCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnCategorias.UseVisualStyleBackColor = true;
            this.ibtnCategorias.Click += new System.EventHandler(this.ibtnCategorias_Click);
            // 
            // ibtnProductos
            // 
            this.ibtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnProductos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnProductos.IconColor = System.Drawing.Color.Black;
            this.ibtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProductos.Location = new System.Drawing.Point(150, 4);
            this.ibtnProductos.Name = "ibtnProductos";
            this.ibtnProductos.Size = new System.Drawing.Size(185, 40);
            this.ibtnProductos.TabIndex = 4;
            this.ibtnProductos.Text = "ABM productos";
            this.ibtnProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnProductos.UseVisualStyleBackColor = true;
            this.ibtnProductos.Click += new System.EventHandler(this.ibtnProductos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una opcion";
            // 
            // formProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(644, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.ibtnCategorias);
            this.Controls.Add(this.ibtnProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProductos;
        private FontAwesome.Sharp.IconButton ibtnCategorias;
        private FontAwesome.Sharp.IconButton ibtnProductos;
        private System.Windows.Forms.Label label1;
    }
}