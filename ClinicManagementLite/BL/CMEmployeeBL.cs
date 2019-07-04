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
                if (employee.person_dni.Trim().Length < 8)
                {
                    throw new Exception(CMMessage.Person.dniMinString);
                }
                else if (employee.person_name.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.nameEmptyString);
                }
                else if (employee.person_lastname.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.lastNameEmptyString);
                }
                else if (employee.person_phone.Trim().Length < 9)
                {
                    throw new Exception(CMMessage.Person.phoneEmptyString);
                }
                else if (employee.person_address.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.addressEmptyString);
                }
                else if (employee.employee_salary < 850)
                {
                    throw new Exception(CMMessage.Person.salaryMinimun);
                }
                else
                {
                    CMPersonBL.create(employee);
                    CMEmployeeDAL.create(employee);
                }
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
                dataTable.Columns.Add("Fecha de nacimiento");
                dataTable.Columns.Add("Direccion");
                dataTable.Columns.Add("Genero");
                dataTable.Columns.Add("Salario S/.");
                dataTable.Columns.Add("Cargo");
                dataTable.Columns.Add("Area");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMEmployeeBE employee in arrayEmployees)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = employee.person_dni;
                    row[1] = $"{employee.person_name} {employee.person_lastname}";
                    row[2] = employee.person_phone;
                    row[3] = employee.person_birthday.ToShortDateString();
                    row[4] = employee.person_address;
                    row[5] = CMParser.getGenderString(employee.person_gender);
                    row[6] = employee.employee_salary;
                    row[7] = employee.employee_position.position_description;
                    row[8] = employee.employee_position.position_area.area_description;
                    row[9] = employee.employee_createdAt.ToShortDateString();

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
                if (employee.person_dni.Trim().Length < 8)
                {
                    throw new Exception(CMMessage.Person.dniMinString);
                }
                else if (employee.person_name.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.nameEmptyString);
                }
                else if (employee.person_lastname.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.lastNameEmptyString);
                }
                else if (employee.person_phone.Trim().Length < 9)
                {
                    throw new Exception(CMMessage.Person.phoneEmptyString);
                }
                else if (employee.person_address.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.addressEmptyString);
                }
                else if (employee.employee_salary < 850)
                {
                    throw new Exception(CMMessage.Person.salaryMinimun);
                }
                else
                {
                    CMPersonBL.update(employee);
                    CMEmployeeDAL.update(employee);
                }
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
