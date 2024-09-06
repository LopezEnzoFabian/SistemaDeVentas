namespace CapaPresentacion
{
    partial class formProveedores
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
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNomCon = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNomEmpresa = new System.Windows.Forms.Label();
            this.txtNomEmpresa = new System.Windows.Forms.TextBox();
            this.cbCateProd = new System.Windows.Forms.ComboBox();
            this.lblCateProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colNomEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCateProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomicilioClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomEmpresa,
            this.colCateProd,
            this.colNomContacto,
            this.colTelClie,
            this.colEmailClie,
            this.colDomicilioClie});
            this.dgListaClientes.Location = new System.Drawing.Point(12, 264);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.Size = new System.Drawing.Size(631, 149);
            this.dgListaClientes.TabIndex = 86;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(519, 126);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 37);
            this.btnModificar.TabIndex = 85;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(65, 20);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 84;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(313, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 31);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(193, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 82;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(9, 24);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(50, 13);
            this.lblFiltrar.TabIndex = 81;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(359, 187);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 80;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(359, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 79;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(279, 194);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 78;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(519, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 32);
            this.btnLimpiar.TabIndex = 77;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(519, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 30);
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(128, 187);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 75;
            // 
            // txtNomCon
            // 
            this.txtNomCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomCon.Location = new System.Drawing.Point(128, 157);
            this.txtNomCon.Name = "txtNomCon";
            this.txtNomCon.Size = new System.Drawing.Size(100, 20);
            this.txtNomCon.TabIndex = 72;
            this.txtNomCon.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(279, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 71;
            this.lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(10, 194);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 70;
            this.lblTel.Text = "Telefono";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(9, 164);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(105, 13);
            this.lblNom.TabIndex = 67;
            this.lblNom.Text = "Nombre de Contacto";
            // 
            // lblNomEmpresa
            // 
            this.lblNomEmpresa.AutoSize = true;
            this.lblNomEmpresa.Location = new System.Drawing.Point(190, 75);
            this.lblNomEmpresa.Name = "lblNomEmpresa";
            this.lblNomEmpresa.Size = new System.Drawing.Size(113, 13);
            this.lblNomEmpresa.TabIndex = 87;
            this.lblNomEmpresa.Text = "Nombre de la empresa";
            this.lblNomEmpresa.Click += new System.EventHandler(this.lblNomEmpresa_Click);
            // 
            // txtNomEmpresa
            // 
            this.txtNomEmpresa.Location = new System.Drawing.Point(309, 68);
            this.txtNomEmpresa.Name = "txtNomEmpresa";
            this.txtNomEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtNomEmpresa.TabIndex = 88;
            // 
            // cbCateProd
            // 
            this.cbCateProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCateProd.FormattingEnabled = true;
            this.cbCateProd.Location = new System.Drawing.Point(309, 100);
            this.cbCateProd.Name = "cbCateProd";
            this.cbCateProd.Size = new System.Drawing.Size(100, 21);
            this.cbCateProd.TabIndex = 91;
            // 
            // lblCateProd
            // 
            this.lblCateProd.AutoSize = true;
            this.lblCateProd.Location = new System.Drawing.Point(190, 108);
            this.lblCateProd.Name = "lblCateProd";
            this.lblCateProd.Size = new System.Drawing.Size(112, 13);
            this.lblCateProd.TabIndex = 89;
            this.lblCateProd.Text = "Categoria de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "Contacto";
            // 
            // colNomEmpresa
            // 
            this.colNomEmpresa.HeaderText = "Nombre de la empresa";
            this.colNomEmpresa.Name = "colNomEmpresa";
            // 
            // colCateProd
            // 
            this.colCateProd.HeaderText = "Categoria de producto";
            this.colCateProd.Name = "colCateProd";
            // 
            // colNomContacto
            // 
            this.colNomContacto.HeaderText = "Nombre de contacto";
            this.colNomContacto.Name = "colNomContacto";
            // 
            // colTelClie
            // 
            this.colTelClie.HeaderText = "Telefono";
            this.colTelClie.Name = "colTelClie";
            // 
            // colEmailClie
            // 
            this.colEmailClie.HeaderText = "Email";
            this.colEmailClie.Name = "colEmailClie";
            // 
            // colDomicilioClie
            // 
            this.colDomicilioClie.HeaderText = "Domicilio";
            this.colDomicilioClie.Name = "colDomicilioClie";
            // 
            // formProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(663, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCateProd);
            this.Controls.Add(this.lblCateProd);
            this.Controls.Add(this.txtNomEmpresa);
            this.Controls.Add(this.lblNomEmpresa);
            this.Controls.Add(this.dgListaClientes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNomCon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNom);
            this.Name = "formProveedores";
            this.Text = "formProveedores";
            this.Load += new System.EventHandler(this.formProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNomCon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNomEmpresa;
        private System.Windows.Forms.TextBox txtNomEmpresa;
        private System.Windows.Forms.ComboBox cbCateProd;
        private System.Windows.Forms.Label lblCateProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCateProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomicilioClie;
    }
}