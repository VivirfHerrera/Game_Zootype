using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zootype
{
    public class DBConexion
    {
        public String miConexion;
        public SqlConnection sqlConexion;

        public DBConexion() // Constructor crea la Conexión
        {
            miConexion = "Data Source=	189.173.87.246; Initial Catalog=pdss1;"
             + " User Id= user; Password= macario;";

            //miConexion = "Data Source=localhost; Initial Catalog=NombreBaseDatos;"
            //                + " User Id=usuarioX; Password=contraseñaX;";

            sqlConexion = new SqlConnection(miConexion);
        }

        public SqlConnection ConectaSQL() // Realiza la conexión al servidor
        {
            if (sqlConexion.State == ConnectionState.Closed
                    || sqlConexion.State == ConnectionState.Broken)
            {
                sqlConexion.Open();
            }

            return sqlConexion;
        }

        public void DesconectaSQL()
        {
            if (sqlConexion.State == ConnectionState.Open)
            {
                sqlConexion.Close();
            }
        }

        public bool ejecutaUpdate(String query, SqlParameter[] parametros)
        {
            bool auxRegreso = false;
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlCommand comando = new SqlCommand(query, ConectaSQL());
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                int renglones = comando.ExecuteNonQuery(); // Ejecuta contra la BAse de Datos el query
                if (renglones <= 0) // No inserto ningún registro
                {
                    auxRegreso = false;
                }
                else
                {
                    auxRegreso = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Actualizar los registros. Error: "
                    + ex.ToString());
            }
            finally
            {
                DesconectaSQL();
            }

            return auxRegreso;
        }



        public bool ejecutaInsert(String query, SqlParameter[] parametros)
        {
            bool auxRegreso = false;
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlCommand comando = new SqlCommand(query, ConectaSQL());
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                // adaptador.InsertCommand = comando;
                int renglones = comando.ExecuteNonQuery(); // Ejecuta contra la BAse de Datos el query
                if (renglones <= 0) // No inserto ningún registro
                {
                    auxRegreso = false;
                }
                else
                {
                    auxRegreso = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al insertar el registro. Error: "
                    + ex.ToString());
            }
            finally
            {
                DesconectaSQL();
            }

            return auxRegreso;
        }

        public DataTable ejecutaSelect(String query, SqlParameter[] parametros)
        {
            DataSet ds = new DataSet(); // Conjunto de DataTable
            DataTable auxRegreso = new DataTable(); // Almacenamos los datos recibidos de la Base de datos
            SqlCommand comando = new SqlCommand(); // Recibe propiedas para realizar la conexión a la BD y ejecutar el query 
            SqlDataAdapter adaptador = new SqlDataAdapter(); // Llena información de DataSet y DataTable
            try
            {
                comando.CommandText = query; // Consulta hacia la Base de Datos
                comando.CommandType = CommandType.Text; // Es texto
                comando.Connection = ConectaSQL(); // Conecta a la base de datos por medio del método definido anteriormente                
                comando.Parameters.AddRange(parametros); // Agrega los parámetros
                comando.ExecuteNonQuery(); // Ejecuta el query contra la Base de datos
                adaptador.SelectCommand = comando; // Relaciona el DataAdapter con el SQLCommand
                adaptador.Fill(ds); // Llena el DataSet con información almacenada en el DataAdapter
                if (ds.Tables.Count > 0) // Verifico que exista al menos 1 Tabla en el DataSet
                    auxRegreso = ds.Tables[0]; // Asigno la primer tabla al DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el ejecutaSelect: " + ex.ToString());
            }
            finally
            {
                DesconectaSQL(); // Me desconecto de la Base de Datos
            }

            return auxRegreso; // Regreso el DataTable con Información
        }


        public bool ejecutaElimina(String query, SqlParameter[] parametros)
        {
            bool auxRegreso = false;
            try
            {
                SqlCommand comando = new SqlCommand(query, ConectaSQL());
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                int renglones = comando.ExecuteNonQuery(); // Ejecuta contra la Base de Datos el query
                if (renglones <= 0) // No eliminó ningún registro
                {
                    auxRegreso = false;
                }
                else
                {
                    auxRegreso = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Eliminar los registros. Error: "
                    + ex.ToString());
            }
            finally
            {
                DesconectaSQL();
            }

            return auxRegreso;
        }

       


        

       
    }
}
