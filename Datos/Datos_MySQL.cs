using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_MySQL
    {
        //VARIABLES GLOBALES
        MySqlConnection mySQLconector = new MySqlConnection();

        public Datos_MySQL()
        {
            try
            {
                StringBuilder StrConexionArmado = new StringBuilder();

                StrConexionArmado.Append("Server=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["ServerName_MySQL"]);
                StrConexionArmado.Append("; port=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["Port_MySQL"]);
                StrConexionArmado.Append("; User id=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["User_MySQL"]);
                StrConexionArmado.Append("; Password=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["Password_MySQL"]);
                StrConexionArmado.Append(";");

                this.mySQLconector = new MySqlConnection(StrConexionArmado.ToString());

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//fin constructor

       
        public DataTable QueryMySQLDatos(String QueryDelUsuario)
        {
           
            try
            {
                MySqlCommand cmd = mySQLconector.CreateCommand();
 
                cmd.CommandText = QueryDelUsuario;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtdatos = new DataTable();

                mySQLconector.Open();

                adapter.Fill(dtdatos);

                return dtdatos;
            }
            catch (MySqlException ex)
            {
             throw new Exception(ex.Message);
            }
            finally
            {
                mySQLconector.Close();
            }
        }//fin query


        public Boolean probarConexionMySQL(String usuarioValidar, String passwordValidar)
        {
            try
            {
                mySQLconector.Open();
              
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
               
            }
            finally
            {
                mySQLconector.Close();
            }

        }//fin probarconexionMySQL

    }//fin class
}//fin namespace
