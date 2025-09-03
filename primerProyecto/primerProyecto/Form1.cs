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

        double[][] tabla = new double[][]{
            new double[]{0.01, 500, 1.5, 0},
            new double[]{500.01, 1000, 1.5, 3},
            new double[]{1000.01, 2000, 3, 3},
            new double[]{2000.01, 3000, 6, 3},
            new double[]{3000.01, 6000, 9, 2},
            new double[]{8000.01, 18000, 15, 2},
            new double[]{18000.01, 30000, 39, 2},
            new double[]{30000.01, 60000, 63, 1},
            new double[]{60000.01, 100000, 93, 0.8},
            new double[]{100000.01, 200000, 125, 0.7},
            new double[]{200000.01, 300000, 195, 0.6},
            new double[]{300000.01, 400000, 255, 0.45},
            new double[]{400000.01, 500000, 300, 0.4},
            new double[]{500000.01, 1000000, 340, 0.3},
            new double[]{1000000.01, 99999999, 490, 0.18}
 };
        private double CalcularImpuesto(double monto)
        {
            for (int i = 0; i < tabla.Length; i++)
            {
                double desde = tabla[i][0];
                double hasta = tabla[i][1];
                double precio = tabla[i][2];
                double adicional = tabla[i][3];

                if (monto >= desde && monto <= hasta)
                {
                    double exceso = monto - desde;
                    double excesoMiles = exceso / 1000;
                    return (excesoMiles * adicional) + precio;
                }
            }
            return 0;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double monto = double.Parse(txtMonto.Text);
                    double impuesto = CalcularImpuesto(monto);
                    lblResultado.Text = "Impuesto: $" + impuesto.ToString("N2");
                }
                catch (Exception ex)
                {
                    lblResultado.Text = "Error: " + ex.Message;
                }


            }
        }

    String[][] etiquetas = new string[][] {
    new string[]{"Metro Cuadrado", "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Manzana", "Tareas", "Hectarea"} //Área
};

    double[][] valores = new double[][] {
    new double[]{1, 10.7639, 0.705012, 1.19599, 1.0 / 7000, 1.0 / 437.5, 1e-4 }
};

 
        private double convertir(int de, int a, double cantidad)
        {
            if (cantidad <= 0)
            {
                return 0;
            }
            return cantidad * valores[0][a] / valores[0][de];
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidadConversor.Text);
                int de = cboDeConversor.SelectedIndex;
                int a = cboAConversor.SelectedIndex;
                double respuesta = convertir(de, a, cantidad);
                lblRespuestaConversor.Text = "Respuesta: " + respuesta.ToString("N2");
            }
            catch (Exception er)
            {
                lblRespuestaConversor.Text = "Error " + er.Message + " solo valores validos";
            }
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeConversor.Items.Clear();
            cboAConversor.Items.Clear();
            cboDeConversor.Items.AddRange(etiquetas[0]);
            cboAConversor.Items.AddRange(etiquetas[0]);
        }
    }
}
    









