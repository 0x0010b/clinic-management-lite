using ClinicManagementLite.Windows.General;
using ClinicManagementLite.Windows.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BL
{
    class CMUserSessionBL
    {
        private         CMUserSessionBE session;
        public static   CMUserSessionBL shared  = new CMUserSessionBL();

        public CMUserSessionBE getSession()
        {
            return this.session;
        }

        public void saveSession(CMAccountBE account)
        {
            if (this.session == null)
            {
                this.session = new CMUserSessionBE();
            }

            this.session.session_account = account;
        }

        public void deleteSession()
        {
            this.session = null;
        }
    }
}
