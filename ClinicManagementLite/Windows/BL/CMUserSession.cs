using ClinicManagementLite.Windows.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementLite.Windows.BL
{
    class Session
    {
        public int session_id;
        public PermissionType session_permission;
    }

    class CMUserSession
    {
        private Session session = null;
        public static CMUserSession shared = new CMUserSession();

        public Session getSession()
        {
            return this.session;
        }

        public void saveSession(int id, PermissionType permission)
        {
            this.session.session_id = id;
            this.session.session_permission = permission;
        }

        public void deleteSession()
        {
            this.session = null;
        }
    }
}
