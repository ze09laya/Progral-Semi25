namespace primerProyecto
{
    partial class frmNotas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblIdNota;
            System.Windows.Forms.Label lblMateria;
            System.Windows.Forms.Label lblPerido;
            System.Windows.Forms.Label lblFecha;
            this.db_academicaDataSet = new primerProyecto.db_academicaDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new primerProyecto.db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new primerProyecto.db_academicaDataSetTableAdapters.TableAdapterManager();
            this.dnotasTableAdapter = new primerProyecto.db_academicaDataSetTableAdapters.dnotasTableAdapter();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new primerProyecto.db_academicaDataSetTableAdapters.MateriasTableAdapter();
            this.periodosTableAdapter = new primerProyecto.db_academicaDataSetTableAdapters.periodosTableAdapter();
            this.idNotaLabel1 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dnotasDataGridView = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMaterias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblIdNota = new System.Windows.Forms.Label();
            lblMateria = new System.Windows.Forms.Label();
            lblPerido = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdNota
            // 
            lblIdNota.AutoSize = true;
            lblIdNota.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdNota.Location = new System.Drawing.Point(11, 52);
            lblIdNota.Name = "lblIdNota";
            lblIdNota.Size = new System.Drawing.Size(38, 23);
            lblIdNota.TabIndex = 1;
            lblIdNota.Text = "ID:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMateria.Location = new System.Drawing.Point(11, 81);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(85, 23);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Materia:";
            // 
            // lblPerido
            // 
            lblPerido.AutoSize = true;
            lblPerido.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPerido.Location = new System.Drawing.Point(11, 124);
            lblPerido.Name = "lblPerido";
            lblPerido.Size = new System.Drawing.Size(82, 23);
            lblPerido.TabIndex = 5;
            lblPerido.Text = "Periodo:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFecha.Location = new System.Drawing.Point(11, 168);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(67, 23);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha:";
            // 
            // db_academicaDataSet
            // 
            this.db_academicaDataSet.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dnotasTableAdapter = this.dnotasTableAdapter;
            this.tableAdapterManager.DocenteTableAdapter = null;
            this.tableAdapterManager.MateriasTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.periodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = primerProyecto.db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dnotasTableAdapter
            // 
            this.dnotasTableAdapter.ClearBeforeFill = true;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "periodos";
            this.periodosBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource1
            // 
            this.periodosBindingSource1.DataMember = "periodos";
            this.periodosBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // dnotasBindingSource
            // 
            this.dnotasBindingSource.DataMember = "fk_dnotas_notas";
            this.dnotasBindingSource.DataSource = this.notasBindingSource;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // idNotaLabel1
            // 
            this.idNotaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "idNota", true));
            this.idNotaLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNotaLabel1.Location = new System.Drawing.Point(165, 52);
            this.idNotaLabel1.Name = "idNotaLabel1";
            this.idNotaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idNotaLabel1.TabIndex = 2;
            this.idNotaLabel1.Text = "label1";
            // 
            // cboMateria
            // 
            this.cboMateria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiasBindingSource, "nombre", true));
            this.cboMateria.DataSource = this.materiasBindingSource;
            this.cboMateria.DisplayMember = "nombre";
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(165, 81);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(358, 31);
            this.cboMateria.TabIndex = 4;
            this.cboMateria.ValueMember = "IdMaterias";
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged_1);
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodosBindingSource, "periodo", true));
            this.cboPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.periodosBindingSource1, "idPeriodo", true));
            this.cboPeriodo.DataSource = this.periodosBindingSource;
            this.cboPeriodo.DisplayMember = "periodo";
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(165, 124);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(358, 31);
            this.cboPeriodo.TabIndex = 6;
            this.cboPeriodo.ValueMember = "idPeriodo";
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged_1);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(165, 167);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(358, 30);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(592, 105);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(244, 68);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dnotasDataGridView
            // 
            this.dnotasDataGridView.AllowUserToAddRows = false;
            this.dnotasDataGridView.AllowUserToDeleteRows = false;
            this.dnotasDataGridView.AutoGenerateColumns = false;
            this.dnotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.dataGridViewTextBoxColumn1,
            this.IdMaterias,
            this.dataGridViewTextBoxColumn2,
            this.alumno,
            this.lab1,
            this.lab2,
            this.parcial,
            this.nota_final});
            this.dnotasDataGridView.DataSource = this.dnotasBindingSource;
            this.dnotasDataGridView.Location = new System.Drawing.Point(13, 221);
            this.dnotasDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dnotasDataGridView.Name = "dnotasDataGridView";
            this.dnotasDataGridView.RowHeadersWidth = 62;
            this.dnotasDataGridView.Size = new System.Drawing.Size(854, 171);
            this.dnotasDataGridView.TabIndex = 13;
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "ID";
            this.idDetalle.MinimumWidth = 8;
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            this.idDetalle.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDetalle";
            this.dataGridViewTextBoxColumn1.HeaderText = "idDetalle";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // IdMaterias
            // 
            this.IdMaterias.DataPropertyName = "IdMaterias";
            this.IdMaterias.HeaderText = "IdMaterias";
            this.IdMaterias.MinimumWidth = 8;
            this.IdMaterias.Name = "IdMaterias";
            this.IdMaterias.Visible = false;
            this.IdMaterias.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idNota";
            this.dataGridViewTextBoxColumn2.HeaderText = "idNota";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "nombre";
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.MinimumWidth = 8;
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            this.alumno.Width = 200;
            // 
            // lab1
            // 
            this.lab1.DataPropertyName = "lab1";
            this.lab1.HeaderText = "lab1";
            this.lab1.MinimumWidth = 8;
            this.lab1.Name = "lab1";
            this.lab1.Width = 150;
            // 
            // lab2
            // 
            this.lab2.DataPropertyName = "lab2";
            this.lab2.HeaderText = "lab2";
            this.lab2.MinimumWidth = 8;
            this.lab2.Name = "lab2";
            this.lab2.Width = 150;
            // 
            // parcial
            // 
            this.parcial.DataPropertyName = "parcial";
            this.parcial.HeaderText = "parcial";
            this.parcial.MinimumWidth = 8;
            this.parcial.Name = "parcial";
            this.parcial.Width = 150;
            // 
            // nota_final
            // 
            this.nota_final.DataPropertyName = "nf";
            this.nota_final.HeaderText = "NF";
            this.nota_final.MinimumWidth = 8;
            this.nota_final.Name = "nota_final";
            this.nota_final.ReadOnly = true;
            this.nota_final.Width = 150;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 558);
            this.Controls.Add(this.dnotasDataGridView);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(lblFecha);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(lblPerido);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(lblMateria);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(lblIdNota);
            this.Controls.Add(this.idNotaLabel1);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private db_academicaDataSetTableAdapters.dnotasTableAdapter dnotasTableAdapter;
        private System.Windows.Forms.BindingSource dnotasBindingSource;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private db_academicaDataSetTableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private db_academicaDataSetTableAdapters.periodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.BindingSource periodosBindingSource1;
        private System.Windows.Forms.Label idNotaLabel1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dnotasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_final;
    }
}