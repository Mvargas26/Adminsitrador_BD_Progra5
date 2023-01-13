
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
    }
}
