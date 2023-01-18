using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
  public  class negociosProcesos
    {

        public Boolean usuarioExiste( int MotorSelecionado, String ServiodorConsulta, String userConsulta, String PasswordConsulta)
        {
            try
            {// si entra aqui, el usuario seleciono SQLServer
                if (MotorSelecionado == 1)
                {
                    Datos_SQL_Server objSQLServer = new Datos_SQL_Server();
                    if(objSQLServer.probarConexionSQLServer())

                    return true; //si el usuario existe la conexion es exitosa, regresa true
                }
                //Si entra aqui el usuario seleciono MySQL
                if (MotorSelecionado == 2)
                {
                    Datos_MySQL objMySQL = new Datos_MySQL();

                    if (objMySQL.probarConexionMySQL(userConsulta,PasswordConsulta))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }

           
        }

       
    }//fin class Procesos
}
