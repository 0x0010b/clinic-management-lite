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
                if (position.position_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                else
                {
                    CMPositionDAL.create(position);
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
                List<CMPositionBE> arrayPositions = CMPositionDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Cargo");
                dataTable.Columns.Add("Area");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMPositionBE position in arrayPositions)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = position.position_id;
                    row[1] = position.position_description;
                    row[2] = position.position_area.area_description;
                    row[3] = position.position_createdAt.ToString("dd / MM / yyyy");

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMPositionBE> getAll(int area_id = 0)
        {
            try
            {
                return CMPositionDAL.getAll(area_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public CMPositionBE get(int position_id)
        {
            try
            {
                return CMPositionDAL.get(position_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void update(CMPositionBE position)
        {
            try
            {
                if (position.position_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                else
                {
                    CMPositionDAL.update(position);
                }
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void delete(int position_id)
        {
            try
            {
                CMPositionDAL.delete(position_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
