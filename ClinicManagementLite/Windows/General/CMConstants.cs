using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.General
{
    struct CMProcedures
    {
        public static string usp_userLogin      = "usp_userLogin";
        public static string usp_userCreate     = "usp_userCreate";
        public static string usp_userRead       = "usp_userRead";
        public static string usp_userReadById   = "usp_userReadById";
        public static string usp_userUpdate     = "usp_userUpdate";
        public static string usp_userDelete     = "usp_userDelete";
    }

    struct CMMessage
    {
        public struct Login
        {
            public static string emptyUsername  = "Para continuar con el proceso, debes ingresar un usuario de 8 digitos";
            public static string emptyPassword  = "Para continuar con el proceso, debes ingresar una contrasena de 6 digitos";
        }
    }
}
