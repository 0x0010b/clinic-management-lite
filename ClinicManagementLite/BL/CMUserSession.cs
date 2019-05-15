using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CMUserSession
    {
        private CMAccountBE account;
        private String settingsFile = "Settings.conf";

        static public CMUserSession shared = new CMUserSession();

        public void saveSession(CMAccountBE account)
        {
            this.account = account;
        }

        public void deleteSession()
        {
            this.account = null;
        }

        public CMAccountBE getUserInformation()
        {
            return account;
        }

        public void setRememberUser(String username)
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(this.settingsFile, FileMode.OpenOrCreate, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    writer.WriteLine(username);
                }
            }
        }

        public String getRememberUser()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            if (isoStore.FileExists(this.settingsFile))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(this.settingsFile, FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
