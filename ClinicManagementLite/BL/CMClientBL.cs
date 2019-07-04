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
    public class CMClientBL
    {
        public static void create(CMClientBE client)
        {
            try
            {
                if (client.person_dni.Trim().Length < 8)
                {
                    throw new Exception(CMMessage.Person.dniMinString);
                }
                else if (client.person_name.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.nameEmptyString);
                }
                else if (client.person_lastname.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.lastNameEmptyString);
                }
                else if (client.person_phone.Trim().Length < 9)
                {
                    throw new Exception(CMMessage.Person.phoneEmptyString);
                }
                else if (client.person_address.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.addressEmptyString);
                }
                else
                {
                    CMPersonBL.create(client);
                    CMClientDAL.create(client);
                }
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        public static DataTable getDataTable()
        {
            try
            {
                List<CMClientBE> arrayClients = CMClientDAL.getAll();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("DNI");
                dataTable.Columns.Add("Nombre completo");
                dataTable.Columns.Add("Celular");
                dataTable.Columns.Add("Fecha de nacimiento");
                dataTable.Columns.Add("Direccion");
                dataTable.Columns.Add("Genero");
                dataTable.Columns.Add("Fecha de creacion");

                foreach (CMClientBE client in arrayClients)
                {

                    DataRow row = dataTable.NewRow();

                    row[0] = client.person_dni;
                    row[1] = $"{client.person_name} {client.person_lastname}";
                    row[2] = client.person_phone;
                    row[3] = client.person_birthday.ToShortDateString();
                    row[4] = client.person_address;
                    row[5] = CMParser.getGenderString(client.person_gender);
                    row[6] = client.client_createdAt.ToShortDateString();

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        public static List<CMClientBE> getAll()
        {
            try
            {
                return CMClientDAL.getAll();
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        public static CMClientBE get(string person_dni)
        {
            try
            {
                return CMClientDAL.get(person_dni);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }

        static public void update(CMClientBE client)
        {
            try
            {
                if (client.person_dni.Trim().Length < 8)
                {
                    throw new Exception(CMMessage.Person.dniMinString);
                }
                else if (client.person_name.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.nameEmptyString);
                }
                else if (client.person_lastname.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.lastNameEmptyString);
                }
                else if (client.person_phone.Trim().Length < 9)
                {
                    throw new Exception(CMMessage.Person.phoneEmptyString);
                }
                else if (client.person_address.Trim().Length < 1)
                {
                    throw new Exception(CMMessage.Person.addressEmptyString);
                }
                else
                {
                    CMPersonBL.update(client);
                    CMClientDAL.update(client);
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
                CMClientDAL.delete(person_dni);
            }
            catch (Exception ex)
            {
                throw CMException.errorHandler(ex);
            }
        }
    }
}
