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
            this.SuspendLayout();
            // 
            // panelProductos
            // 
            this.panelProductos.Location = new System.Drawing.Point(7, 50);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(784, 463);
            this.panelProductos.TabIndex = 6;
            // 
            // ibtnCategorias
            // 
            this.ibtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCategorias.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCategorias.ForeColor = System.Drawing.Color.White;
            this.ibtnCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCategorias.IconColor = System.Drawing.Color.Black;
            this.ibtnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCategorias.Location = new System.Drawing.Point(397, 3);
            this.ibtnCategorias.Name = "ibtnCategorias";
            this.ibtnCategorias.Size = new System.Drawing.Size(151, 40);
            this.ibtnCategorias.TabIndex = 5;
            this.ibtnCategorias.Text = "Categorias";
            this.ibtnCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnCategorias.UseVisualStyleBackColor = true;
            this.ibtnCategorias.Click += new System.EventHandler(this.ibtnCategorias_Click);
            // 
            // ibtnProductos
            // 
            this.ibtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProductos.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnProductos.ForeColor = System.Drawing.Color.White;
            this.ibtnProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnProductos.IconColor = System.Drawing.Color.Black;
            this.ibtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProductos.Location = new System.Drawing.Point(195, 3);
            this.ibtnProductos.Name = "ibtnProductos";
            this.ibtnProductos.Size = new System.Drawing.Size(151, 40);
            this.ibtnProductos.TabIndex = 4;
            this.ibtnProductos.Text = "Productos";
            this.ibtnProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnProductos.UseVisualStyleBackColor = true;
            this.ibtnProductos.Click += new System.EventHandler(this.ibtnProductos_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.ibtnCategorias);
            this.Controls.Add(this.ibtnProductos);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductos;
        private FontAwesome.Sharp.IconButton ibtnCategorias;
        private FontAwesome.Sharp.IconButton ibtnProductos;
    }
}