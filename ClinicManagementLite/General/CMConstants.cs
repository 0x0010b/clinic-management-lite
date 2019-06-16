using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public struct CMProcedure
    {
        public struct Account
        {
            public static string create  = "usp_accountCreate";
            public static string delete  = "usp_accountDelete";
            public static string get     = "usp_accountGet";
            public static string getAll  = "usp_accountGetAll";
            public static string login   = "usp_accountLogin";
            public static string update  = "usp_accountUpdate";
        }
        public struct Area
        {
            public static string create = "usp_areaCreate";
            public static string delete = "usp_areaDelete";
            public static string get    = "usp_areaGet";
            public static string getAll = "usp_areaGetAll";
            public static string update = "usp_areaUpdate";
        }
        public struct Client
        {
            public static string create = "usp_clientCreate";
            public static string delete = "usp_clientDelete";
            public static string get    = "usp_clientGet";
            public static string getAll = "usp_clientGetAll";
            public static string update = "usp_clientUpdate";
        }
        public struct Employee
        {
            public static string create = "usp_employeeCreate";
            public static string delete = "usp_employeeDelete";
            public static string get    = "usp_employeeGet";
            public static string getAll = "usp_employeeGetAll";
            public static string update = "usp_employeeUpdate";
        }
        public struct Permission
        {
            public static string create = "usp_permissionCreate";
            public static string delete = "usp_permissionDelete";
            public static string get    = "usp_permissionGet";
            public static string getAll = "usp_permissionGetAll";
            public static string update = "usp_permissionUpdate";
        }
        public struct Person
        {
            public static string create = "usp_personCreate";
            public static string update = "usp_personUpdate";
        }
        public struct Position
        {
            public static string create         = "usp_positionCreate";
            public static string delete         = "usp_positionDelete";
            public static string get            = "usp_positionGet";
            public static string getAll         = "usp_positionGetAll";
            public static string getAllByArea   = "usp_positionGetAllByArea";
            public static string update         = "usp_positionUpdate";
        }
        public struct Schedule
        {
            public static string create = "usp_scheduleCreate";
            public static string delete = "usp_scheduleDelete";
            public static string getAll = "usp_scheduleGetAll";
        }
        public struct Turn
        {
            public static string create = "usp_turnCreate";
            public static string delete = "usp_turnDelete";
            public static string get    = "usp_turnGet";
            public static string getAll = "usp_turnGetAll";
            public static string update = "usp_turnUpdate";
        }
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
        }

        public struct Login
        {
            public static string accountNotFound    = "La cuenta ingresada no esta registrada en nuestra base de datos.";
            public static string usernameMinString  = "El usuario debe tener 8 digitos.";
            public static string passwordMinString  = "La contrasena debe tener 6 digitos.";
        }
    }
}
