using BE;
using DAL;
using General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                if (area.area_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                 else
                {
                    CMAreaDAL.create(area);
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
                    row[2] = area.area_createdAt.ToShortDateString();

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
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
                throw CMException.errorHandler(ex);
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
                throw CMException.errorHandler(ex);
            }
        }

        static public void update(CMAreaBE area)
        {
            try
            {
                if (area.area_description.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Form.descriptionEmpty);
                }
                else
                {
                    CMAreaDAL.update(area);
                }
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
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
                throw CMException.errorHandler(ex);
            }
        }
        
        public static String getAreasWithSalary()
        {
            try
            {
                List<CMAreaBE> areas = CMAreaDAL.getAreasWithSalary();

                string htmlString = $"<div class='progress' style='margin-left: 20px; margin-right: 20px;'>";
                string htmlList = "";
                string _class = "progress-bar";

                Single totalSalary = 0;

                

                foreach (CMAreaBE area in areas)
                {
                    totalSalary += area.total_salary;
                }

                foreach(CMAreaBE area in areas)
                {
                    string color    = CMRandom.shared.getRandomColor();
                    Single percent  = (area.total_salary / totalSalary) * 100;
                    string html =
                        $"<div class='{_class}' data-toggle='tooltip' data-placement='bottom' title='{area.area_description}' role='progressbar' style='background-color: {color}; width: {percent}%'>" +
                        $"{area.total_salary}" +
                        $"</div>";

                    string list =
                        $"<h4 style='margin-left:20px; margin-right: 20px; color: {color}'> {area.area_description}: S/{area.total_salary}</h4>";

                    htmlString += html;
                    htmlList += list; 
                }
                
                return htmlString + "</div>" + htmlList;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
