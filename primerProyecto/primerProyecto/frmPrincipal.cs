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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
          objAlumnos. MdiParent = this;
            objAlumnos.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docente1 objDocentes = new Docente1();
            objDocentes.MdiParent = this;
            objDocentes.Show();
           
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias1 objMaterias = new Materias1();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodos objPeriodo = new frmPeriodos();
            objPeriodo.MdiParent = this;
            objPeriodo.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas objNotas = new frmNotas();
            objNotas.MdiParent = this;
            objNotas.Show();
        }
    }
}
