using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerProyecto
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\parcial.mdf;Integrated Security=True");
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT* FROM Usuario where Usuario = '" + textBox1.Text + "' and clave ='" + textBox2.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                frmUsuarios frmbienvenido = new frmUsuarios();
                this.Hide();
                frmbienvenido.Show();
            }

            else
            {
                MessageBox.Show("Usuario o contaseña incorrectos");

            }

            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


    }

