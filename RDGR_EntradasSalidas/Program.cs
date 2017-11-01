using Conexion.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace RDGR_EntradasSalidas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            AuxClassNH.HelperDATA = (AuxClassNH.HelperDATA ?? new NHibernateHelper(ConfigurationManager.ConnectionStrings["ConexionPRINCIPAL"].ConnectionString));            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_Principal());
        }
    }
}
