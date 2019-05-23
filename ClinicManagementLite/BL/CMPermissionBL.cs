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
                CMPermissionDAL.create(permission);
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

        static public void delete(CMPermissionBE permission)
        {
            try
            {
                CMPermissionDAL.delete(permission);
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

        static public CMPermissionBE get(CMPermissionBE permission)
        {
            try
            {
                return CMPermissionDAL.get(permission);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        static public DataTable getAll(Sort sort = Sort.name)
        {
            try
            {
                return CMPermissionDAL.getAll(sort);
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

        static public void update(CMPermissionBE permission)
        {
            try
            {
                CMPermissionDAL.update(permission);
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
