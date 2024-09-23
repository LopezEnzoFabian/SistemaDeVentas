namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.LoginBTN = new RoundedButton();
            this.txttPass = new RoundedTextBox();
            this.txttEmail = new RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(163, 187);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPass.Location = new System.Drawing.Point(163, 238);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(75, 18);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ibtnSalir.IconColor = System.Drawing.Color.Cyan;
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 40;
            this.ibtnSalir.Location = new System.Drawing.Point(12, 304);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(61, 59);
            this.ibtnSalir.TabIndex = 6;
            this.ibtnSalir.Text = "Salir";
            this.ibtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnSalir.UseVisualStyleBackColor = true;
            this.ibtnSalir.Click += new System.EventHandler(this.ibtnSalir_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LoginBTN.BorderRadius = 10;
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBTN.Icon = null;
            this.LoginBTN.Location = new System.Drawing.Point(166, 304);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(200, 33);
            this.LoginBTN.TabIndex = 3;
            this.LoginBTN.Text = "Ingresar";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // txttPass
            // 
            this.txttPass.BackColor = System.Drawing.SystemColors.Window;
            this.txttPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttPass.ForeColor = System.Drawing.Color.Black;
            this.txttPass.Location = new System.Drawing.Point(166, 259);
            this.txttPass.Multiline = true;
            this.txttPass.Name = "txttPass";
            this.txttPass.PasswordChar = '*';
            this.txttPass.Size = new System.Drawing.Size(200, 30);
            this.txttPass.TabIndex = 1;
            // 
            // txttEmail
            // 
            this.txttEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttEmail.Location = new System.Drawing.Point(166, 210);
            this.txttEmail.Name = "txttEmail";
            this.txttEmail.Size = new System.Drawing.Size(200, 26);
            this.txttEmail.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(540, 375);
            this.Controls.Add(this.ibtnSalir);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttPass);
            this.Controls.Add(this.txttEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedTextBox txttEmail;
        private RoundedTextBox txttPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedButton LoginBTN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private FontAwesome.Sharp.IconButton ibtnSalir;
    }
}