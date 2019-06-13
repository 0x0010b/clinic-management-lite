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
        public static string usp_areaGet            = "usp_areaGet";
        public static string usp_areaGetAll         = "usp_areaGetAll";
        public static string usp_areaUpdate         = "usp_areaUpdate";
        public static string usp_clientCreate       = "usp_clientCreate";
        public static string usp_clientDelete       = "usp_clientDelete";
        public static string usp_clientGet          = "usp_clientGet";
        public static string usp_clientGetAll       = "usp_clientGetAll";
        public static string usp_clientUpdate       = "usp_clientUpdate";
        public static string usp_employeeCreate     = "usp_employeeCreate";
        public static string usp_employeeGetAll     = "usp_employeeGetAll";
        public static string usp_employeeUpdate     = "usp_employeeUpdate";
        public static string usp_permissionCreate   = "usp_permissionCreate";
        public static string usp_permissionDelete   = "usp_permissionDelete";
        public static string usp_permissionGet      = "usp_permissionGet";
        public static string usp_permissionGetAll   = "usp_permissionGetAll";
        public static string usp_permissionUpdate   = "usp_permissionUpdate";
        public static string usp_personGet          = "usp_personGet";
        public static string usp_personGetAll       = "usp_personGetAll";
        public static string usp_personCreate       = "usp_personCreate";
        public static string usp_personDelete       = "usp_personDelete";
        public static string usp_personUpdate       = "usp_personUpdate";
        public static string usp_positionCreate     = "usp_positionCreate";
        public static string usp_positionDelete     = "usp_positionDelete";
        public static string usp_positionGet        = "usp_positionGet";
        public static string usp_positionGetAll     = "usp_positionGetAll";
        public static string usp_positionUpdate     = "usp_positionUpdate";
    }

    public struct CMForms
    {
        public const string formPerson             = "ClinicManagementLite.FormPerson";
        public const string formClient             = "ClinicManagementLite.FormClient";
        public const string formPermission         = "ClinicManagementLite.FormPermission";
        public const string formArea               = "ClinicManagementLite.FormArea";
        public const string formPosition           = "ClinicManagementLite.FormPosition";
    }

    public struct CMMessage
    {
        public struct Alert
        {
            public static string title              = "Clinic Management Lite";
            public static string titleError         = "Clinic Management Lite";
        }

        public struct Session
        {
            public static string logout             = "Seguro que desea cerrar sesion?";
        }

        public struct Maintenance
        {
            public static string deleteInstance     = "Seguro que desea eliminar este registro?";
            public static string notFoundInstance   = "No se encontro registro en nuestra base de datos.";
            public static string cantPerformAction  = "No es posible realizar esta acción.";
        }

        public struct Login
        {
            public static string accountNotFound    = "La cuenta ingresada no esta registrada en nuestra base de datos.";
            public static string usernameMinString  = "El usuario debe tener 8 digitos.";
            public static string passwordMinString  = "La contrasena debe tener 6 digitos.";
        }
    }
}
