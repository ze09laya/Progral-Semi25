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
            double num1, num2, respuesta;
            num1 = Double.Parse( txtnum1.Text);
            num2 = Double.Parse(txtnum2.Text);
            respuesta = num1 + num2;
            lblrespuesta.Text = "Respuesta: " + respuesta;

        }
    }
}
