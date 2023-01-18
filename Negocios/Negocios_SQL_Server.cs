
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using System.Data;

namespace Negocios
{
    public class Negocios_SQL_Server
    {
        public DataTable QuerySQLServerNegocios(String QueryUserNegociosMySQL)
        {
            try
            {
                Datos_SQL_Server objDatos = new Datos_SQL_Server();

                DataTable dtDatosNegocios = objDatos.QuerySQL_Server(QueryUserNegociosMySQL);

                return dtDatosNegocios;

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }
        public DataSet QuerySQLServerNegocios_DS(String QueryUserNegociosMySQL)
        {
            try
            {
                Datos_SQL_Server objDatos = new Datos_SQL_Server();

                DataSet ds = objDatos.QuerySQL_Server_DS(QueryUserNegociosMySQL);

                return ds;

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }// fn QuerySQLServerNegocios_DS




        public DataTable QuerySQLServerNegociosAW(String QueryUserNegociosMySQL)
        {
            try
            {
                Datos_SQL_AW objDatos = new Datos_SQL_AW();

                DataTable dtDatosNegocios = objDatos.QuerySQL_Server(QueryUserNegociosMySQL);

                return dtDatosNegocios;

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }
    }//fin class
}//fn space
