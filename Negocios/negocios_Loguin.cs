using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static  class negocios_Loguin //clase estatica que almacena los datos de inicio de sesion
    {
        private static String strUsuario="";
        private static String strPassword = "";
        private static int intMotorElegido = 0; //Si es 1 eligio SQlServer si es 2 eligio MySQL
        private static Boolean booEstaActiva = false;
        private static String strServidor = "";

        public static string usuario { get => strUsuario; set => strUsuario = value; }
        public static string password { get => strPassword; set => strPassword = value; }
        public static int motorElegido { get => intMotorElegido; set => intMotorElegido = value; }
        public static Boolean EstaActiva { get => booEstaActiva; set => booEstaActiva = value; }
        public static string Servidor { get => strServidor; set => strServidor = value; }
    }//fin static class
}
