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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public DataTable getDataTable()
        {
            try
            {
                List<CMAreaBE> arrayAreas = CMAreaDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Area");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMAreaBE area in arrayAreas)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = area.area_id;
                    row[1] = area.area_description;
                    row[2] = area.area_createdAt.ToString("dd / MM / yyyy");

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public List<CMAreaBE> getAll()
        {
            try
            {
                return CMAreaDAL.getAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public CMAreaBE get(int area_id)
        {
            try
            {
                return CMAreaDAL.get(area_id);
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public void delete(int area_id)
        {
            try
            {
                CMAreaDAL.delete(area_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
