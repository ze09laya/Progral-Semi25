using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerProyecto
{
    internal class conexion
    {
        private SqlConnection miConexion;
        private SqlCommand misComandos;

        public conexion()
        {
            string cadenaConexion =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\parcial.mdf;Integrated Security=True";

            miConexion = new SqlConnection(cadenaConexion);
            misComandos = new SqlCommand();

            try
            {
                if (miConexion.State != ConnectionState.Open)
                    miConexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        public DataSet crearDs()
        {
            DataSet dsUsuarios = new DataSet();
            try
            {
                string consulta = "SELECT * FROM usuario";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, miConexion);
                adaptador.Fill(dsUsuarios, "usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el DataSet: " + ex.Message);
            }
            return dsUsuarios;
        }

        private string procesar(string sql, SqlParameter[] parametros = null)
        {
            try
            {
                misComandos.Connection = miConexion;
                misComandos.CommandText = sql;
                misComandos.Parameters.Clear();

                if (parametros != null)
                    misComandos.Parameters.AddRange(parametros);

                return misComandos.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string mantenimiento_usuarios(string[] datos)
        {
            if (datos.Length < 2) return "Error: datos insuficientes";

            string sql = "";
            SqlParameter[] parametros = null;

            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO usuario(usuario, clave, nombre, direccion, telefono) " +
                      "VALUES(@usuario, @clave, @nombre, @direccion, @telefono)";

                parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario", datos[2]),
                    new SqlParameter("@clave", datos[3]),
                    new SqlParameter("@nombre", datos[4]),
                    new SqlParameter("@direccion", datos[5]),
                    new SqlParameter("@telefono", datos[6])
                };
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE usuario SET usuario=@usuario, clave=@clave, nombre=@nombre, direccion=@direccion, telefono=@telefono " +
                      "WHERE IdUsuario=@IdUsuario";

                parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario", datos[2]),
                    new SqlParameter("@clave", datos[3]),
                    new SqlParameter("@nombre", datos[4]),
                    new SqlParameter("@direccion", datos[5]),
                    new SqlParameter("@telefono", datos[6]),
                    new SqlParameter("@IdUsuario", datos[1])
                };
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM usuario WHERE IdUsuario=@IdUsuario";
                parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdUsuario", datos[1])
                };
            }

            return procesar(sql, parametros);
        }
    }
}