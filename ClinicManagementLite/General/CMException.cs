using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class CMException
    {
        static public Exception errorHandler(Exception ex)
        {
            if (ex.Message.Contains("UNIQUE KEY"))
            {
                return new Exception(CMMessage.Error.uniqueKey);
            }
            else if (ex.Message.Contains("DELETE"))
            {
                return new Exception(CMMessage.Error.deleteKey);
            }
            else
            {
                return ex;
            }
        }
    }
}
