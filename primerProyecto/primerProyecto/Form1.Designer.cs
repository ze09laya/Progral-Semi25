namespace primerProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnum1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.btncantidad = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnCalcularopciones = new System.Windows.Forms.Button();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.optPorcentaje = new System.Windows.Forms.RadioButton();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optDivision = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(62, 38);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(66, 23);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Num1:";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(134, 38);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(161, 26);
            this.txtnum1.TabIndex = 1;
            // 
            // btncantidad
            // 
            this.btncantidad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncantidad.Location = new System.Drawing.Point(107, 179);
            this.btncantidad.Name = "btncantidad";
            this.btncantidad.Size = new System.Drawing.Size(120, 45);
            this.btncantidad.TabIndex = 2;
            this.btncantidad.Text = "Calcular";
            this.btncantidad.UseVisualStyleBackColor = true;
            this.btncantidad.Click += new System.EventHandler(this.btncantidad_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(134, 91);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(161, 26);
            this.txtnum2.TabIndex = 4;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(62, 94);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(66, 23);
            this.lblnum2.TabIndex = 3;
            this.lblnum2.Text = "Num2:";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(62, 133);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(119, 23);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "Respuesta: ?";
            // 
            // btnCalcularopciones
            // 
            this.btnCalcularopciones.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularopciones.Location = new System.Drawing.Point(557, 111);
            this.btnCalcularopciones.Name = "btnCalcularopciones";
            this.btnCalcularopciones.Size = new System.Drawing.Size(120, 45);
            this.btnCalcularopciones.TabIndex = 11;
            this.btnCalcularopciones.Text = "Calcular";
            this.btnCalcularopciones.UseVisualStyleBackColor = true;
            this.btnCalcularopciones.Click += new System.EventHandler(this.btnCalcularopciones_Click);
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Divicion",
            "Exponente",
            "Porcentaje"});
            this.cboOpciones.Location = new System.Drawing.Point(556, 50);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(121, 28);
            this.cboOpciones.TabIndex = 10;
            this.cboOpciones.SelectedIndexChanged += new System.EventHandler(this.cboOpciones_SelectedIndexChanged);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.optPorcentaje);
            this.gbOpciones.Controls.Add(this.optExponente);
            this.gbOpciones.Controls.Add(this.optDivision);
            this.gbOpciones.Controls.Add(this.optMultiplicacion);
            this.gbOpciones.Controls.Add(this.optResta);
            this.gbOpciones.Controls.Add(this.optSuma);
            this.gbOpciones.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(335, 38);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(196, 246);
            this.gbOpciones.TabIndex = 9;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // optPorcentaje
            // 
            this.optPorcentaje.AutoSize = true;
            this.optPorcentaje.Location = new System.Drawing.Point(18, 194);
            this.optPorcentaje.Name = "optPorcentaje";
            this.optPorcentaje.Size = new System.Drawing.Size(128, 27);
            this.optPorcentaje.TabIndex = 5;
            this.optPorcentaje.TabStop = true;
            this.optPorcentaje.Text = "Porcentaje";
            this.optPorcentaje.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(18, 160);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(125, 27);
            this.optExponente.TabIndex = 4;
            this.optExponente.TabStop = true;
            this.optExponente.Text = "Exponente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optDivision
            // 
            this.optDivision.AutoSize = true;
            this.optDivision.Location = new System.Drawing.Point(18, 126);
            this.optDivision.Name = "optDivision";
            this.optDivision.Size = new System.Drawing.Size(102, 27);
            this.optDivision.TabIndex = 3;
            this.optDivision.Text = "Division";
            this.optDivision.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(18, 95);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(153, 27);
            this.optMultiplicacion.TabIndex = 2;
            this.optMultiplicacion.Text = "Multiplicacion";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(18, 57);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(84, 27);
            this.optResta.TabIndex = 1;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Location = new System.Drawing.Point(18, 26);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(81, 27);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularopciones);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.btncantidad);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Hola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button btncantidad;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnCalcularopciones;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.RadioButton optPorcentaje;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.RadioButton optDivision;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
    }
}

