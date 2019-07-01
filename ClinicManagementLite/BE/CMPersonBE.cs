using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using General;

namespace BE
{
    public class CMPersonBE
    {
        public string person_dni { get; set; } = "";
        public string person_name { get; set; } = "";
        public string person_lastname { get; set; } = "";
        public string person_phone { get; set; } = "";
        public DateTime person_birthday { get; set; } = new DateTime();
        public string person_address { get; set; } = "";
        public int person_gender { get; set; } = 0;
        public string person_image { get; set; } = "";
        public DateTime person_createdAt { get; set; } = new DateTime();

        public CMPersonBE() { }

        public CMPersonBE(SqlDataReader reader)
        {
            this.person_dni         = reader["person_id"].ToString();
            this.person_name        = reader["person_name"].ToString();
            this.person_lastname    = reader["person_lastname"].ToString();
            this.person_phone       = reader["person_phone"].ToString();
            this.person_birthday    = Convert.ToDateTime(reader["person_birthday"].ToString());
            this.person_address     = reader["person_addres"].ToString();
            this.person_gender      = Convert.ToInt16(reader["person_gender"].ToString());
            this.person_image       = reader["person_image"].ToString();
            this.person_createdAt   = Convert.ToDateTime(reader["person_created_at"].ToString());
        }
    }
}
