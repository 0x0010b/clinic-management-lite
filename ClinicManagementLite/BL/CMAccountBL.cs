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
        static public CMAccountBE login(CMAccountBE account)
        {
            try
            {
                if (account.account_username.Length < 8)
                {
                    throw new Exception(CMMessage.Login.usernameMinString);
                }
                else if (account.account_password.Length < 6)
                {
                    throw new Exception(CMMessage.Login.passwordMinString);
                }
                else
                {
                    return CMAccountDAL.login(account);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
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
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void delete(CMAccountBE account)
        {
            try
            {
                CMAccountDAL.delete(account);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public DataTable getAll(Sort sort = Sort.name)
        {
            try
            {
                return CMAccountDAL.getAll(sort);
            }
            catch (SqlException ex)
            {
                throw ex;
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
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
