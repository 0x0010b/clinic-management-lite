using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using General;

namespace BL
{
    public class CMScheduleBL
    {
        static public void create(CMScheduleBE schedule)
        {
            try
            {
                CMScheduleDAL.create(schedule);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void getDataTable()
        {
            
        }

        static public List<CMScheduleBE> getAll()
        {
            try
            {
                return CMScheduleDAL.getAll();
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void delete(string person_dni, int turn_id)
        {
            try
            {
                CMScheduleDAL.delete(person_dni, turn_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMScheduleBE> filterByTurn(int turn_id)
        {
            try
            {
                return CMScheduleDAL.filterByTurn(turn_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMScheduleBE> filterByEmployee(string person_dni)
        {
            try
            {
                return CMScheduleDAL.filterByEmployee(person_dni);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMScheduleBE> filterByDay(int day)
        {
            try
            {
                return CMScheduleDAL.filterByDay(day);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
