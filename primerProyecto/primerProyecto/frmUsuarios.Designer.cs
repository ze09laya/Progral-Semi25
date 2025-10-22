namespace primerProyecto
{
    partial class frmUsuarios
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscarusuario = new System.Windows.Forms.TextBox();
            this.lblBuscarusuario = new System.Windows.Forms.Label();
            this.grdDatosusuario = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionusuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarusuario = new System.Windows.Forms.Button();
            this.btnModificarusuario = new System.Windows.Forms.Button();
            this.btnNuevousuario = new System.Windows.Forms.Button();
            this.grbNavegacionusuario = new System.Windows.Forms.GroupBox();
            this.lblRegistrosusuario = new System.Windows.Forms.Label();
            this.btnUltimousuario = new System.Windows.Forms.Button();
            this.btnSiguienteusuario = new System.Windows.Forms.Button();
            this.btnAnteriorusuario = new System.Windows.Forms.Button();
            this.btnPrimerousuario = new System.Windows.Forms.Button();
            this.grbDatosusuario = new System.Windows.Forms.GroupBox();
            this.lblTelefonousuario = new System.Windows.Forms.Label();
            this.txtTelefonousuario = new System.Windows.Forms.TextBox();
            this.lblDireccionusuario = new System.Windows.Forms.Label();
            this.txtDireccionusuario = new System.Windows.Forms.TextBox();
            this.lblNombreusuario = new System.Windows.Forms.Label();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.lblclaveusuario = new System.Windows.Forms.Label();
            this.txtclaveusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosusuario)).BeginInit();
            this.grbEdicionusuario.SuspendLayout();
            this.grbNavegacionusuario.SuspendLayout();
            this.grbDatosusuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(858, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 59);
            this.button1.TabIndex = 21;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscarusuario
            // 
            this.txtBuscarusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarusuario.Location = new System.Drawing.Point(793, 51);
            this.txtBuscarusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarusuario.Name = "txtBuscarusuario";
            this.txtBuscarusuario.Size = new System.Drawing.Size(565, 30);
            this.txtBuscarusuario.TabIndex = 20;
            this.txtBuscarusuario.TextChanged += new System.EventHandler(this.txtBuscarusuario_TextChanged);
            // 
            // lblBuscarusuario
            // 
            this.lblBuscarusuario.AutoSize = true;
            this.lblBuscarusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarusuario.Location = new System.Drawing.Point(688, 54);
            this.lblBuscarusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarusuario.Name = "lblBuscarusuario";
            this.lblBuscarusuario.Size = new System.Drawing.Size(97, 23);
            this.lblBuscarusuario.TabIndex = 19;
            this.lblBuscarusuario.Text = "BUSCAR:";
            // 
            // grdDatosusuario
            // 
            this.grdDatosusuario.AllowUserToAddRows = false;
            this.grdDatosusuario.AllowUserToDeleteRows = false;
            this.grdDatosusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosusuario.Location = new System.Drawing.Point(679, 94);
            this.grdDatosusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDatosusuario.Name = "grdDatosusuario";
            this.grdDatosusuario.ReadOnly = true;
            this.grdDatosusuario.RowHeadersWidth = 51;
            this.grdDatosusuario.Size = new System.Drawing.Size(743, 336);
            this.grdDatosusuario.TabIndex = 18;
            this.grdDatosusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosusuario_CellContentClick);
            this.grdDatosusuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosusuario_CellContentDoubleClick);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.MinimumWidth = 6;
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            this.idAlumno.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // grbEdicionusuario
            // 
            this.grbEdicionusuario.Controls.Add(this.btnEliminarusuario);
            this.grbEdicionusuario.Controls.Add(this.btnModificarusuario);
            this.grbEdicionusuario.Controls.Add(this.btnNuevousuario);
            this.grbEdicionusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionusuario.Location = new System.Drawing.Point(408, 482);
            this.grbEdicionusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEdicionusuario.Name = "grbEdicionusuario";
            this.grbEdicionusuario.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEdicionusuario.Size = new System.Drawing.Size(441, 89);
            this.grbEdicionusuario.TabIndex = 17;
            this.grbEdicionusuario.TabStop = false;
            this.grbEdicionusuario.Text = "Navegacion";
            // 
            // btnEliminarusuario
            // 
            this.btnEliminarusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarusuario.Location = new System.Drawing.Point(284, 29);
            this.btnEliminarusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarusuario.Name = "btnEliminarusuario";
            this.btnEliminarusuario.Size = new System.Drawing.Size(145, 59);
            this.btnEliminarusuario.TabIndex = 6;
            this.btnEliminarusuario.Text = "Eliminar";
            this.btnEliminarusuario.UseVisualStyleBackColor = true;
            this.btnEliminarusuario.Click += new System.EventHandler(this.btnEliminarusuario_Click);
            // 
            // btnModificarusuario
            // 
            this.btnModificarusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarusuario.Location = new System.Drawing.Point(130, 29);
            this.btnModificarusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarusuario.Name = "btnModificarusuario";
            this.btnModificarusuario.Size = new System.Drawing.Size(156, 59);
            this.btnModificarusuario.TabIndex = 5;
            this.btnModificarusuario.Text = "Modificar";
            this.btnModificarusuario.UseVisualStyleBackColor = true;
            this.btnModificarusuario.Click += new System.EventHandler(this.btnModificarusuario_Click);
            // 
            // btnNuevousuario
            // 
            this.btnNuevousuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevousuario.Location = new System.Drawing.Point(9, 29);
            this.btnNuevousuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevousuario.Name = "btnNuevousuario";
            this.btnNuevousuario.Size = new System.Drawing.Size(125, 59);
            this.btnNuevousuario.TabIndex = 4;
            this.btnNuevousuario.Text = "Nuevo";
            this.btnNuevousuario.UseVisualStyleBackColor = true;
            this.btnNuevousuario.Click += new System.EventHandler(this.btnNuevousuario_Click);
            // 
            // grbNavegacionusuario
            // 
            this.grbNavegacionusuario.Controls.Add(this.lblRegistrosusuario);
            this.grbNavegacionusuario.Controls.Add(this.btnUltimousuario);
            this.grbNavegacionusuario.Controls.Add(this.btnSiguienteusuario);
            this.grbNavegacionusuario.Controls.Add(this.btnAnteriorusuario);
            this.grbNavegacionusuario.Controls.Add(this.btnPrimerousuario);
            this.grbNavegacionusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionusuario.Location = new System.Drawing.Point(41, 482);
            this.grbNavegacionusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNavegacionusuario.Name = "grbNavegacionusuario";
            this.grbNavegacionusuario.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNavegacionusuario.Size = new System.Drawing.Size(320, 89);
            this.grbNavegacionusuario.TabIndex = 16;
            this.grbNavegacionusuario.TabStop = false;
            this.grbNavegacionusuario.Text = "Navegacion";
            // 
            // lblRegistrosusuario
            // 
            this.lblRegistrosusuario.AutoSize = true;
            this.lblRegistrosusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosusuario.Location = new System.Drawing.Point(132, 43);
            this.lblRegistrosusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosusuario.Name = "lblRegistrosusuario";
            this.lblRegistrosusuario.Size = new System.Drawing.Size(60, 23);
            this.lblRegistrosusuario.TabIndex = 10;
            this.lblRegistrosusuario.Text = "x de n";
            // 
            // btnUltimousuario
            // 
            this.btnUltimousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimousuario.Location = new System.Drawing.Point(258, 21);
            this.btnUltimousuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUltimousuario.Name = "btnUltimousuario";
            this.btnUltimousuario.Size = new System.Drawing.Size(53, 59);
            this.btnUltimousuario.TabIndex = 3;
            this.btnUltimousuario.Text = ">|";
            this.btnUltimousuario.UseVisualStyleBackColor = true;
            this.btnUltimousuario.Click += new System.EventHandler(this.btnUltimousuario_Click);
            // 
            // btnSiguienteusuario
            // 
            this.btnSiguienteusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteusuario.Location = new System.Drawing.Point(208, 21);
            this.btnSiguienteusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguienteusuario.Name = "btnSiguienteusuario";
            this.btnSiguienteusuario.Size = new System.Drawing.Size(53, 59);
            this.btnSiguienteusuario.TabIndex = 2;
            this.btnSiguienteusuario.Text = ">";
            this.btnSiguienteusuario.UseVisualStyleBackColor = true;
            this.btnSiguienteusuario.Click += new System.EventHandler(this.btnSiguienteusuario_Click);
            // 
            // btnAnteriorusuario
            // 
            this.btnAnteriorusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorusuario.Location = new System.Drawing.Point(60, 28);
            this.btnAnteriorusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnteriorusuario.Name = "btnAnteriorusuario";
            this.btnAnteriorusuario.Size = new System.Drawing.Size(53, 59);
            this.btnAnteriorusuario.TabIndex = 1;
            this.btnAnteriorusuario.Text = "<";
            this.btnAnteriorusuario.UseVisualStyleBackColor = true;
            this.btnAnteriorusuario.Click += new System.EventHandler(this.btnAnteriorusuario_Click);
            // 
            // btnPrimerousuario
            // 
            this.btnPrimerousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerousuario.Location = new System.Drawing.Point(10, 28);
            this.btnPrimerousuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrimerousuario.Name = "btnPrimerousuario";
            this.btnPrimerousuario.Size = new System.Drawing.Size(53, 59);
            this.btnPrimerousuario.TabIndex = 0;
            this.btnPrimerousuario.Text = "|<";
            this.btnPrimerousuario.UseVisualStyleBackColor = true;
            this.btnPrimerousuario.Click += new System.EventHandler(this.btnPrimerousuario_Click);
            // 
            // grbDatosusuario
            // 
            this.grbDatosusuario.Controls.Add(this.lblTelefonousuario);
            this.grbDatosusuario.Controls.Add(this.txtTelefonousuario);
            this.grbDatosusuario.Controls.Add(this.lblDireccionusuario);
            this.grbDatosusuario.Controls.Add(this.txtDireccionusuario);
            this.grbDatosusuario.Controls.Add(this.lblNombreusuario);
            this.grbDatosusuario.Controls.Add(this.txtnombreusuario);
            this.grbDatosusuario.Controls.Add(this.lblclaveusuario);
            this.grbDatosusuario.Controls.Add(this.txtclaveusuario);
            this.grbDatosusuario.Controls.Add(this.lblusuario);
            this.grbDatosusuario.Controls.Add(this.txtusuario);
            this.grbDatosusuario.Enabled = false;
            this.grbDatosusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosusuario.Location = new System.Drawing.Point(41, 32);
            this.grbDatosusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatosusuario.Name = "grbDatosusuario";
            this.grbDatosusuario.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatosusuario.Size = new System.Drawing.Size(585, 398);
            this.grbDatosusuario.TabIndex = 15;
            this.grbDatosusuario.TabStop = false;
            this.grbDatosusuario.Text = "Datos usuario";
            // 
            // lblTelefonousuario
            // 
            this.lblTelefonousuario.AutoSize = true;
            this.lblTelefonousuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonousuario.Location = new System.Drawing.Point(46, 308);
            this.lblTelefonousuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonousuario.Name = "lblTelefonousuario";
            this.lblTelefonousuario.Size = new System.Drawing.Size(90, 23);
            this.lblTelefonousuario.TabIndex = 9;
            this.lblTelefonousuario.Text = "Telefono:";
            // 
            // txtTelefonousuario
            // 
            this.txtTelefonousuario.Location = new System.Drawing.Point(197, 314);
            this.txtTelefonousuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefonousuario.Name = "txtTelefonousuario";
            this.txtTelefonousuario.Size = new System.Drawing.Size(148, 30);
            this.txtTelefonousuario.TabIndex = 8;
            // 
            // lblDireccionusuario
            // 
            this.lblDireccionusuario.AutoSize = true;
            this.lblDireccionusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionusuario.Location = new System.Drawing.Point(46, 239);
            this.lblDireccionusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionusuario.Name = "lblDireccionusuario";
            this.lblDireccionusuario.Size = new System.Drawing.Size(97, 23);
            this.lblDireccionusuario.TabIndex = 7;
            this.lblDireccionusuario.Text = "Direccion:";
            // 
            // txtDireccionusuario
            // 
            this.txtDireccionusuario.Location = new System.Drawing.Point(197, 245);
            this.txtDireccionusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionusuario.Name = "txtDireccionusuario";
            this.txtDireccionusuario.Size = new System.Drawing.Size(148, 30);
            this.txtDireccionusuario.TabIndex = 6;
            // 
            // lblNombreusuario
            // 
            this.lblNombreusuario.AutoSize = true;
            this.lblNombreusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreusuario.Location = new System.Drawing.Point(46, 179);
            this.lblNombreusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreusuario.Name = "lblNombreusuario";
            this.lblNombreusuario.Size = new System.Drawing.Size(84, 23);
            this.lblNombreusuario.TabIndex = 5;
            this.lblNombreusuario.Text = "Nombre:";
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Location = new System.Drawing.Point(197, 185);
            this.txtnombreusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(374, 30);
            this.txtnombreusuario.TabIndex = 4;
            // 
            // lblclaveusuario
            // 
            this.lblclaveusuario.AutoSize = true;
            this.lblclaveusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclaveusuario.Location = new System.Drawing.Point(46, 118);
            this.lblclaveusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclaveusuario.Name = "lblclaveusuario";
            this.lblclaveusuario.Size = new System.Drawing.Size(66, 23);
            this.lblclaveusuario.TabIndex = 3;
            this.lblclaveusuario.Text = "Clave:";
            // 
            // txtclaveusuario
            // 
            this.txtclaveusuario.Location = new System.Drawing.Point(197, 122);
            this.txtclaveusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtclaveusuario.Name = "txtclaveusuario";
            this.txtclaveusuario.Size = new System.Drawing.Size(374, 30);
            this.txtclaveusuario.TabIndex = 2;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(46, 58);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(82, 23);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(197, 62);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(148, 30);
            this.txtusuario.TabIndex = 0;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscarusuario);
            this.Controls.Add(this.lblBuscarusuario);
            this.Controls.Add(this.grdDatosusuario);
            this.Controls.Add(this.grbEdicionusuario);
            this.Controls.Add(this.grbNavegacionusuario);
            this.Controls.Add(this.grbDatosusuario);
            this.Name = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosusuario)).EndInit();
            this.grbEdicionusuario.ResumeLayout(false);
            this.grbNavegacionusuario.ResumeLayout(false);
            this.grbNavegacionusuario.PerformLayout();
            this.grbDatosusuario.ResumeLayout(false);
            this.grbDatosusuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscarusuario;
        private System.Windows.Forms.Label lblBuscarusuario;
        private System.Windows.Forms.DataGridView grdDatosusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.GroupBox grbEdicionusuario;
        private System.Windows.Forms.Button btnEliminarusuario;
        private System.Windows.Forms.Button btnModificarusuario;
        private System.Windows.Forms.Button btnNuevousuario;
        private System.Windows.Forms.GroupBox grbNavegacionusuario;
        private System.Windows.Forms.Label lblRegistrosusuario;
        private System.Windows.Forms.Button btnUltimousuario;
        private System.Windows.Forms.Button btnSiguienteusuario;
        private System.Windows.Forms.Button btnAnteriorusuario;
        private System.Windows.Forms.Button btnPrimerousuario;
        private System.Windows.Forms.GroupBox grbDatosusuario;
        private System.Windows.Forms.Label lblTelefonousuario;
        private System.Windows.Forms.TextBox txtTelefonousuario;
        private System.Windows.Forms.Label lblDireccionusuario;
        private System.Windows.Forms.TextBox txtDireccionusuario;
        private System.Windows.Forms.Label lblNombreusuario;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.Label lblclaveusuario;
        private System.Windows.Forms.TextBox txtclaveusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
    }
}