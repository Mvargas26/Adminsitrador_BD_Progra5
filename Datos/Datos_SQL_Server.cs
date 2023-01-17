using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Datos_SQL_Server
    {
        //VARIABLES GLOBALES
        SqlConnection sqlConector = new SqlConnection();

        public Datos_SQL_Server()
        {
            try
            {
                StringBuilder StringConexionArmado = new StringBuilder();

                StringConexionArmado.Append("Data Source=");
                StringConexionArmado.Append(ConfigurationManager.AppSettings["DataSource_SqlSer"]);
                StringConexionArmado.Append(";Initial Catalog=");
                StringConexionArmado.Append(ConfigurationManager.AppSettings["InitialCatalog_SqlSer"]);
                StringConexionArmado.Append(";User=");
                StringConexionArmado.Append(ConfigurationManager.AppSettings["User_SqlSer"]);
                StringConexionArmado.Append(";Password=");
                StringConexionArmado.Append(ConfigurationManager.AppSettings["Password_SqlSer"]);

                this.sqlConector = new SqlConnection(StringConexionArmado.ToString());
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

        public Boolean probarConexionSQLServer()
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


    
}
