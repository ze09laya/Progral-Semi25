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
                respuesta = (num1 / num2) * 100;
            }

            if (optFactorial.Checked)
            {
                int factorial = (int)num1;
                for (int i = (int)num1 - 1; i>1; i--) {  //5!=5*4*3*2=12
                    factorial *= i;

                }
                respuesta = factorial;
            }
            lblrespuesta.Text = "Respuesta: " + respuesta;

            if (optExponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }

            if (optPrimo.Checked){
                int i = 1, acum = 0;
                while (i <= num1 && acum<3) {
                    if (num1%i==0) {
                        acum++; //acum = acum;
                    }
                    i++;
            }
            if (acum <= 2){
                lblrespuesta.Text = "Respuesta: " + num1 + " es primo";
            }else {
                lblrespuesta.Text = "Respuesta: " + num1 + " no es primo";
                }
            }



            //Porcentaje
            //Factorial. 5! = 5x4x3x3x1=120
            //Modulo

            
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularopciones_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);
            double respuesta = 0;

            switch (cboOpciones.SelectedIndex)
            {
                case 0: // Suma
                    respuesta = num1 + num2;
                    lblrespuesta.Text = "Respuesta: " + respuesta;
                    break;

                case 1: // Resta
                    respuesta = num1 - num2;
                    lblrespuesta.Text = "Respuesta: " + respuesta;
                    break;

                case 2: // Multiplicación
                    respuesta = num1 * num2;
                    lblrespuesta.Text = "Respuesta: " + respuesta;
                    break;

                case 3: // División
                    if (num2 != 0)
                    {
                        respuesta = num1 / num2;
                        lblrespuesta.Text = "Respuesta: " + respuesta;
                    }
                    else
                    {
                        lblrespuesta.Text = "Error: División por cero";
                    }
                    break;

                case 4: // Exponente (potencia)
                    respuesta = Math.Pow(num1, num2);
                    lblrespuesta.Text = "Respuesta: " + respuesta;
                    break;

                case 5: // Porcentaje
                   
                        respuesta = (num1 / num2) * 100;
                        lblrespuesta.Text = "Respuesta: " + respuesta;
                    break;

                case 6: // Verificar si es primo
                    if (num1 < 2)
                    {
                        lblrespuesta.Text = "Respuesta: " + num1 + " no es primo";
                    }
                    else
                    {
                        int acum = 0;
                        for (int i = 1; i <= (int)num1; i++)
                        {
                            if ((int)num1 % i == 0)
                                acum++;
                        }

                        if (acum == 2)
                            lblrespuesta.Text = "Respuesta: " + num1 + " es primo";
                        else
                            lblrespuesta.Text = "Respuesta: " + num1 + " no es primo";
                    }
                    break;

                case 7: // Factorial
                    if (num1 < 0)
                    {
                        lblrespuesta.Text = "Error: Factorial de número negativo";
                    }
                    else
                    {
                        respuesta = 1;
                        for (int i = 1; i <= (int)num1; i++)
                        {
                            respuesta *= i;
                        }
                        lblrespuesta.Text = "Respuesta: " + respuesta;
                    }
                    break;

                default:
                    lblrespuesta.Text = "Seleccione una opción válida";
                    break;
            }
        }
    }
}






