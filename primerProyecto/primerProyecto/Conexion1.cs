using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerProyecto
{
    internal class Conexion1
    {
        SqlConnection objConexion = new SqlConnection();
        SqlCommand objComando = new SqlCommand();
        SqlDataAdapter objAdaptador = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        public Conexion1()
        {
            String cadenaConexion =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear();
            objComando.Connection = objConexion;
            objAdaptador.SelectCommand = objComando;

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");

            objComando.CommandText = "SELECT * FROM Materias";
            objAdaptador.Fill(objDs, "materias");

            objComando.CommandText = "SELECT * FROM Docente";
            objAdaptador.Fill(objDs, "Docente"); // ✅ ahora correctamente

            return objDs;
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) " +
                      "VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] +
                      "', direccion='" + datos[3] + "', telefono='" + datos[4] +
                      "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql, datos);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,unidad) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] +
                      "', unidad='" + datos[3] + "' WHERE idMaterias='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMaterias='" + datos[0] + "'";
            }

            return ejecutarSQL(sql, datos);
        }

        public string administrarDatosDocente(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Docente (codigo, nombre, direccion, telefono, especialidad) " +
                      "VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Docente SET codigo='" + datos[1] + "', nombre='" + datos[2] +
                      "', direccion='" + datos[3] + "', telefono='" + datos[4] +
                      "', especialidad='" + datos[5] + "' WHERE idDocente='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM Docente WHERE idDocente='" + datos[0] + "'";
            }
            return ejecutarSQL(sql, datos);
        }

        private String ejecutarSQL(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}