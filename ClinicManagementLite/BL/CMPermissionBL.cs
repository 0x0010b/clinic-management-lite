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
            catch (Exception ex)
            {
                throw ex;
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
                throw ex;
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
                throw ex;
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
                throw ex;
            }
        }
    }
}
