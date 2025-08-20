using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtCantidad.Text);
            double resultado = 0;

            if (optDolar.Checked) resultado = cantidad * 1.00;
            if (optEuro.Checked) resultado = cantidad * 0.86;
            if (optMexico.Checked) resultado = cantidad * 18.84;
            if (optColonsalvadoreño.Checked) resultado = cantidad * 8.75;
            if (optQuetzal.Checked) resultado = cantidad * 7.67;
            if (optLempira.Checked) resultado = cantidad * 26.30;
            if (optCordoba.Checked) resultado = cantidad * 36.80;
            if (optColoncostarricense.Checked) resultado = cantidad * 505.16;
            if (optBalboa.Checked) resultado = cantidad * 1.00;
            if (optColombia.Checked) resultado = cantidad * 4033.63;

            if (optGramo.Checked) resultado = cantidad * 1;
            if (optKilogramo.Checked) resultado = cantidad * 1000;
            if (optMiligramo.Checked) resultado = cantidad / 1000;
            if (optTonelada.Checked) resultado = cantidad * 100000;
            if (optLibra.Checked) resultado = cantidad * 453.592;
            if (optOnza.Checked) resultado = cantidad * 28.35;
            if (optQuintal.Checked) resultado = cantidad * 100000;
            if (optStone.Checked) resultado = cantidad * 6350;
            if (optMicrogramo.Checked) resultado = cantidad * 1000000;
            if (optCarat.Checked) resultado = cantidad * 200;

            if (optLitro.Checked) resultado = cantidad * 1;
            if (optMililitro.Checked) resultado = cantidad * 1000;
            if (optMetrocúbico.Checked) resultado = cantidad * 100;
            if (optCentímetrocúbico.Checked) resultado = cantidad * 1;
            if (optGalón.Checked) resultado = cantidad * 3.785;
            if (optPinta.Checked) resultado = cantidad * 0.473;
            if (optOnzalíquida.Checked) resultado = cantidad * 0.029;
            if (optBarril.Checked) resultado = cantidad * 159;
            if (optDecilitro.Checked) resultado = cantidad * 10;
            if (optCucharada.Checked) resultado = cantidad * 0.015;
            lblResultado.Text = "Respuesta: " + resultado;

        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidad.Text);
                double resultado = 0;

    
                if (cboLongitud.SelectedItem != null)
                {
                    switch (cboLongitud.SelectedItem.ToString())
                    {
                        case "Metro": resultado = cantidad * 1; break;
                        case "Kilómetro": resultado = cantidad / 1000; break;
                        case "Centímetro": resultado = cantidad * 100; break;
                        case "Milímetro": resultado = cantidad * 1000; break;
                        case "Micrómetro": resultado = cantidad * 1e6; break;
                        case "Nanómetro": resultado = cantidad * 1e9; break;
                        case "Pulgada": resultado = cantidad * 39.37; break;
                        case "Pie": resultado = cantidad * 3.281; break;
                        case "Yarda": resultado = cantidad * 1.094; break;
                        case "Milla": resultado = cantidad * 0.000621; break;
                    }
                }

                if (cboAlmacenamiento.SelectedItem != null)
                {
                    switch (cboAlmacenamiento.SelectedItem.ToString())
                    {
                        case "Bit": resultado = cantidad * 1; break;
                        case "Byte": resultado = cantidad / 8; break;
                        case "Kilobyte": resultado = cantidad / 8000; break;
                        case "Megabyte": resultado = cantidad / 8e6; break;
                        case "Gigabyte": resultado = cantidad / 8e9; break;
                        case "Terabyte": resultado = cantidad / 8e12; break;
                        case "Petabyte": resultado = cantidad / 8e15; break;
                        case "Exabyte": resultado = cantidad / 8e18; break;
                        case "Zettabyte": resultado = cantidad / 8e21; break;
                        case "Yottabyte": resultado = cantidad / 8e24; break;
                    }
                }
                if (cboTiempo.SelectedItem != null)
                {
                    switch (cboTiempo.SelectedItem.ToString())
                    {
                        case "Segundo": resultado = cantidad * 1; break;
                        case "Minuto": resultado = cantidad / 60; break;
                        case "Hora": resultado = cantidad / 3600; break;
                        case "Día": resultado = cantidad / 86400; break;
                        case "Semana": resultado = cantidad / 604800; break;
                        case "Mes": resultado = cantidad / 2.629746e6; break;
                        case "Año": resultado = cantidad / 3.15576e7; break;
                        case "Década": resultado = cantidad / 3.15576e8; break;
                        case "Siglo": resultado = cantidad / 3.15576e9; break;
                        case "Milenio": resultado = cantidad / 3.15576e10; break;
                    }
                }

                lblResultado.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Ingresa un valor numérico válido.");
            }
        }
    }
}






