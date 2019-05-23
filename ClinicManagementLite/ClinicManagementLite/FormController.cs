using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite
{
    public interface FormController
    {
        void setupFormList(Form ctx);
        void setupFormMaintenance(Form ctx);
        void actionInsert(Form ctx);
        void actionUpdate(Form ctx);
        void actionDelete(Form ctx);
    }
}
