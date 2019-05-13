using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public struct CMProcedure
    {
        public static string usp_accountCreate      = "usp_accountCreate";
        public static string usp_accountDelete      = "usp_accountDelete";
        public static string usp_accountGetAll      = "usp_accountGetAll";
        public static string usp_accountLogin       = "usp_accountLogin";
        public static string usp_accountUpdate      = "usp_accountUpdate";
        public static string usp_areaCreate         = "usp_areaCreate";
        public static string usp_areaDelete         = "usp_areaDelete";
        public static string usp_areaGetAll         = "usp_areaGetAll";
        public static string usp_areaUpdate         = "usp_areaUpdate";
        public static string usp_employeeCreate     = "usp_employeeCreate";
        public static string usp_employeeGetAll     = "usp_employeeGetAll";
        public static string usp_employeeUpdate     = "usp_employeeUpdate";
        public static string usp_permissionCreate   = "usp_permissionCreate";
        public static string usp_permissionDelete   = "usp_permissionDelete";
        public static string usp_permissionGetAll   = "usp_permissionGetAll";
        public static string usp_permissionUpdate   = "usp_permissionUpdate";
        public static string usp_personCreate       = "usp_personCreate";
        public static string usp_personDelete       = "usp_personDelete";
        public static string usp_personUpdate       = "usp_personUpdate";
        public static string usp_positionCreate     = "usp_positionCreate";
        public static string usp_positionDelete     = "usp_positionCreate";
        public static string usp_positionGetAll     = "usp_positionGetAll";
        public static string usp_positionUpdate     = "usp_positionUpdate";
    }

    public struct CMMessage
    {
        public struct Login
        {
            public static string accountNotFound    = "La cuenta ingresada no esta registrada en nuestra base de datos.";
        }
    }
}
