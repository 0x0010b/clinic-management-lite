using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class CMParser
    {
        static public string getDayString(int day)
        {
            switch (day)
            {
                case 0:
                    return "DOMINGO";

                case 1:
                    return "LUNES";

                case 2:
                    return "MARTES";

                case 3:
                    return "MIERCOLES";

                case 4:
                    return "JUEVES";

                case 5:
                    return "VIERNES";

                case 6:
                    return "SABADO";

                default:
                    return String.Empty;
            }
        }

        static public string getGenderString(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "MASCULINO";

                case 1:
                    return "FEMENINO";

                default:
                    return String.Empty;
            }
        }

    }

    public class CMRandom
    {
        private Random r { get; set; }

        public static CMRandom shared = new CMRandom();

        public string getRandomColor()
        {
            r = new Random(Guid.NewGuid().GetHashCode());
            double red      = r.Next(255) / 2f + 0.5;
            double green    = r.Next(250) / 2f + 0.5;
            double blue     = r.Next(245) / 2f + 0.5;

            return ColorTranslator.ToHtml(Color.FromArgb((int)red, (int)green, (int)blue));
        }
    }
}
