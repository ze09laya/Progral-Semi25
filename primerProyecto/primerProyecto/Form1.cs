using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btncantidad_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtnum1.Text);
            num2 = Double.Parse(txtnum2.Text);
            if (optSuma.Checked)
            {
                respuesta = num1 + num2;
            }

            if (optResta.Checked)
            {
                respuesta = num1 - num2;
            }

            if (optMultiplicacion.Checked)
            {
                respuesta = num1 * num2;
            }

            if (optDivision.Checked)
            {
                respuesta = num1 / num2;
            }

            if (optExponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }


            if (optPorcentaje.Checked)
            {
                respuesta = num1 % num2;
            }

            //Porcentaje
            //Factorial. 5! = 5x4x3x3x1=120
            //Modulo

            lblrespuesta.Text = "Respuesta: " + respuesta;
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularopciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);
            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = Math.Pow(num1, num2);
                    break;

                case 4:
                    respuesta = num1 % num2;
                    break;

            }
            lblrespuesta.Text = "Respuesta: " + respuesta;
        }
    }
}
