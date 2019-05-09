using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementLite.Windows.General;

namespace ClinicManagementLite.Windows.BE
{
    class CMPersonBE
    {
        public int person_dni           = 0;
        public string person_name       = "";
        public string person_lastname   = "";
        public string person_phone      = "";
        public string person_address    = "";
        public bool person_isActive     = true;
        public Gender person_gender     = Gender.male;
        public DateTime person_birthday = new DateTime();
    }
}
