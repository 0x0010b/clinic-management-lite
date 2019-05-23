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
    public class CMPositionBL
    {
        static public void create(CMPositionBE position)
        {
            try
            {
                CMPositionDAL.create(position);
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

        static public void delete(CMPositionBE position)
        {
            try
            {
                CMPositionDAL.delete(position);
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

        static public CMPositionBE get(CMPositionBE position)
        {
            try
            {
                return CMPositionDAL.get(position);
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
                return CMPositionDAL.getAll(sort);
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

        static public void update(CMPositionBE position)
        {
            try
            {
                CMPositionDAL.update(position);
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
