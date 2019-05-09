using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.General
{
    static class ObjectExtension
    {
        public static string stringValue(this object v, string def = "")
        {
            return v == null ? def : v.ToString();
        }

        public static int intValue(this object v, int def = 0)
        {
            int r;
            return int.TryParse(v.stringValue(), out r) ? r : def;
        }

        public static double doubleValue(this object v, double def = 0.0)
        {
            double r;
            return double.TryParse(v.stringValue(), out r) ? r : def;
        }

        public static bool boolValue(this object v, bool def = false)
        {
            bool r;
            return bool.TryParse(v.intValue() == 0 ? "false" : "true", out r) ? r : def;
        }
    }
}
