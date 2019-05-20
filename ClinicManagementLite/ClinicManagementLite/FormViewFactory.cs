using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General;

namespace ClinicManagementLite
{
    class FormViewFactory
    {
        public FormView getInstance(FormViewKey key)
        {
            switch(key)
            {
                case FormViewKey.permission:
                    return new FormPermission();

                default:
                    return null;
            }
        }
    }
}
