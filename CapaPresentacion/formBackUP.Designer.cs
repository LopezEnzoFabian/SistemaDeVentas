namespace CapaPresentacion
{
    partial class formBackUP
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
            this.btnRESTAURAR = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnRESTAURAR
            // 
            this.btnRESTAURAR.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRESTAURAR.IconColor = System.Drawing.Color.Black;
            this.btnRESTAURAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRESTAURAR.Location = new System.Drawing.Point(386, 186);
            this.btnRESTAURAR.Name = "btnRESTAURAR";
            this.btnRESTAURAR.Size = new System.Drawing.Size(141, 100);
            this.btnRESTAURAR.TabIndex = 0;
            this.btnRESTAURAR.Text = "RESTAURAR BD";
            this.btnRESTAURAR.UseVisualStyleBackColor = true;
            this.btnRESTAURAR.Click += new System.EventHandler(this.btnRESTAURAR_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(116, 186);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(136, 100);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "GENERAR RESPALDO";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // formBackUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 578);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnRESTAURAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formBackUP";
            this.Text = "formBackUP";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRESTAURAR;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}