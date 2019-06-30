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
    public class CMAccountBL
    {
        static public CMAccountBE login(String account_username, String account_password)
        {
            try
            {
                if (account_username.Trim().Length < 5)
                {
                    throw new Exception(CMMessage.Login.usernameMinString);
                }
                else if (account_password.Trim().Length < 6)
                {
                    throw new Exception(CMMessage.Login.passwordMinString);
                }
                else
                {
                    return CMAccountDAL.login(account_username, account_password);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void create(CMAccountBE account)
        {
            try
            {
                CMAccountDAL.create(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public CMAccountBE get(int account_id)
        {
            try
            {
                return CMAccountDAL.get(account_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void update(CMAccountBE account)
        {
            try
            {
                CMAccountDAL.update(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void delete(int account_id)
        {
            try
            {
                CMAccountDAL.delete(account_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public DataTable getDataTable()
        {
            try
            {
                List<CMAccountBE> arrayAccounts = CMAccountDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Usuario");
                dataTable.Columns.Add("Contrasena");
                dataTable.Columns.Add("DNI Empleado");
                dataTable.Columns.Add("Tipo de Permiso");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMAccountBE account in arrayAccounts)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = account.account_id;
                    row[1] = account.account_username;
                    row[2] = account.account_password;
                    row[3] = account.account_employee.person_dni;
                    row[4] = account.account_permission.permission_description;
                    row[5] = account.account_createdAt;

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public List<CMAccountBE> getAccountList(int permission_id)
        {
            try
            {
                return CMAccountDAL.getAll(permission_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
