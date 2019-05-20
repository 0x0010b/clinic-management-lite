using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementLite
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Factory creado
            FormViewFactory factory = new FormViewFactory();

            // Selecciono Permiso
            FormList formList = new FormList();
            formList.objFormView = factory.getInstance(General.FormViewKey.permission);
            // Muestro form

            Application.Run(formList);
        }
    }
}
