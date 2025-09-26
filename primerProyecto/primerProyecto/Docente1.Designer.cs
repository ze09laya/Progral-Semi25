namespace primerProyecto
{
    partial class Docente1
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
            this.grbBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.grdDocente = new System.Windows.Forms.DataGridView();
            this.txtBuscarDocente = new System.Windows.Forms.TextBox();
            this.grbEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosDocente = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimeroDocente = new System.Windows.Forms.Button();
            this.grbDatosDocente = new System.Windows.Forms.GroupBox();
            this.txtEspecialidadDocente = new System.Windows.Forms.TextBox();
            this.lblDocenteEspecialidad = new System.Windows.Forms.Label();
            this.idDocente = new System.Windows.Forms.Label();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.lblIdDocente = new System.Windows.Forms.Label();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.lblCodigoDocente = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).BeginInit();
            this.grbEdicionDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.grbDatosDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaDocente
            // 
            this.grbBusquedaDocente.Controls.Add(this.grdDocente);
            this.grbBusquedaDocente.Controls.Add(this.txtBuscarDocente);
            this.grbBusquedaDocente.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaDocente.Location = new System.Drawing.Point(556, 46);
            this.grbBusquedaDocente.Name = "grbBusquedaDocente";
            this.grbBusquedaDocente.Size = new System.Drawing.Size(866, 400);
            this.grbBusquedaDocente.TabIndex = 9;
            this.grbBusquedaDocente.TabStop = false;
            this.grbBusquedaDocente.Text = "Busqueda Docente";
            // 
            // grdDocente
            // 
            this.grdDocente.AllowUserToAddRows = false;
            this.grdDocente.AllowUserToDeleteRows = false;
            this.grdDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono,
            this.especialidad});
            this.grdDocente.Location = new System.Drawing.Point(6, 81);
            this.grdDocente.Name = "grdDocente";
            this.grdDocente.ReadOnly = true;
            this.grdDocente.RowHeadersWidth = 62;
            this.grdDocente.RowTemplate.Height = 28;
            this.grdDocente.Size = new System.Drawing.Size(825, 266);
            this.grdDocente.TabIndex = 11;
            // 
            // txtBuscarDocente
            // 
            this.txtBuscarDocente.Location = new System.Drawing.Point(10, 45);
            this.txtBuscarDocente.Name = "txtBuscarDocente";
            this.txtBuscarDocente.Size = new System.Drawing.Size(817, 30);
            this.txtBuscarDocente.TabIndex = 10;
            this.txtBuscarDocente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocente_KeyUp);
            // 
            // grbEdicionDocente
            // 
            this.grbEdicionDocente.Controls.Add(this.btnEliminarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnModificarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnAgregarDocente);
            this.grbEdicionDocente.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionDocente.Location = new System.Drawing.Point(542, 472);
            this.grbEdicionDocente.Name = "grbEdicionDocente";
            this.grbEdicionDocente.Size = new System.Drawing.Size(489, 100);
            this.grbEdicionDocente.TabIndex = 8;
            this.grbEdicionDocente.TabStop = false;
            this.grbEdicionDocente.Text = "Edicion";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(342, 36);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(141, 49);
            this.btnEliminarDocente.TabIndex = 2;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Location = new System.Drawing.Point(185, 36);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(142, 49);
            this.btnModificarDocente.TabIndex = 1;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(24, 36);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(155, 49);
            this.btnAgregarDocente.TabIndex = 0;
            this.btnAgregarDocente.Text = "Nuevo";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.lblnRegistrosDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnPrimeroDocente);
            this.grbNavegacionDocente.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionDocente.Location = new System.Drawing.Point(12, 472);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Size = new System.Drawing.Size(489, 133);
            this.grbNavegacionDocente.TabIndex = 7;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegacion";
            // 
            // lblnRegistrosDocente
            // 
            this.lblnRegistrosDocente.AutoSize = true;
            this.lblnRegistrosDocente.Location = new System.Drawing.Point(184, 98);
            this.lblnRegistrosDocente.Name = "lblnRegistrosDocente";
            this.lblnRegistrosDocente.Size = new System.Drawing.Size(67, 23);
            this.lblnRegistrosDocente.TabIndex = 10;
            this.lblnRegistrosDocente.Text = "X de N";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Location = new System.Drawing.Point(346, 36);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(92, 49);
            this.btnUltimoDocente.TabIndex = 3;
            this.btnUltimoDocente.Text = "Ultimo";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Location = new System.Drawing.Point(237, 36);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(103, 49);
            this.btnSiguienteDocente.TabIndex = 2;
            this.btnSiguienteDocente.Text = "Siguiente";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Location = new System.Drawing.Point(140, 36);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(91, 49);
            this.btnAnteriorDocente.TabIndex = 1;
            this.btnAnteriorDocente.Text = "Anterior";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPrimeroDocente
            // 
            this.btnPrimeroDocente.Location = new System.Drawing.Point(33, 36);
            this.btnPrimeroDocente.Name = "btnPrimeroDocente";
            this.btnPrimeroDocente.Size = new System.Drawing.Size(94, 49);
            this.btnPrimeroDocente.TabIndex = 0;
            this.btnPrimeroDocente.Text = "Primero";
            this.btnPrimeroDocente.UseVisualStyleBackColor = true;
            this.btnPrimeroDocente.Click += new System.EventHandler(this.btnPrimeroDocente_Click);
            // 
            // grbDatosDocente
            // 
            this.grbDatosDocente.Controls.Add(this.txtEspecialidadDocente);
            this.grbDatosDocente.Controls.Add(this.lblDocenteEspecialidad);
            this.grbDatosDocente.Controls.Add(this.idDocente);
            this.grbDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblIdDocente);
            this.grbDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocente.Controls.Add(this.lblNombreDocente);
            this.grbDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.lblCodigoDocente);
            this.grbDatosDocente.Enabled = false;
            this.grbDatosDocente.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosDocente.Location = new System.Drawing.Point(12, 31);
            this.grbDatosDocente.Name = "grbDatosDocente";
            this.grbDatosDocente.Size = new System.Drawing.Size(489, 415);
            this.grbDatosDocente.TabIndex = 6;
            this.grbDatosDocente.TabStop = false;
            this.grbDatosDocente.Text = "Datos";
            // 
            // txtEspecialidadDocente
            // 
            this.txtEspecialidadDocente.Location = new System.Drawing.Point(236, 325);
            this.txtEspecialidadDocente.Name = "txtEspecialidadDocente";
            this.txtEspecialidadDocente.Size = new System.Drawing.Size(184, 30);
            this.txtEspecialidadDocente.TabIndex = 11;
            // 
            // lblDocenteEspecialidad
            // 
            this.lblDocenteEspecialidad.AutoSize = true;
            this.lblDocenteEspecialidad.Location = new System.Drawing.Point(50, 325);
            this.lblDocenteEspecialidad.Name = "lblDocenteEspecialidad";
            this.lblDocenteEspecialidad.Size = new System.Drawing.Size(122, 23);
            this.lblDocenteEspecialidad.TabIndex = 10;
            this.lblDocenteEspecialidad.Text = "Especialidad:";
            // 
            // idDocente
            // 
            this.idDocente.AutoSize = true;
            this.idDocente.Location = new System.Drawing.Point(136, 67);
            this.idDocente.Name = "idDocente";
            this.idDocente.Size = new System.Drawing.Size(31, 23);
            this.idDocente.TabIndex = 9;
            this.idDocente.Text = "ID";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(237, 279);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(184, 30);
            this.txtTelefonoDocente.TabIndex = 8;
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Location = new System.Drawing.Point(51, 279);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(90, 23);
            this.lblTelefonoDocente.TabIndex = 7;
            this.lblTelefonoDocente.Text = "Telefono:";
            // 
            // lblIdDocente
            // 
            this.lblIdDocente.AutoSize = true;
            this.lblIdDocente.Location = new System.Drawing.Point(50, 67);
            this.lblIdDocente.Name = "lblIdDocente";
            this.lblIdDocente.Size = new System.Drawing.Size(38, 23);
            this.lblIdDocente.TabIndex = 6;
            this.lblIdDocente.Text = "ID:";
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(237, 222);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(184, 30);
            this.txtDireccionDocente.TabIndex = 5;
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Location = new System.Drawing.Point(51, 222);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(97, 23);
            this.lblDireccionDocente.TabIndex = 4;
            this.lblDireccionDocente.Text = "Direccion:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(237, 163);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(184, 30);
            this.txtNombreDocente.TabIndex = 3;
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Location = new System.Drawing.Point(51, 163);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(84, 23);
            this.lblNombreDocente.TabIndex = 2;
            this.lblNombreDocente.Text = "Nombre:";
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(237, 110);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(184, 30);
            this.txtCodigoDocente.TabIndex = 1;
            // 
            // lblCodigoDocente
            // 
            this.lblCodigoDocente.AutoSize = true;
            this.lblCodigoDocente.Location = new System.Drawing.Point(51, 110);
            this.lblCodigoDocente.Name = "lblCodigoDocente";
            this.lblCodigoDocente.Size = new System.Drawing.Size(76, 23);
            this.lblCodigoDocente.TabIndex = 0;
            this.lblCodigoDocente.Text = "Codigo:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idDocente";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
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
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 8;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.MinimumWidth = 8;
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            this.especialidad.Width = 150;
            // 
            // Docente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 687);
            this.Controls.Add(this.grbBusquedaDocente);
            this.Controls.Add(this.grbEdicionDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Controls.Add(this.grbDatosDocente);
            this.Name = "Docente1";
            this.Text = "Docente1";
            this.Load += new System.EventHandler(this.Docente1_Load);
            this.grbBusquedaDocente.ResumeLayout(false);
            this.grbBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).EndInit();
            this.grbEdicionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.grbDatosDocente.ResumeLayout(false);
            this.grbDatosDocente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaDocente;
        private System.Windows.Forms.DataGridView grdDocente;
        private System.Windows.Forms.TextBox txtBuscarDocente;
        private System.Windows.Forms.GroupBox grbEdicionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.Label lblnRegistrosDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimeroDocente;
        private System.Windows.Forms.GroupBox grbDatosDocente;
        private System.Windows.Forms.TextBox txtEspecialidadDocente;
        private System.Windows.Forms.Label lblDocenteEspecialidad;
        private System.Windows.Forms.Label idDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.Label lblIdDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.Label lblCodigoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
    }
}