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
    public partial class frmUsuarios : Form
    {
        conexion objConexion = new conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        string accion = "nuevo";

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.crearDs();
            if (!ds.Tables.Contains("usuario") || ds.Tables["usuario"].Rows.Count == 0)
            {
                miTabla = new DataTable();
                grdDatosusuario.DataSource = miTabla;
                limpiarCajas();
                return;
            }

            miTabla = ds.Tables["usuario"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdUsuario"] };
            grdDatosusuario.DataSource = miTabla;
            posicion = 0;
            mostrarDatosusuario();
        }

        private void mostrarDatosusuario()
        {
            if (miTabla.Rows.Count > 0 && posicion >= 0 && posicion < miTabla.Rows.Count)
            {
                txtusuario.Text = miTabla.Rows[posicion]["usuario"].ToString();
                txtclaveusuario.Text = miTabla.Rows[posicion]["clave"].ToString();
                txtnombreusuario.Text = miTabla.Rows[posicion]["nombre"].ToString();
                txtDireccionusuario.Text = miTabla.Rows[posicion]["direccion"].ToString();
                txtTelefonousuario.Text = miTabla.Rows[posicion]["telefono"].ToString();

                lblRegistrosusuario.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
            else
            {
                limpiarCajas();
            }
        }

        private void estadoControles(bool estado)
        {
            grbDatosusuario.Enabled = estado;
            grbNavegacionusuario.Enabled = !estado;
            btnEliminarusuario.Enabled = !estado;
        }

        private void limpiarCajas()
        {
            txtusuario.Text = "";
            txtclaveusuario.Text = "";
            txtnombreusuario.Text = "";
            txtDireccionusuario.Text = "";
            txtTelefonousuario.Text = "";
        }

        private void filtrarDatos(string filtro)
        {
            filtro = filtro.Replace("'", "''");
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = $"usuario LIKE '%{filtro}%' OR nombre LIKE '%{filtro}%' OR direccion LIKE '%{filtro}%' OR telefono LIKE '%{filtro}%' OR clave LIKE '%{filtro}%'";
            grdDatosusuario.DataSource = dv;
        }

        private void seleccionarusuario()
        {
            if (grdDatosusuario.CurrentRow == null || grdDatosusuario.CurrentRow.Cells["IdUsuario"].Value == null)
            {
                limpiarCajas();
                return;
            }

            string idUsuario = grdDatosusuario.CurrentRow.Cells["IdUsuario"].Value.ToString();
            DataRow filaEncontrada = miTabla.Rows.Find(idUsuario);

            if (filaEncontrada != null)
            {
                posicion = miTabla.Rows.IndexOf(filaEncontrada);
                mostrarDatosusuario();
            }
        }

        private void btnNuevousuario_Click(object sender, EventArgs e)
        {
            if (btnNuevousuario.Text == "Nuevo")
            {
                btnNuevousuario.Text = "Guardar";
                btnModificarusuario.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {
                string idUsuario = (accion == "nuevo") ? "0" : miTabla.Rows[posicion]["IdUsuario"].ToString();
                string[] usuario = {
                    accion,
                    idUsuario,
                    txtusuario.Text,
                    txtclaveusuario.Text,
                    txtnombreusuario.Text,
                    txtDireccionusuario.Text,
                    txtTelefonousuario.Text
                };

                string respuesta = objConexion.mantenimiento_usuarios(usuario);

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevousuario.Text = "Nuevo";
                    btnModificarusuario.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }

        private void btnModificarusuario_Click(object sender, EventArgs e)
        {
            if (btnModificarusuario.Text == "Modificar")
            {
                btnNuevousuario.Text = "Guardar";
                btnModificarusuario.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
            }
            else
            {
                btnNuevousuario.Text = "Nuevo";
                btnModificarusuario.Text = "Modificar";
                estadoControles(false);
                mostrarDatosusuario();
            }
        }

        private void btnEliminarusuario_Click(object sender, EventArgs e)
        {
            if (miTabla.Rows.Count == 0) return;

            if (MessageBox.Show($"¿Está seguro de eliminar a {txtnombreusuario.Text.Trim()}?",
                "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] usuario = { "eliminar", miTabla.Rows[posicion]["IdUsuario"].ToString() };
                string respuesta = objConexion.mantenimiento_usuarios(usuario);

                if (respuesta != "1")
                    MessageBox.Show(respuesta, "Error al eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void btnPrimerousuario_Click(object sender, EventArgs e)
        {
            if (miTabla.Rows.Count == 0) return;
            posicion = 0;
            mostrarDatosusuario();
        }

        private void btnUltimousuario_Click(object sender, EventArgs e)
        {
            if (miTabla.Rows.Count == 0) return;
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosusuario();
        }

        private void btnAnteriorusuario_Click(object sender, EventArgs e)
        {
            if (miTabla.Rows.Count == 0) return;

            if (posicion > 0)
            {
                posicion--;
                mostrarDatosusuario();
            }
        }

        private void btnSiguienteusuario_Click(object sender, EventArgs e)
        {
            if (miTabla.Rows.Count == 0) return;

            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosusuario();
            }
        }

        private void txtBuscarusuario_TextChanged(object sender, EventArgs e)
        {
            filtrarDatos(txtBuscarusuario.Text);
            seleccionarusuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdDatosusuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdDatosusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarusuario();
        }
    }
}