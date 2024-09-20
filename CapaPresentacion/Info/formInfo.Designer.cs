namespace CapaPresentacion
{
    partial class formInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfo));
            this.txtiNFO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtiNFO
            // 
            this.txtiNFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.txtiNFO.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiNFO.ForeColor = System.Drawing.Color.White;
            this.txtiNFO.Location = new System.Drawing.Point(23, 48);
            this.txtiNFO.Multiline = true;
            this.txtiNFO.Name = "txtiNFO";
            this.txtiNFO.ReadOnly = true;
            this.txtiNFO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtiNFO.Size = new System.Drawing.Size(758, 472);
            this.txtiNFO.TabIndex = 0;
            this.txtiNFO.Text = resources.GetString("txtiNFO.Text");
            this.txtiNFO.TextChanged += new System.EventHandler(this.txtiNFO_TextChanged);
            // 
            // formInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(793, 511);
            this.Controls.Add(this.txtiNFO);
            this.Name = "formInfo";
            this.Text = "formInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtiNFO;
    }
}