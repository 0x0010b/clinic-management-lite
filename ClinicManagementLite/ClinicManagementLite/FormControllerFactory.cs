using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General;

namespace ClinicManagementLite
{
    public class FormControllerFactory
    {
        public FormController getInstance(FormControllerKey key)
        {
            switch(key)
            {
                case FormControllerKey.permission:
                    return new FormPermission();
                case FormControllerKey.position:
                    return new FormPosition();
                case FormControllerKey.area:
                    return new FormArea();
                case FormControllerKey.person:
                    return new FormPerson();

                default:
                    return null;
            }
        }
    }
}
