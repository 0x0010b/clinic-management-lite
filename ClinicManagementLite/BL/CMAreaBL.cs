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
    public class CMAreaBL
    {
        static public void create(CMAreaBE area)
        {
            try
            {
                CMAreaDAL.create(area);
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

        static public void delete(CMAreaBE area)
        {
            try
            {
                CMAreaDAL.delete(area);
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
                return CMAreaDAL.getAll(sort);
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

        static public void update(CMAreaBE area)
        {
            try
            {
                CMAreaDAL.update(area);
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
