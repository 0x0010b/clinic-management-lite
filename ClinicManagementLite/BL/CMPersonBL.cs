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
    class CMPersonBL
    {
        static public void create(CMPersonBE person)
        {
            try
            {
                CMPersonDAL.create(person);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void update(CMPersonBE person)
        {
            try
            {
                CMPersonDAL.update(person);
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
                List<CMPersonBE> arrayPersons = CMPersonDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("DNI");
                dataTable.Columns.Add("Nombre completo");
                dataTable.Columns.Add("Celular");
                dataTable.Columns.Add("Fecha de nacimiento");
                dataTable.Columns.Add("Direccion");
                dataTable.Columns.Add("Genero");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMPersonBE person in arrayPersons)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = person.person_dni;
                    row[1] = $"{person.person_name} {person.person_lastname}";
                    row[2] = person.person_phone;
                    row[3] = person.person_birthday.ToShortDateString();
                    row[4] = person.person_address;
                    row[5] = person.person_gender == 0 ? "Masculino" : "Femenino";
                    row[6] = person.person_createdAt.ToShortDateString();

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public List<CMPersonBE> getAll()
        {
            try
            {
                return CMPersonDAL.getAll();
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
