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
    public partial class Materias1 : Form
    {
        public Materias1()
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
            objDt = objDs.Tables["Materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMaterias"] };
            grdMaterias.DataSource = objDt.DefaultView;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idMaterias.Text = objDt.Rows[posicion]["idMaterias"].ToString();
                txtCodigoMaterias.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreMaterias.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUnidadMaterias.Text = objDt.Rows[posicion]["unidad"].ToString();
                

                lblnRegistrosMaterias.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }


        private void Materias1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnUltimoMaterias_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnSiguienteMaterias_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorMaterias_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroMaterias_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAgregarMaterias_Click(object sender, EventArgs e)
        {
            if (btnAgregarMaterias.Text == "Nuevo")
            {
                btnAgregarMaterias.Text = "Guardar";
                btnModificarMaterias.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] Materias = {
                    idMaterias.Text, txtCodigoMaterias.Text, txtNombreMaterias.Text, txtUnidadMaterias.Text
                };
                String respuesta = objConexion1.administrarDatosMaterias(Materias, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarMaterias.Text = "Nuevo";
                    btnModificarMaterias.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnEliminarMaterias_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de eliminar a " + txtNombreMaterias.Text,
               "Eliminando Materias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion1.administrarDatosMaterias(
                    new String[] { idMaterias.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void btnModificarMaterias_Click(object sender, EventArgs e)
        {
            if (btnModificarMaterias.Text == "Modificar")
            {
                btnAgregarMaterias.Text = "Guardar";
                btnModificarMaterias.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarMaterias.Text = "Nuevo";
                btnModificarMaterias.Text = "Modificar";
            }
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosMaterias.Enabled = estado;
            grbNavegacionMaterias.Enabled = !estado;
            btnEliminarMaterias.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idMaterias.Text = "";
            txtCodigoMaterias.Text = "";
            txtNombreMaterias.Text = "";
            txtUnidadMaterias.Text = "";
        }

        private void txtBuscarMaterias_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarMaterias.Text);
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
                objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '" + valor + "%'";
                grdMaterias.DataSource = objDv;
                seleccionarMaterias();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void seleccionarMaterias()
        {
            try
            {
                if (grdMaterias.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdMaterias.CurrentRow.Cells["Id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtBuscarMaterias_TextChanged(object sender, EventArgs e)
        {
            seleccionarMaterias();
        }
    }
}
