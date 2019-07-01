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
    public class CMTurnBL
    {
        static public void create(CMTurnBE turn)
        {
            try
            {
                if (turn.turn_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                else
                {
                    CMTurnDAL.create(turn);
                }
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
                List<CMTurnBE> arrayTurns = CMTurnDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Turno");
                dataTable.Columns.Add("Dia");
                dataTable.Columns.Add("Hora de entrada");
                dataTable.Columns.Add("Hora de salida");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMTurnBE turn in arrayTurns)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = turn.turn_id;
                    row[1] = turn.turn_description;
                    row[2] = CMParser.getDayString(turn.turn_day);
                    row[3] = turn.turn_entryHour.ToShortTimeString();
                    row[4] = turn.turn_departureHour.ToShortTimeString();
                    row[5] = turn.turn_createdAt.ToShortDateString();

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMTurnBE> getAll()
        {
            try
            {
                return CMTurnDAL.getAll();
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public CMTurnBE get(int turn_id)
        {
            try
            {
                return CMTurnDAL.get(turn_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void update(CMTurnBE turn)
        {
            try
            {
                if (turn.turn_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                else
                {
                    CMTurnDAL.update(turn);
                }
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void delete(int turn_id)
        {
            try
            {
                CMTurnDAL.delete(turn_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
