using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BE
{
    public class CMClientBE : CMPersonBE
    {
        public string client_wheight         = "";
        public string client_height         = "";
        public string client_bloodType      = "";
        public string client_bloodPressure  = "";
        public string client_allergies      = "";
        public string client_pathologies    = "";
        public string client_medicines      = "";
        public string client_seizures       = "";
        public string client_diabetes       = "";
        public string client_cholesterol    = "";
        public string client_cancer         = "";
        public string client_aids           = "";

        public CMClientBE() { }

        public CMClientBE(CMPersonBE person, SqlDataReader reader)
        {
            //Person attributes
            this.person_dni             = person.person_dni;
            this.person_name            = person.person_name;
            this.person_lastname        = person.person_lastname;
            this.person_phone           = person.person_phone;
            this.person_birthday        = person.person_birthday;
            this.person_address         = person.person_address;
            this.person_gender          = person.person_gender;
            this.person_image           = person.person_image;
            this.person_isActive        = person.isActive;
            this.person_createdAt       = person.person_createdAt;

            //Client attributes
            this.client_wheight          = reader["client_weight"].ToString();
            this.client_height          = reader["client_height"].ToString();
            this.client_bloodType       = reader["client_bloodType"].ToString();
            this.client_bloodPressure   = reader["client_bloodPressure"].ToString();
            this.client_allergies       = reader["client_allergies"].ToString();
            this.client_pathologies     = reader["client_pathologies"].ToString();
            this.client_medicines       = reader["client_medicines"].ToString();
            this.client_seizures        = reader["client_seizures"].ToString();
            this.client_diabetes        = reader["client_diabetes"].ToString();
            this.client_cholesterol     = reader["client_cholesterol"].ToString();
            this.client_cancer          = reader["client_cancer"].ToString();
            this.client_aids            = reader["client_aids"].ToString();
        }

        public string wheight
        {
            get { return client_wheight; }
            set { client_wheight = value; }
        }

        public string height
        {
            get { return client_height; }
            set { client_height = value; }
        }

        public string bloodType
        {
            get { return client_bloodType; }
            set { client_bloodType = value; }
        }

        public string bloodPressure
        {
            get { return client_bloodPressure; }
            set { client_bloodPressure = value; }
        }

        public string allergies
        {
            get { return client_allergies; }
            set { client_allergies = value; }
        }

        public string pathologies
        {
            get { return client_pathologies; }
            set { client_pathologies = value; }
        }

        public string medicines
        {
            get { return client_medicines; }
            set { client_medicines = value; }
        }

        public string seizures
        {
            get { return client_seizures; }
            set { client_seizures = value; }
        }

        public string diabetes
        {
            get { return client_diabetes; }
            set { client_diabetes = value; }
        }

        public string cholesterol
        {
            get { return client_cholesterol; }
            set { client_cholesterol = value; }
        }

        public string cancer
        {
            get { return client_cancer; }
            set { client_cancer = value; }
        }

        public string aids
        {
            get { return client_aids; }
            set { client_aids = value; }
        }
    }
}
