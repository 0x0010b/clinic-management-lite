using BE;
using DAL;
using General;
using System;
using System.Collections.Generic;
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

        static public void delete(CMPermissionBE permission)
        {
            try
            {
                CMPermissionDAL.delete(permission);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public List<CMPermissionBE> getAll(Sort sort = Sort.name)
        {
            try
            {
                return CMPermissionDAL.getAll(sort);
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
