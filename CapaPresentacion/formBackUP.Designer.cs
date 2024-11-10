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
            this.lblBACKUP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRESTAURAR
            // 
            this.btnRESTAURAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnRESTAURAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRESTAURAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRESTAURAR.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESTAURAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.btnRESTAURAR.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnRESTAURAR.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRESTAURAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRESTAURAR.IconSize = 70;
            this.btnRESTAURAR.Location = new System.Drawing.Point(399, 192);
            this.btnRESTAURAR.Name = "btnRESTAURAR";
            this.btnRESTAURAR.Size = new System.Drawing.Size(141, 137);
            this.btnRESTAURAR.TabIndex = 0;
            this.btnRESTAURAR.Text = "RESTAURAR BD";
            this.btnRESTAURAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRESTAURAR.UseVisualStyleBackColor = false;
            this.btnRESTAURAR.Click += new System.EventHandler(this.btnRESTAURAR_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 70;
            this.iconButton2.Location = new System.Drawing.Point(125, 192);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(136, 137);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "GENERAR RESPALDO";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lblBACKUP
            // 
            this.lblBACKUP.AutoSize = true;
            this.lblBACKUP.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBACKUP.Location = new System.Drawing.Point(186, 9);
            this.lblBACKUP.Name = "lblBACKUP";
            this.lblBACKUP.Size = new System.Drawing.Size(280, 26);
            this.lblBACKUP.TabIndex = 2;
            this.lblBACKUP.Text = "OPCIONES DE BACK UP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // formBackUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBACKUP);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnRESTAURAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formBackUP";
            this.Text = "formBackUP";
            this.Load += new System.EventHandler(this.formBackUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRESTAURAR;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lblBACKUP;
        private System.Windows.Forms.Label label1;
    }
}