using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_SQL_AW
    {
        //VARIABLES GLOBALES
        SqlConnection sqlConector = new SqlConnection();

        public Datos_SQL_AW()
        {
            try
            {
                 this.sqlConector = new SqlConnection("Data Source="+ ConfigurationManager.AppSettings["DataSource"] + ";Initial Catalog=master;Integrated Security=True");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable QuerySQL_Server(String QueryDelUsuario)
        {
            try
            {
                SqlCommand cmd = sqlConector.CreateCommand();
                cmd.CommandText = QueryDelUsuario;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dtdatos = new DataTable();

                sqlConector.Open();

                adapter.Fill(dtdatos);

                return dtdatos;
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
            finally
            {
                sqlConector.Close();
            }

        }//fin querySQL_Server
        public DataSet QuerySQL_Server_DS(String QueryDelUsuario)
        {
            try
            {
                SqlCommand cmd = sqlConector.CreateCommand();
                cmd.CommandText = QueryDelUsuario;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                sqlConector.Open();

                adapter.Fill(ds);

                return ds;
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
            finally
            {
                sqlConector.Close();
            }

        }//fin querySQL_Server
        public Boolean probarConexionSQLServerAW()
        {
            try
            {
                //solo abrimos y cerramos la conexion para saber que el usuario viene bien 
                sqlConector.Open();

                return true;
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
            finally
            {
                sqlConector.Close();
            }

        }//fin querySQL_Server




    }//fin class
}///fn space
