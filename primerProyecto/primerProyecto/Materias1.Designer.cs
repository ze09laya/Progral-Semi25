namespace primerProyecto
{
    partial class Materias1
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
            this.grbBusquedaMaterias = new System.Windows.Forms.GroupBox();
            this.grdMaterias = new System.Windows.Forms.DataGridView();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.grbEdicionMaterias = new System.Windows.Forms.GroupBox();
            this.btnEliminarMaterias = new System.Windows.Forms.Button();
            this.btnModificarMaterias = new System.Windows.Forms.Button();
            this.btnAgregarMaterias = new System.Windows.Forms.Button();
            this.grbNavegacionMaterias = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosMaterias = new System.Windows.Forms.Label();
            this.btnUltimoMaterias = new System.Windows.Forms.Button();
            this.btnSiguienteMaterias = new System.Windows.Forms.Button();
            this.btnAnteriorMaterias = new System.Windows.Forms.Button();
            this.btnPrimeroMaterias = new System.Windows.Forms.Button();
            this.grbDatosMaterias = new System.Windows.Forms.GroupBox();
            this.idMaterias = new System.Windows.Forms.Label();
            this.lblIdlMaterias = new System.Windows.Forms.Label();
            this.txtUnidadMaterias = new System.Windows.Forms.TextBox();
            this.lblUnidadMaterias = new System.Windows.Forms.Label();
            this.txtNombreMaterias = new System.Windows.Forms.TextBox();
            this.lblNombreMaterias = new System.Windows.Forms.Label();
            this.txtCodigoMaterias = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterias = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboBuscarMaterias = new System.Windows.Forms.ComboBox();
            this.grbBusquedaMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).BeginInit();
            this.grbEdicionMaterias.SuspendLayout();
            this.grbNavegacionMaterias.SuspendLayout();
            this.grbDatosMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaMaterias
            // 
            this.grbBusquedaMaterias.Controls.Add(this.cboBuscarMaterias);
            this.grbBusquedaMaterias.Controls.Add(this.grdMaterias);
            this.grbBusquedaMaterias.Controls.Add(this.txtBuscarMaterias);
            this.grbBusquedaMaterias.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaMaterias.Location = new System.Drawing.Point(563, 38);
            this.grbBusquedaMaterias.Name = "grbBusquedaMaterias";
            this.grbBusquedaMaterias.Size = new System.Drawing.Size(866, 400);
            this.grbBusquedaMaterias.TabIndex = 9;
            this.grbBusquedaMaterias.TabStop = false;
            this.grbBusquedaMaterias.Text = "Busqueda Materias";
            // 
            // grdMaterias
            // 
            this.grdMaterias.AllowUserToAddRows = false;
            this.grdMaterias.AllowUserToDeleteRows = false;
            this.grdMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.codigo,
            this.nombre,
            this.unidad});
            this.grdMaterias.Location = new System.Drawing.Point(0, 95);
            this.grdMaterias.Name = "grdMaterias";
            this.grdMaterias.ReadOnly = true;
            this.grdMaterias.RowHeadersWidth = 62;
            this.grdMaterias.RowTemplate.Height = 28;
            this.grdMaterias.Size = new System.Drawing.Size(825, 266);
            this.grdMaterias.TabIndex = 11;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(218, 45);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(609, 30);
            this.txtBuscarMaterias.TabIndex = 10;
            this.txtBuscarMaterias.TextChanged += new System.EventHandler(this.txtBuscarMaterias_TextChanged);
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // grbEdicionMaterias
            // 
            this.grbEdicionMaterias.Controls.Add(this.btnEliminarMaterias);
            this.grbEdicionMaterias.Controls.Add(this.btnModificarMaterias);
            this.grbEdicionMaterias.Controls.Add(this.btnAgregarMaterias);
            this.grbEdicionMaterias.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionMaterias.Location = new System.Drawing.Point(549, 464);
            this.grbEdicionMaterias.Name = "grbEdicionMaterias";
            this.grbEdicionMaterias.Size = new System.Drawing.Size(489, 100);
            this.grbEdicionMaterias.TabIndex = 8;
            this.grbEdicionMaterias.TabStop = false;
            this.grbEdicionMaterias.Text = "Edicion";
            // 
            // btnEliminarMaterias
            // 
            this.btnEliminarMaterias.Location = new System.Drawing.Point(342, 36);
            this.btnEliminarMaterias.Name = "btnEliminarMaterias";
            this.btnEliminarMaterias.Size = new System.Drawing.Size(141, 49);
            this.btnEliminarMaterias.TabIndex = 2;
            this.btnEliminarMaterias.Text = "Eliminar";
            this.btnEliminarMaterias.UseVisualStyleBackColor = true;
            this.btnEliminarMaterias.Click += new System.EventHandler(this.btnEliminarMaterias_Click);
            // 
            // btnModificarMaterias
            // 
            this.btnModificarMaterias.Location = new System.Drawing.Point(185, 36);
            this.btnModificarMaterias.Name = "btnModificarMaterias";
            this.btnModificarMaterias.Size = new System.Drawing.Size(142, 49);
            this.btnModificarMaterias.TabIndex = 1;
            this.btnModificarMaterias.Text = "Modificar";
            this.btnModificarMaterias.UseVisualStyleBackColor = true;
            this.btnModificarMaterias.Click += new System.EventHandler(this.btnModificarMaterias_Click);
            // 
            // btnAgregarMaterias
            // 
            this.btnAgregarMaterias.Location = new System.Drawing.Point(24, 36);
            this.btnAgregarMaterias.Name = "btnAgregarMaterias";
            this.btnAgregarMaterias.Size = new System.Drawing.Size(155, 49);
            this.btnAgregarMaterias.TabIndex = 0;
            this.btnAgregarMaterias.Text = "Nuevo";
            this.btnAgregarMaterias.UseVisualStyleBackColor = true;
            this.btnAgregarMaterias.Click += new System.EventHandler(this.btnAgregarMaterias_Click);
            // 
            // grbNavegacionMaterias
            // 
            this.grbNavegacionMaterias.Controls.Add(this.lblnRegistrosMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnUltimoMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnSiguienteMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnAnteriorMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnPrimeroMaterias);
            this.grbNavegacionMaterias.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionMaterias.Location = new System.Drawing.Point(19, 464);
            this.grbNavegacionMaterias.Name = "grbNavegacionMaterias";
            this.grbNavegacionMaterias.Size = new System.Drawing.Size(489, 133);
            this.grbNavegacionMaterias.TabIndex = 7;
            this.grbNavegacionMaterias.TabStop = false;
            this.grbNavegacionMaterias.Text = "Navegacion";
            // 
            // lblnRegistrosMaterias
            // 
            this.lblnRegistrosMaterias.AutoSize = true;
            this.lblnRegistrosMaterias.Location = new System.Drawing.Point(184, 98);
            this.lblnRegistrosMaterias.Name = "lblnRegistrosMaterias";
            this.lblnRegistrosMaterias.Size = new System.Drawing.Size(67, 23);
            this.lblnRegistrosMaterias.TabIndex = 10;
            this.lblnRegistrosMaterias.Text = "X de N";
            // 
            // btnUltimoMaterias
            // 
            this.btnUltimoMaterias.Location = new System.Drawing.Point(346, 36);
            this.btnUltimoMaterias.Name = "btnUltimoMaterias";
            this.btnUltimoMaterias.Size = new System.Drawing.Size(92, 49);
            this.btnUltimoMaterias.TabIndex = 3;
            this.btnUltimoMaterias.Text = "Ultimo";
            this.btnUltimoMaterias.UseVisualStyleBackColor = true;
            this.btnUltimoMaterias.Click += new System.EventHandler(this.btnUltimoMaterias_Click);
            // 
            // btnSiguienteMaterias
            // 
            this.btnSiguienteMaterias.Location = new System.Drawing.Point(237, 36);
            this.btnSiguienteMaterias.Name = "btnSiguienteMaterias";
            this.btnSiguienteMaterias.Size = new System.Drawing.Size(103, 49);
            this.btnSiguienteMaterias.TabIndex = 2;
            this.btnSiguienteMaterias.Text = "Siguiente";
            this.btnSiguienteMaterias.UseVisualStyleBackColor = true;
            this.btnSiguienteMaterias.Click += new System.EventHandler(this.btnSiguienteMaterias_Click);
            // 
            // btnAnteriorMaterias
            // 
            this.btnAnteriorMaterias.Location = new System.Drawing.Point(140, 36);
            this.btnAnteriorMaterias.Name = "btnAnteriorMaterias";
            this.btnAnteriorMaterias.Size = new System.Drawing.Size(91, 49);
            this.btnAnteriorMaterias.TabIndex = 1;
            this.btnAnteriorMaterias.Text = "Anterior";
            this.btnAnteriorMaterias.UseVisualStyleBackColor = true;
            this.btnAnteriorMaterias.Click += new System.EventHandler(this.btnAnteriorMaterias_Click);
            // 
            // btnPrimeroMaterias
            // 
            this.btnPrimeroMaterias.Location = new System.Drawing.Point(33, 36);
            this.btnPrimeroMaterias.Name = "btnPrimeroMaterias";
            this.btnPrimeroMaterias.Size = new System.Drawing.Size(94, 49);
            this.btnPrimeroMaterias.TabIndex = 0;
            this.btnPrimeroMaterias.Text = "Primero";
            this.btnPrimeroMaterias.UseVisualStyleBackColor = true;
            this.btnPrimeroMaterias.Click += new System.EventHandler(this.btnPrimeroMaterias_Click);
            // 
            // grbDatosMaterias
            // 
            this.grbDatosMaterias.Controls.Add(this.idMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblIdlMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtUnidadMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblUnidadMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtNombreMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblNombreMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtCodigoMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblCodigoMaterias);
            this.grbDatosMaterias.Enabled = false;
            this.grbDatosMaterias.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosMaterias.Location = new System.Drawing.Point(19, 23);
            this.grbDatosMaterias.Name = "grbDatosMaterias";
            this.grbDatosMaterias.Size = new System.Drawing.Size(489, 324);
            this.grbDatosMaterias.TabIndex = 6;
            this.grbDatosMaterias.TabStop = false;
            this.grbDatosMaterias.Text = "Datos";
            this.grbDatosMaterias.Enter += new System.EventHandler(this.grbDatosMaterias_Enter);
            // 
            // idMaterias
            // 
            this.idMaterias.AutoSize = true;
            this.idMaterias.Location = new System.Drawing.Point(136, 67);
            this.idMaterias.Name = "idMaterias";
            this.idMaterias.Size = new System.Drawing.Size(31, 23);
            this.idMaterias.TabIndex = 9;
            this.idMaterias.Text = "ID";
            // 
            // lblIdlMaterias
            // 
            this.lblIdlMaterias.AutoSize = true;
            this.lblIdlMaterias.Location = new System.Drawing.Point(50, 67);
            this.lblIdlMaterias.Name = "lblIdlMaterias";
            this.lblIdlMaterias.Size = new System.Drawing.Size(38, 23);
            this.lblIdlMaterias.TabIndex = 6;
            this.lblIdlMaterias.Text = "ID:";
            // 
            // txtUnidadMaterias
            // 
            this.txtUnidadMaterias.Location = new System.Drawing.Point(237, 222);
            this.txtUnidadMaterias.Name = "txtUnidadMaterias";
            this.txtUnidadMaterias.Size = new System.Drawing.Size(184, 30);
            this.txtUnidadMaterias.TabIndex = 5;
            // 
            // lblUnidadMaterias
            // 
            this.lblUnidadMaterias.AutoSize = true;
            this.lblUnidadMaterias.Location = new System.Drawing.Point(51, 222);
            this.lblUnidadMaterias.Name = "lblUnidadMaterias";
            this.lblUnidadMaterias.Size = new System.Drawing.Size(76, 23);
            this.lblUnidadMaterias.TabIndex = 4;
            this.lblUnidadMaterias.Text = "Unidad:";
            // 
            // txtNombreMaterias
            // 
            this.txtNombreMaterias.Location = new System.Drawing.Point(237, 163);
            this.txtNombreMaterias.Name = "txtNombreMaterias";
            this.txtNombreMaterias.Size = new System.Drawing.Size(184, 30);
            this.txtNombreMaterias.TabIndex = 3;
            // 
            // lblNombreMaterias
            // 
            this.lblNombreMaterias.AutoSize = true;
            this.lblNombreMaterias.Location = new System.Drawing.Point(51, 163);
            this.lblNombreMaterias.Name = "lblNombreMaterias";
            this.lblNombreMaterias.Size = new System.Drawing.Size(84, 23);
            this.lblNombreMaterias.TabIndex = 2;
            this.lblNombreMaterias.Text = "Nombre:";
            // 
            // txtCodigoMaterias
            // 
            this.txtCodigoMaterias.Location = new System.Drawing.Point(237, 110);
            this.txtCodigoMaterias.Name = "txtCodigoMaterias";
            this.txtCodigoMaterias.Size = new System.Drawing.Size(184, 30);
            this.txtCodigoMaterias.TabIndex = 1;
            // 
            // lblCodigoMaterias
            // 
            this.lblCodigoMaterias.AutoSize = true;
            this.lblCodigoMaterias.Location = new System.Drawing.Point(51, 110);
            this.lblCodigoMaterias.Name = "lblCodigoMaterias";
            this.lblCodigoMaterias.Size = new System.Drawing.Size(76, 23);
            this.lblCodigoMaterias.TabIndex = 0;
            this.lblCodigoMaterias.Text = "Codigo:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idMaterias";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 200;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // unidad
            // 
            this.unidad.DataPropertyName = "unidad";
            this.unidad.HeaderText = "Unidad";
            this.unidad.MinimumWidth = 8;
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Width = 150;
            // 
            // cboBuscarMaterias
            // 
            this.cboBuscarMaterias.FormattingEnabled = true;
            this.cboBuscarMaterias.Items.AddRange(new object[] {
            "Codigo",
            "Materias"});
            this.cboBuscarMaterias.Location = new System.Drawing.Point(0, 46);
            this.cboBuscarMaterias.Name = "cboBuscarMaterias";
            this.cboBuscarMaterias.Size = new System.Drawing.Size(212, 31);
            this.cboBuscarMaterias.TabIndex = 12;
            // 
            // Materias1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 639);
            this.Controls.Add(this.grbBusquedaMaterias);
            this.Controls.Add(this.grbEdicionMaterias);
            this.Controls.Add(this.grbNavegacionMaterias);
            this.Controls.Add(this.grbDatosMaterias);
            this.Name = "Materias1";
            this.Text = "Materias1";
            this.Load += new System.EventHandler(this.Materias1_Load);
            this.grbBusquedaMaterias.ResumeLayout(false);
            this.grbBusquedaMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).EndInit();
            this.grbEdicionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.PerformLayout();
            this.grbDatosMaterias.ResumeLayout(false);
            this.grbDatosMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaMaterias;
        private System.Windows.Forms.DataGridView grdMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.GroupBox grbEdicionMaterias;
        private System.Windows.Forms.Button btnEliminarMaterias;
        private System.Windows.Forms.Button btnModificarMaterias;
        private System.Windows.Forms.Button btnAgregarMaterias;
        private System.Windows.Forms.GroupBox grbNavegacionMaterias;
        private System.Windows.Forms.Label lblnRegistrosMaterias;
        private System.Windows.Forms.Button btnUltimoMaterias;
        private System.Windows.Forms.Button btnSiguienteMaterias;
        private System.Windows.Forms.Button btnAnteriorMaterias;
        private System.Windows.Forms.Button btnPrimeroMaterias;
        private System.Windows.Forms.GroupBox grbDatosMaterias;
        private System.Windows.Forms.Label idMaterias;
        private System.Windows.Forms.Label lblIdlMaterias;
        private System.Windows.Forms.TextBox txtUnidadMaterias;
        private System.Windows.Forms.Label lblUnidadMaterias;
        private System.Windows.Forms.TextBox txtNombreMaterias;
        private System.Windows.Forms.Label lblNombreMaterias;
        private System.Windows.Forms.TextBox txtCodigoMaterias;
        private System.Windows.Forms.Label lblCodigoMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.ComboBox cboBuscarMaterias;
    }
}