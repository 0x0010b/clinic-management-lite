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
        public string person_dni            = "";
        public string person_name           = "";
        public string person_lastname       = "";
        public string person_phone          = "";
        public DateTime person_birthday     = new DateTime();
        public string person_address        = "";
        public Gender person_gender         = Gender.male;
        public string person_image          = "";
        public DateTime person_createdAt    = new DateTime();
    }
}
