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

        static public DataTable getDataTable()
        {
            try
            {
                List<CMScheduleBE> arraySchedules = CMScheduleDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("DNI");
                dataTable.Columns.Add("Empleado");
                dataTable.Columns.Add("Turno");
                dataTable.Columns.Add("Dia");
                dataTable.Columns.Add("Fecha de entrada");
                dataTable.Columns.Add("Fecha de salida");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMScheduleBE schedule in arraySchedules)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = schedule.schedule_turn.turn_id;
                    row[1] = schedule.schedule_employee.person_dni;
                    row[2] = $"{schedule.schedule_employee.person_name} {schedule.schedule_employee.person_lastname}";
                    row[3] = schedule.schedule_turn.turn_description;
                    row[4] = CMParser.getDayString(schedule.schedule_turn.turn_day);
                    row[5] = schedule.schedule_turn.turn_entryHour.ToShortTimeString();
                    row[6] = schedule.schedule_turn.turn_departureHour.ToShortTimeString();
                    row[7] = schedule.schedule_created_at.ToShortDateString();

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
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
