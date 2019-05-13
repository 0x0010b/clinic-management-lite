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
    public class CMAccountBL
    {
        static public CMAccountBE login(CMAccountBE account)
        {
            try
            {
                return CMAccountDAL.login(account);
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

        static public void delete(CMAccountBE account)
        {
            try
            {
                CMAccountDAL.delete(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public List<CMAccountBE> getAll(Sort sort = Sort.name)
        {
            try
            {
                return CMAccountDAL.getAll(sort);
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
    }
}
