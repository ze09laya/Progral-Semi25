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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        Conexion1 objConexion = new Conexion1();
        DataSet objNotas = new DataSet();

        private void actualizarDs()
        {
            int IdMaterias = int.Parse(cboMateria.SelectedValue?.ToString() ?? "1");
            int idPeriodo = int.Parse(cboPeriodo.SelectedValue?.ToString() ?? "1");

            objNotas.Clear(); //Limpiar el DataSet

            objConexion.objAdaptador = new SqlDataAdapter("SELECT alumnos.nombre, dnotas.idDetalle, dnotas.idNota, dnotas.IdMaterias, " +
                 "dnotas.lab1, dnotas.lab2, dnotas.parcial, (dnotas.lab1*0.3 + dnotas.lab2*0.3 + dnotas.parcial*0.4) AS nf " +
                 "FROM dnotas INNER JOIN notas ON(notas.idNota=dnotas.idNota) INNER JOIN alumnos ON(alumnos.IdAlumno=notas.IdAlumno) " +
                 "WHERE notas.idPeriodo=" + idPeriodo + " AND dnotas.IdMaterias=" + IdMaterias, objConexion.objConexion);
            objConexion.objAdaptador.Fill(objNotas, "notasAlumnos");
        }
        private void actualizarGrid()
        {
            actualizarDs();
            dnotasDataGridView.DataSource = objNotas;
            dnotasDataGridView.DataMember = "notasAlumnos";
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.db_academicaDataSet.periodos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.db_academicaDataSet.Materias);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.dnotas' Puede moverla o quitarla según sea necesario.
            this.dnotasTableAdapter.dnotas(this.db_academicaDataSet.dnotas);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.notas(this.db_academicaDataSet.notas);


            actualizarGrid();
        }
   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nFilas = dnotasDataGridView.Rows.Count;
            for (int i = 0; i < nFilas; i++)
            {
                double lab1 = 0, lab2 = 0, parcial = 0;
                int idDetalle = int.Parse(dnotasDataGridView.Rows[i].Cells["idDetalle"]?.Value?.ToString() ?? "0");

                lab1 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab1"]?.Value?.ToString() ?? "0");
                lab2 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab2"]?.Value?.ToString() ?? "0");
                parcial = double.Parse(dnotasDataGridView.Rows[i].Cells["parcial"]?.Value?.ToString() ?? "0");

                string sql = "UPDATE dnotas SET lab1='" + lab1 + "', lab2='" + lab2 + "', parcial='" + parcial +
                    "' WHERE idDetalle='" + idDetalle + "'";
                String resp = objConexion.ejecutarSQL(sql);
                if (resp != "1")
                {
                    MessageBox.Show(resp, "Error al actualizar notas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actualizarGrid();
            }
        }

        private void cboMateria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void cboPeriodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
    }
    
