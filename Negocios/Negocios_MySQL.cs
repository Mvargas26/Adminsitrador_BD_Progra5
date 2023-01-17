using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
   public  class Negocios_MySQL
    {
      
        public DataTable QueryMySQLNegocios(String QueryUserNegociosMySQL)
        {
            try
            {
                Datos_MySQL objDatos = new Datos_MySQL();



                return objDatos.QueryMySQLDatos(QueryUserNegociosMySQL);
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }//fn QueryMySQLNegocios 

        public DataSet QueryMySQLDatos_DS(String QueryUserNegociosMySQL)
        {
            try
            {
                Datos_MySQL objDatos = new Datos_MySQL();

                return objDatos.QueryMySQLDatos_DS(QueryUserNegociosMySQL);
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }//fn QueryMySQLDatos_DS

    }//fin class
}//fin space
