using BE;
using DAL;
using General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CMPermissionBL
    {
        static public void create(CMPermissionBE permission)
        {
            try
            {
                if (permission.permission_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                else
                {
                    CMPermissionDAL.create(permission);
                }
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void update(CMPermissionBE permission)
        {
            try
            {
                if (permission.permission_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                else
                {
                    CMPermissionDAL.update(permission);
                }
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public DataTable getDataTable()
        {
            try
            {
                List<CMPermissionBE> arrayPermissions = CMPermissionDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Permiso");
                dataTable.Columns.Add("Lectura");
                dataTable.Columns.Add("Escritura");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMPermissionBE permission in arrayPermissions)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = permission.permission_id;
                    row[1] = permission.permission_description;
                    row[2] = permission.permission_isRead ? "Si" : "No";
                    row[3] = permission.permission_isWrite ? "Si" : "No";
                    row[4] = permission.permission_createdAt.ToShortDateString();

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMPermissionBE> getAll()
        {
            try
            {
                return CMPermissionDAL.getAll();
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public CMPermissionBE get(int permission_id)
        {
            try
            {
                return CMPermissionDAL.get(permission_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void delete(int permission_id)
        {
            try
            {
                CMPermissionDAL.delete(permission_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
