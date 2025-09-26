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
    public partial class Docente1 : Form
    {
        public Docente1()
        {
            InitializeComponent();
        }

        Conexion1 objConexion1 = new Conexion1();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion1.obtenerDatos();
            objDt = objDs.Tables["Docente"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] };
            grdDocente.DataSource = objDt.DefaultView;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();
                txtEspecialidadDocente.Text = objDt.Rows[posicion]["especialidad"].ToString();

                lblnRegistrosDocente.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void Docente1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocente.Text == "Nuevo")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] alumnos = {
                    idDocente.Text, txtCodigoDocente.Text, txtNombreDocente.Text, txtDireccionDocente.Text,
                    txtTelefonoDocente.Text, txtEspecialidadDocente.Text
                };
                String respuesta = objConexion1.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocente.Text,
               "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion1.administrarDatosAlumnos(
                    new String[] { idDocente.Text, "", "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar Docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
            }
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idDocente.Text = "";
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
            txtEspecialidadDocente.Text = "";
        }

        private void txtBuscarDocente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarDocente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "codigo LIKE '%" + valor + "%' OR nombre LIKE '%" + valor + "%'";
                grdDocente.DataSource = objDv;
                seleccionarDocente();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void seleccionarDocente()
        {
            try
            {
                if (grdDocente.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdDocente.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grdDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocente();
        }
    }
}