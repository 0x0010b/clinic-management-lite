using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BE
{
    public class CMPersonBE
    {
        public int person_dni               = 0;
        public string person_name           = "";
        public string person_lastname       = "";
        public string person_phone          = "";
        public DateTime person_birthday     = new DateTime();
        public string person_address        = "";
        public Gender person_gender         = Gender.male;
        public string person_image          = "";
        public Boolean person_isActive      = false;
        public DateTime person_createdAt    = new DateTime();

        public CMPersonBE() { }

        public CMPersonBE(SqlDataReader reader)
        {
            this.person_dni         = int.Parse(reader["person_dni"].ToString());
            this.person_name        = reader["person_name"].ToString();
            this.person_lastname    = reader["person_lastname"].ToString();
            this.person_phone       = reader["person_phone"].ToString();
            this.person_birthday    = Convert.ToDateTime(reader["person_birthday"].ToString());
            this.person_address     = reader["person_address"].ToString();
            this.person_gender      = (int.Parse(reader["person_gender"].ToString())  == (int)Gender.male) ? Gender.male : Gender.female;
            this.person_image       = reader["person_image"].ToString();
            this.person_isActive    = (bool)reader["person_isActive"];
            this.person_createdAt   = Convert.ToDateTime(reader["person_createdAt"].ToString());
        }

        public int dni
        {
            get { return person_dni; }
            set { person_dni = value; }
        }

        public string name
        {
            get { return person_name; }
            set { person_name = value; }
        }

        public string lastname
        {
            get { return person_lastname; }
            set { person_lastname = value; }
        }

        public string phone
        {
            get { return person_phone; }
            set { person_phone = value; }
        }

        public DateTime birthday
        {
            get { return person_birthday; }
            set { person_birthday = value; }
        }

        public string address
        {
            get { return person_address; }
            set { person_address = value; }
        }

        public Gender gender
        {
            get { return person_gender; }
            set { person_gender = value; }
        }

         public string image
        {
            get { return person_image; }
            set { person_image = value; }
        }

        public Boolean isActive
        {
            get { return person_isActive; }
            set { person_isActive = value; }
        }

        public DateTime createdAt
        {
            get { return person_createdAt; }
            set { person_createdAt = value; }
        }
    }
}
