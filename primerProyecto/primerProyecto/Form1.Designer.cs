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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbMonedas = new System.Windows.Forms.GroupBox();
            this.optBalboa = new System.Windows.Forms.RadioButton();
            this.optColombia = new System.Windows.Forms.RadioButton();
            this.optLempira = new System.Windows.Forms.RadioButton();
            this.optCordoba = new System.Windows.Forms.RadioButton();
            this.optColoncostarricense = new System.Windows.Forms.RadioButton();
            this.optQuetzal = new System.Windows.Forms.RadioButton();
            this.optColonsalvadoreño = new System.Windows.Forms.RadioButton();
            this.optMexico = new System.Windows.Forms.RadioButton();
            this.optEuro = new System.Windows.Forms.RadioButton();
            this.optDolar = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbMasa = new System.Windows.Forms.GroupBox();
            this.optMicrogramo = new System.Windows.Forms.RadioButton();
            this.optCarat = new System.Windows.Forms.RadioButton();
            this.optOnza = new System.Windows.Forms.RadioButton();
            this.optQuintal = new System.Windows.Forms.RadioButton();
            this.optStone = new System.Windows.Forms.RadioButton();
            this.optLibra = new System.Windows.Forms.RadioButton();
            this.optTonelada = new System.Windows.Forms.RadioButton();
            this.optMiligramo = new System.Windows.Forms.RadioButton();
            this.optKilogramo = new System.Windows.Forms.RadioButton();
            this.optGramo = new System.Windows.Forms.RadioButton();
            this.gbVolumen = new System.Windows.Forms.GroupBox();
            this.optDecilitro = new System.Windows.Forms.RadioButton();
            this.optCucharada = new System.Windows.Forms.RadioButton();
            this.optPinta = new System.Windows.Forms.RadioButton();
            this.optOnzalíquida = new System.Windows.Forms.RadioButton();
            this.optBarril = new System.Windows.Forms.RadioButton();
            this.optGalón = new System.Windows.Forms.RadioButton();
            this.optCentímetrocúbico = new System.Windows.Forms.RadioButton();
            this.optMetrocúbico = new System.Windows.Forms.RadioButton();
            this.optMililitro = new System.Windows.Forms.RadioButton();
            this.optLitro = new System.Windows.Forms.RadioButton();
            this.cboLongitud = new System.Windows.Forms.ComboBox();
            this.cboAlmacenamiento = new System.Windows.Forms.ComboBox();
            this.cboTiempo = new System.Windows.Forms.ComboBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.gbMonedas.SuspendLayout();
            this.gbMasa.SuspendLayout();
            this.gbVolumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(665, 484);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(186, 92);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbMonedas
            // 
            this.gbMonedas.Controls.Add(this.optBalboa);
            this.gbMonedas.Controls.Add(this.optColombia);
            this.gbMonedas.Controls.Add(this.optLempira);
            this.gbMonedas.Controls.Add(this.optCordoba);
            this.gbMonedas.Controls.Add(this.optColoncostarricense);
            this.gbMonedas.Controls.Add(this.optQuetzal);
            this.gbMonedas.Controls.Add(this.optColonsalvadoreño);
            this.gbMonedas.Controls.Add(this.optMexico);
            this.gbMonedas.Controls.Add(this.optEuro);
            this.gbMonedas.Controls.Add(this.optDolar);
            this.gbMonedas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMonedas.Location = new System.Drawing.Point(309, 93);
            this.gbMonedas.Name = "gbMonedas";
            this.gbMonedas.Size = new System.Drawing.Size(269, 333);
            this.gbMonedas.TabIndex = 1;
            this.gbMonedas.TabStop = false;
            this.gbMonedas.Text = "Monedas";
            // 
            // optBalboa
            // 
            this.optBalboa.AutoSize = true;
            this.optBalboa.Location = new System.Drawing.Point(14, 253);
            this.optBalboa.Name = "optBalboa";
            this.optBalboa.Size = new System.Drawing.Size(184, 27);
            this.optBalboa.TabIndex = 9;
            this.optBalboa.TabStop = true;
            this.optBalboa.Text = "Balboa panameño";
            this.optBalboa.UseVisualStyleBackColor = true;
            // 
            // optColombia
            // 
            this.optColombia.AutoSize = true;
            this.optColombia.Location = new System.Drawing.Point(14, 283);
            this.optColombia.Name = "optColombia";
            this.optColombia.Size = new System.Drawing.Size(174, 27);
            this.optColombia.TabIndex = 8;
            this.optColombia.TabStop = true;
            this.optColombia.Text = "Peso colombiano";
            this.optColombia.UseVisualStyleBackColor = true;
            // 
            // optLempira
            // 
            this.optLempira.AutoSize = true;
            this.optLempira.Location = new System.Drawing.Point(14, 171);
            this.optLempira.Name = "optLempira";
            this.optLempira.Size = new System.Drawing.Size(200, 27);
            this.optLempira.TabIndex = 7;
            this.optLempira.TabStop = true;
            this.optLempira.Text = "Lempira hondureño";
            this.optLempira.UseVisualStyleBackColor = true;
            // 
            // optCordoba
            // 
            this.optCordoba.AutoSize = true;
            this.optCordoba.Location = new System.Drawing.Point(13, 199);
            this.optCordoba.Name = "optCordoba";
            this.optCordoba.Size = new System.Drawing.Size(223, 27);
            this.optCordoba.TabIndex = 6;
            this.optCordoba.TabStop = true;
            this.optCordoba.Text = "Córdoba nicaragüense";
            this.optCordoba.UseVisualStyleBackColor = true;
            // 
            // optColoncostarricense
            // 
            this.optColoncostarricense.AutoSize = true;
            this.optColoncostarricense.Location = new System.Drawing.Point(13, 227);
            this.optColoncostarricense.Name = "optColoncostarricense";
            this.optColoncostarricense.Size = new System.Drawing.Size(201, 27);
            this.optColoncostarricense.TabIndex = 5;
            this.optColoncostarricense.TabStop = true;
            this.optColoncostarricense.Text = "Colón costarricense";
            this.optColoncostarricense.UseVisualStyleBackColor = true;
            // 
            // optQuetzal
            // 
            this.optQuetzal.AutoSize = true;
            this.optQuetzal.Location = new System.Drawing.Point(14, 145);
            this.optQuetzal.Name = "optQuetzal";
            this.optQuetzal.Size = new System.Drawing.Size(221, 27);
            this.optQuetzal.TabIndex = 4;
            this.optQuetzal.TabStop = true;
            this.optQuetzal.Text = "Quetzal guatemalteco";
            this.optQuetzal.UseVisualStyleBackColor = true;
            // 
            // optColonsalvadoreño
            // 
            this.optColonsalvadoreño.AutoSize = true;
            this.optColonsalvadoreño.Location = new System.Drawing.Point(14, 117);
            this.optColonsalvadoreño.Name = "optColonsalvadoreño";
            this.optColonsalvadoreño.Size = new System.Drawing.Size(191, 27);
            this.optColonsalvadoreño.TabIndex = 3;
            this.optColonsalvadoreño.TabStop = true;
            this.optColonsalvadoreño.Text = "Colón salvadoreño";
            this.optColonsalvadoreño.UseVisualStyleBackColor = true;
            // 
            // optMexico
            // 
            this.optMexico.AutoSize = true;
            this.optMexico.Location = new System.Drawing.Point(14, 89);
            this.optMexico.Name = "optMexico";
            this.optMexico.Size = new System.Drawing.Size(162, 27);
            this.optMexico.TabIndex = 2;
            this.optMexico.TabStop = true;
            this.optMexico.Text = "Peso Mexicano";
            this.optMexico.UseVisualStyleBackColor = true;
            // 
            // optEuro
            // 
            this.optEuro.AutoSize = true;
            this.optEuro.Location = new System.Drawing.Point(13, 63);
            this.optEuro.Name = "optEuro";
            this.optEuro.Size = new System.Drawing.Size(76, 27);
            this.optEuro.TabIndex = 1;
            this.optEuro.TabStop = true;
            this.optEuro.Text = "Euro";
            this.optEuro.UseVisualStyleBackColor = true;
            // 
            // optDolar
            // 
            this.optDolar.AutoSize = true;
            this.optDolar.Location = new System.Drawing.Point(13, 36);
            this.optDolar.Name = "optDolar";
            this.optDolar.Size = new System.Drawing.Size(215, 27);
            this.optDolar.TabIndex = 0;
            this.optDolar.TabStop = true;
            this.optDolar.Text = "Dólar estadounidense";
            this.optDolar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(18, 93);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 25);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(128, 94);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(159, 26);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(18, 136);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(112, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // gbMasa
            // 
            this.gbMasa.Controls.Add(this.optMicrogramo);
            this.gbMasa.Controls.Add(this.optCarat);
            this.gbMasa.Controls.Add(this.optOnza);
            this.gbMasa.Controls.Add(this.optQuintal);
            this.gbMasa.Controls.Add(this.optStone);
            this.gbMasa.Controls.Add(this.optLibra);
            this.gbMasa.Controls.Add(this.optTonelada);
            this.gbMasa.Controls.Add(this.optMiligramo);
            this.gbMasa.Controls.Add(this.optKilogramo);
            this.gbMasa.Controls.Add(this.optGramo);
            this.gbMasa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMasa.Location = new System.Drawing.Point(616, 94);
            this.gbMasa.Name = "gbMasa";
            this.gbMasa.Size = new System.Drawing.Size(269, 332);
            this.gbMasa.TabIndex = 10;
            this.gbMasa.TabStop = false;
            this.gbMasa.Text = "Masa";
            // 
            // optMicrogramo
            // 
            this.optMicrogramo.AutoSize = true;
            this.optMicrogramo.Location = new System.Drawing.Point(14, 256);
            this.optMicrogramo.Name = "optMicrogramo";
            this.optMicrogramo.Size = new System.Drawing.Size(138, 27);
            this.optMicrogramo.TabIndex = 9;
            this.optMicrogramo.TabStop = true;
            this.optMicrogramo.Text = "Microgramo";
            this.optMicrogramo.UseVisualStyleBackColor = true;
            // 
            // optCarat
            // 
            this.optCarat.AutoSize = true;
            this.optCarat.Location = new System.Drawing.Point(14, 286);
            this.optCarat.Name = "optCarat";
            this.optCarat.Size = new System.Drawing.Size(84, 27);
            this.optCarat.TabIndex = 8;
            this.optCarat.TabStop = true;
            this.optCarat.Text = "Carat";
            this.optCarat.UseVisualStyleBackColor = true;
            // 
            // optOnza
            // 
            this.optOnza.AutoSize = true;
            this.optOnza.Location = new System.Drawing.Point(14, 173);
            this.optOnza.Name = "optOnza";
            this.optOnza.Size = new System.Drawing.Size(81, 27);
            this.optOnza.TabIndex = 7;
            this.optOnza.TabStop = true;
            this.optOnza.Text = "Onza";
            this.optOnza.UseVisualStyleBackColor = true;
            // 
            // optQuintal
            // 
            this.optQuintal.AutoSize = true;
            this.optQuintal.Location = new System.Drawing.Point(13, 198);
            this.optQuintal.Name = "optQuintal";
            this.optQuintal.Size = new System.Drawing.Size(98, 27);
            this.optQuintal.TabIndex = 6;
            this.optQuintal.TabStop = true;
            this.optQuintal.Text = "Quintal";
            this.optQuintal.UseVisualStyleBackColor = true;
            // 
            // optStone
            // 
            this.optStone.AutoSize = true;
            this.optStone.Location = new System.Drawing.Point(13, 226);
            this.optStone.Name = "optStone";
            this.optStone.Size = new System.Drawing.Size(83, 27);
            this.optStone.TabIndex = 5;
            this.optStone.TabStop = true;
            this.optStone.Text = "Stone";
            this.optStone.UseVisualStyleBackColor = true;
            // 
            // optLibra
            // 
            this.optLibra.AutoSize = true;
            this.optLibra.Location = new System.Drawing.Point(14, 148);
            this.optLibra.Name = "optLibra";
            this.optLibra.Size = new System.Drawing.Size(81, 27);
            this.optLibra.TabIndex = 4;
            this.optLibra.TabStop = true;
            this.optLibra.Text = "Libra";
            this.optLibra.UseVisualStyleBackColor = true;
            // 
            // optTonelada
            // 
            this.optTonelada.AutoSize = true;
            this.optTonelada.Location = new System.Drawing.Point(14, 121);
            this.optTonelada.Name = "optTonelada";
            this.optTonelada.Size = new System.Drawing.Size(111, 27);
            this.optTonelada.TabIndex = 3;
            this.optTonelada.TabStop = true;
            this.optTonelada.Text = "Tonelada";
            this.optTonelada.UseVisualStyleBackColor = true;
            // 
            // optMiligramo
            // 
            this.optMiligramo.AutoSize = true;
            this.optMiligramo.Location = new System.Drawing.Point(14, 94);
            this.optMiligramo.Name = "optMiligramo";
            this.optMiligramo.Size = new System.Drawing.Size(121, 27);
            this.optMiligramo.TabIndex = 2;
            this.optMiligramo.TabStop = true;
            this.optMiligramo.Text = "Miligramo";
            this.optMiligramo.UseVisualStyleBackColor = true;
            // 
            // optKilogramo
            // 
            this.optKilogramo.AutoSize = true;
            this.optKilogramo.Location = new System.Drawing.Point(13, 68);
            this.optKilogramo.Name = "optKilogramo";
            this.optKilogramo.Size = new System.Drawing.Size(122, 27);
            this.optKilogramo.TabIndex = 1;
            this.optKilogramo.TabStop = true;
            this.optKilogramo.Text = "Kilogramo";
            this.optKilogramo.UseVisualStyleBackColor = true;
            // 
            // optGramo
            // 
            this.optGramo.AutoSize = true;
            this.optGramo.Location = new System.Drawing.Point(13, 43);
            this.optGramo.Name = "optGramo";
            this.optGramo.Size = new System.Drawing.Size(94, 27);
            this.optGramo.TabIndex = 0;
            this.optGramo.TabStop = true;
            this.optGramo.Text = "Gramo";
            this.optGramo.UseVisualStyleBackColor = true;
            // 
            // gbVolumen
            // 
            this.gbVolumen.Controls.Add(this.optDecilitro);
            this.gbVolumen.Controls.Add(this.optCucharada);
            this.gbVolumen.Controls.Add(this.optPinta);
            this.gbVolumen.Controls.Add(this.optOnzalíquida);
            this.gbVolumen.Controls.Add(this.optBarril);
            this.gbVolumen.Controls.Add(this.optGalón);
            this.gbVolumen.Controls.Add(this.optCentímetrocúbico);
            this.gbVolumen.Controls.Add(this.optMetrocúbico);
            this.gbVolumen.Controls.Add(this.optMililitro);
            this.gbVolumen.Controls.Add(this.optLitro);
            this.gbVolumen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVolumen.Location = new System.Drawing.Point(913, 94);
            this.gbVolumen.Name = "gbVolumen";
            this.gbVolumen.Size = new System.Drawing.Size(269, 332);
            this.gbVolumen.TabIndex = 11;
            this.gbVolumen.TabStop = false;
            this.gbVolumen.Text = "Volumen";
            // 
            // optDecilitro
            // 
            this.optDecilitro.AutoSize = true;
            this.optDecilitro.Location = new System.Drawing.Point(14, 262);
            this.optDecilitro.Name = "optDecilitro";
            this.optDecilitro.Size = new System.Drawing.Size(108, 27);
            this.optDecilitro.TabIndex = 9;
            this.optDecilitro.TabStop = true;
            this.optDecilitro.Text = "Decilitro";
            this.optDecilitro.UseVisualStyleBackColor = true;
            // 
            // optCucharada
            // 
            this.optCucharada.AutoSize = true;
            this.optCucharada.Location = new System.Drawing.Point(14, 289);
            this.optCucharada.Name = "optCucharada";
            this.optCucharada.Size = new System.Drawing.Size(126, 27);
            this.optCucharada.TabIndex = 8;
            this.optCucharada.TabStop = true;
            this.optCucharada.Text = "Cucharada";
            this.optCucharada.UseVisualStyleBackColor = true;
            // 
            // optPinta
            // 
            this.optPinta.AutoSize = true;
            this.optPinta.Location = new System.Drawing.Point(14, 173);
            this.optPinta.Name = "optPinta";
            this.optPinta.Size = new System.Drawing.Size(79, 27);
            this.optPinta.TabIndex = 7;
            this.optPinta.TabStop = true;
            this.optPinta.Text = "Pinta";
            this.optPinta.UseVisualStyleBackColor = true;
            // 
            // optOnzalíquida
            // 
            this.optOnzalíquida.AutoSize = true;
            this.optOnzalíquida.Location = new System.Drawing.Point(13, 201);
            this.optOnzalíquida.Name = "optOnzalíquida";
            this.optOnzalíquida.Size = new System.Drawing.Size(142, 27);
            this.optOnzalíquida.TabIndex = 6;
            this.optOnzalíquida.TabStop = true;
            this.optOnzalíquida.Text = "Onza líquida";
            this.optOnzalíquida.UseVisualStyleBackColor = true;
            // 
            // optBarril
            // 
            this.optBarril.AutoSize = true;
            this.optBarril.Location = new System.Drawing.Point(13, 231);
            this.optBarril.Name = "optBarril";
            this.optBarril.Size = new System.Drawing.Size(84, 27);
            this.optBarril.TabIndex = 5;
            this.optBarril.TabStop = true;
            this.optBarril.Text = "Barril";
            this.optBarril.UseVisualStyleBackColor = true;
            // 
            // optGalón
            // 
            this.optGalón.AutoSize = true;
            this.optGalón.Location = new System.Drawing.Point(14, 148);
            this.optGalón.Name = "optGalón";
            this.optGalón.Size = new System.Drawing.Size(86, 27);
            this.optGalón.TabIndex = 4;
            this.optGalón.TabStop = true;
            this.optGalón.Text = "Galón";
            this.optGalón.UseVisualStyleBackColor = true;
            // 
            // optCentímetrocúbico
            // 
            this.optCentímetrocúbico.AutoSize = true;
            this.optCentímetrocúbico.Location = new System.Drawing.Point(14, 121);
            this.optCentímetrocúbico.Name = "optCentímetrocúbico";
            this.optCentímetrocúbico.Size = new System.Drawing.Size(191, 27);
            this.optCentímetrocúbico.TabIndex = 3;
            this.optCentímetrocúbico.TabStop = true;
            this.optCentímetrocúbico.Text = "Centímetro cúbico";
            this.optCentímetrocúbico.UseVisualStyleBackColor = true;
            // 
            // optMetrocúbico
            // 
            this.optMetrocúbico.AutoSize = true;
            this.optMetrocúbico.Location = new System.Drawing.Point(14, 94);
            this.optMetrocúbico.Name = "optMetrocúbico";
            this.optMetrocúbico.Size = new System.Drawing.Size(147, 27);
            this.optMetrocúbico.TabIndex = 2;
            this.optMetrocúbico.TabStop = true;
            this.optMetrocúbico.Text = "Metro cúbico";
            this.optMetrocúbico.UseVisualStyleBackColor = true;
            // 
            // optMililitro
            // 
            this.optMililitro.AutoSize = true;
            this.optMililitro.Location = new System.Drawing.Point(13, 68);
            this.optMililitro.Name = "optMililitro";
            this.optMililitro.Size = new System.Drawing.Size(103, 27);
            this.optMililitro.TabIndex = 1;
            this.optMililitro.TabStop = true;
            this.optMililitro.Text = "Mililitro";
            this.optMililitro.UseVisualStyleBackColor = true;
            // 
            // optLitro
            // 
            this.optLitro.AutoSize = true;
            this.optLitro.Location = new System.Drawing.Point(13, 43);
            this.optLitro.Name = "optLitro";
            this.optLitro.Size = new System.Drawing.Size(78, 27);
            this.optLitro.TabIndex = 0;
            this.optLitro.TabStop = true;
            this.optLitro.Text = "Litro";
            this.optLitro.UseVisualStyleBackColor = true;
            // 
            // cboLongitud
            // 
            this.cboLongitud.FormattingEnabled = true;
            this.cboLongitud.Items.AddRange(new object[] {
            "Metro",
            "Kilómetro",
            "Centímetro ",
            "Milímetro",
            "Micrómetro ",
            "Nanómetro ",
            "Pulgada",
            "Pie",
            "Yarda ",
            "Milla"});
            this.cboLongitud.Location = new System.Drawing.Point(1440, 212);
            this.cboLongitud.Name = "cboLongitud";
            this.cboLongitud.Size = new System.Drawing.Size(187, 28);
            this.cboLongitud.TabIndex = 12;
            this.cboLongitud.TabStop = false;
            // 
            // cboAlmacenamiento
            // 
            this.cboAlmacenamiento.FormattingEnabled = true;
            this.cboAlmacenamiento.Items.AddRange(new object[] {
            "Bit",
            "Byte",
            "Kilobyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            "Petabyte",
            "Exabyte ",
            "Zettabyte",
            "Yottabyte"});
            this.cboAlmacenamiento.Location = new System.Drawing.Point(1440, 270);
            this.cboAlmacenamiento.Name = "cboAlmacenamiento";
            this.cboAlmacenamiento.Size = new System.Drawing.Size(187, 28);
            this.cboAlmacenamiento.TabIndex = 13;
            // 
            // cboTiempo
            // 
            this.cboTiempo.FormattingEnabled = true;
            this.cboTiempo.Items.AddRange(new object[] {
            "Segundo",
            "Minuto",
            "Hora",
            "Día",
            "Semana",
            "Mes",
            "Año",
            "Década",
            "Siglo",
            "Milenio"});
            this.cboTiempo.Location = new System.Drawing.Point(1440, 320);
            this.cboTiempo.Name = "cboTiempo";
            this.cboTiempo.Size = new System.Drawing.Size(187, 28);
            this.cboTiempo.TabIndex = 14;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.Location = new System.Drawing.Point(1252, 215);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(105, 25);
            this.lblLongitud.TabIndex = 15;
            this.lblLongitud.Text = "Longitud:";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(1252, 273);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(176, 25);
            this.lblAlmacenamiento.TabIndex = 16;
            this.lblAlmacenamiento.Text = "Almacenamiento:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(1252, 320);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(91, 25);
            this.lblTiempo.TabIndex = 17;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.BackColor = System.Drawing.SystemColors.Info;
            this.btnRespuesta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta.Location = new System.Drawing.Point(1381, 376);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(186, 92);
            this.btnRespuesta.TabIndex = 18;
            this.btnRespuesta.Text = "Calcular";
            this.btnRespuesta.UseVisualStyleBackColor = false;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 620);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.cboTiempo);
            this.Controls.Add(this.cboAlmacenamiento);
            this.Controls.Add(this.cboLongitud);
            this.Controls.Add(this.gbVolumen);
            this.Controls.Add(this.gbMasa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.gbMonedas);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Hola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMonedas.ResumeLayout(false);
            this.gbMonedas.PerformLayout();
            this.gbMasa.ResumeLayout(false);
            this.gbMasa.PerformLayout();
            this.gbVolumen.ResumeLayout(false);
            this.gbVolumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbMonedas;
        private System.Windows.Forms.RadioButton optDolar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton optEuro;
        private System.Windows.Forms.RadioButton optBalboa;
        private System.Windows.Forms.RadioButton optColombia;
        private System.Windows.Forms.RadioButton optLempira;
        private System.Windows.Forms.RadioButton optCordoba;
        private System.Windows.Forms.RadioButton optColoncostarricense;
        private System.Windows.Forms.RadioButton optQuetzal;
        private System.Windows.Forms.RadioButton optColonsalvadoreño;
        private System.Windows.Forms.RadioButton optMexico;
        private System.Windows.Forms.GroupBox gbMasa;
        private System.Windows.Forms.RadioButton optMicrogramo;
        private System.Windows.Forms.RadioButton optCarat;
        private System.Windows.Forms.RadioButton optOnza;
        private System.Windows.Forms.RadioButton optQuintal;
        private System.Windows.Forms.RadioButton optStone;
        private System.Windows.Forms.RadioButton optLibra;
        private System.Windows.Forms.RadioButton optTonelada;
        private System.Windows.Forms.RadioButton optMiligramo;
        private System.Windows.Forms.RadioButton optKilogramo;
        private System.Windows.Forms.RadioButton optGramo;
        private System.Windows.Forms.GroupBox gbVolumen;
        private System.Windows.Forms.RadioButton optDecilitro;
        private System.Windows.Forms.RadioButton optCucharada;
        private System.Windows.Forms.RadioButton optPinta;
        private System.Windows.Forms.RadioButton optOnzalíquida;
        private System.Windows.Forms.RadioButton optBarril;
        private System.Windows.Forms.RadioButton optGalón;
        private System.Windows.Forms.RadioButton optCentímetrocúbico;
        private System.Windows.Forms.RadioButton optMetrocúbico;
        private System.Windows.Forms.RadioButton optMililitro;
        private System.Windows.Forms.RadioButton optLitro;
        private System.Windows.Forms.ComboBox cboLongitud;
        private System.Windows.Forms.ComboBox cboAlmacenamiento;
        private System.Windows.Forms.ComboBox cboTiempo;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnRespuesta;
    }
}

