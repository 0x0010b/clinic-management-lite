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
    public class CMEmployeeBL
    {
        public static void create(CMEmployeeBE employee)
        {
            try
            {
                CMEmployeeDAL.create(employee);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public DataTable getDataTable(int area_id = 0, int position_id = 0)
        {
            try
            {
                List<CMEmployeeBE> arrayEmployees = CMEmployeeDAL.getAll(area_id, position_id);
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("DNI");
                dataTable.Columns.Add("Nombre completo");
                dataTable.Columns.Add("Celular");
                dataTable.Columns.Add("Direccion");
                dataTable.Columns.Add("Genero");
                dataTable.Columns.Add("Cargo");
                dataTable.Columns.Add("Area");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMEmployeeBE employee in arrayEmployees)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = employee.person_dni;
                    row[1] = $"{employee.person_name} {employee.person_lastname}";
                    row[2] = employee.person_phone;
                    row[3] = employee.person_address;
                    row[4] = employee.person_gender == 0 ? "Masculino" : "Femenino";
                    row[5] = employee.employee_position.position_description;
                    row[6] = employee.employee_position.position_area.area_description;
                    row[7] = employee.employee_createdAt.ToString("dd / MM / yyyy");

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMEmployeeBE> getAll(int area_id = 0, int position_id = 0)
        {
            try
            {
                return CMEmployeeDAL.getAll(area_id, position_id);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public CMEmployeeBE get(string person_dni)
        {
            try
            {
                return CMEmployeeDAL.get(person_dni);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void update(CMEmployeeBE employee)
        {
            try
            {
                CMEmployeeBL.update(employee);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void delete(string person_dni)
        {
            try
            {
                CMEmployeeDAL.delete(person_dni);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
