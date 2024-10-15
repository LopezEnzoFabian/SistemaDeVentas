namespace CapaPresentacion
{
    partial class formCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblListaCate = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgListaCategorias = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.ibtnGuardar = new FontAwesome.Sharp.IconButton();
            this.ibtnEditar = new FontAwesome.Sharp.IconButton();
            this.ibtnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.btnclean = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 20);
            this.txtID.TabIndex = 63;
            // 
            // lblListaCate
            // 
            this.lblListaCate.AutoEllipsis = true;
            this.lblListaCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.lblListaCate.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCate.ForeColor = System.Drawing.Color.Black;
            this.lblListaCate.Location = new System.Drawing.Point(12, 60);
            this.lblListaCate.Name = "lblListaCate";
            this.lblListaCate.Size = new System.Drawing.Size(222, 28);
            this.lblListaCate.TabIndex = 62;
            this.lblListaCate.Text = "Lista de categorias.";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(178, 18);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 25);
            this.cbFiltro.TabIndex = 58;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(305, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 25);
            this.txtBuscar.TabIndex = 57;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Black;
            this.lblFiltro.Location = new System.Drawing.Point(93, 27);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(79, 16);
            this.lblFiltro.TabIndex = 56;
            this.lblFiltro.Text = "Filtrar por";
            // 
            // dgListaCategorias
            // 
            this.dgListaCategorias.AllowUserToAddRows = false;
            this.dgListaCategorias.AllowUserToDeleteRows = false;
            this.dgListaCategorias.AllowUserToResizeColumns = false;
            this.dgListaCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgListaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgListaCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgListaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgListaCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.colid,
            this.colDescripcion,
            this.colEstadoValor,
            this.colEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgListaCategorias.GridColor = System.Drawing.SystemColors.Control;
            this.dgListaCategorias.Location = new System.Drawing.Point(-2, 119);
            this.dgListaCategorias.MultiSelect = false;
            this.dgListaCategorias.Name = "dgListaCategorias";
            this.dgListaCategorias.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            this.dgListaCategorias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgListaCategorias.Size = new System.Drawing.Size(665, 206);
            this.dgListaCategorias.TabIndex = 70;
            this.dgListaCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaCategorias_CellContentClick);
            this.dgListaCategorias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgListaCategorias_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 35F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Width = 5;
            // 
            // colid
            // 
            this.colid.HeaderText = "id";
            this.colid.Name = "colid";
            this.colid.Visible = false;
            this.colid.Width = 42;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FillWeight = 84.5141F;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 98;
            // 
            // colEstadoValor
            // 
            this.colEstadoValor.FillWeight = 84.5141F;
            this.colEstadoValor.HeaderText = "EstadoValor";
            this.colEstadoValor.Name = "colEstadoValor";
            this.colEstadoValor.Visible = false;
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 84.5141F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 70;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(40, 446);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 16);
            this.lblEstado.TabIndex = 74;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(43, 467);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(146, 25);
            this.cbEstado.TabIndex = 73;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(43, 417);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(146, 25);
            this.txtDescrip.TabIndex = 72;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(40, 397);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 71;
            this.lblDescripcion.Text = "Descripción";
            // 
            // ibtnGuardar
            // 
            this.ibtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuardar.IconSize = 30;
            this.ibtnGuardar.Location = new System.Drawing.Point(288, 428);
            this.ibtnGuardar.Name = "ibtnGuardar";
            this.ibtnGuardar.Size = new System.Drawing.Size(76, 52);
            this.ibtnGuardar.TabIndex = 91;
            this.ibtnGuardar.Text = "Guardar";
            this.ibtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnGuardar.UseVisualStyleBackColor = false;
            this.ibtnGuardar.Click += new System.EventHandler(this.ibtnGuardar_Click);
            // 
            // ibtnEditar
            // 
            this.ibtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnEditar.IconColor = System.Drawing.Color.Aqua;
            this.ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnEditar.IconSize = 30;
            this.ibtnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnEditar.Location = new System.Drawing.Point(404, 428);
            this.ibtnEditar.Name = "ibtnEditar";
            this.ibtnEditar.Size = new System.Drawing.Size(76, 52);
            this.ibtnEditar.TabIndex = 90;
            this.ibtnEditar.Text = "Editar";
            this.ibtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnEditar.UseVisualStyleBackColor = false;
            this.ibtnEditar.Click += new System.EventHandler(this.ibtnEditar_Click);
            // 
            // ibtnEliminar
            // 
            this.ibtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ibtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ibtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnEliminar.IconColor = System.Drawing.Color.Aqua;
            this.ibtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnEliminar.IconSize = 30;
            this.ibtnEliminar.Location = new System.Drawing.Point(513, 428);
            this.ibtnEliminar.Name = "ibtnEliminar";
            this.ibtnEliminar.Size = new System.Drawing.Size(76, 52);
            this.ibtnEliminar.TabIndex = 89;
            this.ibtnEliminar.Text = "Eliminar";
            this.ibtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnEliminar.UseVisualStyleBackColor = false;
            this.ibtnEliminar.Click += new System.EventHandler(this.ibtnEliminar_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnsearch.IconColor = System.Drawing.Color.Aqua;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 20;
            this.btnsearch.Location = new System.Drawing.Point(454, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 30);
            this.btnsearch.TabIndex = 94;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnclean.IconColor = System.Drawing.Color.Aqua;
            this.btnclean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclean.IconSize = 20;
            this.btnclean.Location = new System.Drawing.Point(491, 13);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(31, 30);
            this.btnclean.TabIndex = 93;
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "ABM de categorias.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "puedes dar de alta,modificar o eliminar una categoria desde aqui.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "selecciona una categoria";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(43, 10);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(31, 20);
            this.txtindice.TabIndex = 98;
            // 
            // formCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(662, 578);
            this.Controls.Add(this.ibtnGuardar);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.ibtnEditar);
            this.Controls.Add(this.ibtnEliminar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dgListaCategorias);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblListaCate);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.formCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblListaCate;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView dgListaCategorias;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label lblDescripcion;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnclean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}