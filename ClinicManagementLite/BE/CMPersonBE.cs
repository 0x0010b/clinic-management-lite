using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public CMPersonBE()
        {
            // TODO: - Implement parsing
        }
    }
}
