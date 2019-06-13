using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using DAL;
using General;

namespace BL
{
    public class CMCLientBL
    {
        static public void create(CMClientBE client)
        {
            try
            {
                CMClientDAL.create(client);
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

        static public void delete(CMClientBE client)
        {
            try
            {
                CMClientDAL.delete(client);
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

        static public void update(CMClientBE client)
        {
            try
            {
                CMClientDAL.update(client);
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

        static public CMClientBE get(CMClientBE client)
        {
            try
            {
                return CMClientDAL.get(client);
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
                return CMClientDAL.getAll(sort);
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
