using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDGR_EntradasSalidas.Classes
{
    class clsDevexpress
    {
        public static void MostraFormaEspera(XtraForm frmParent, string strCaption)
        {
            try
            {
                if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
                {
                    SplashScreenManager.ShowForm(frmParent, typeof(WaitForm1), true, true, true);
                    SplashScreenManager.Default.SetWaitFormCaption(strCaption);
                    SplashScreenManager.Default.SetWaitFormDescription("Espere un momento...");
                    SplashScreenManager.Default.Properties.ParentForm = frmParent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción al mostrar forma de espera: \r\n" + ex.ToString(), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void CerrarFormaEspera()
        {
            try
            {
                if (SplashScreenManager.Default != null)
                {
                    if (SplashScreenManager.Default.IsSplashFormVisible)
                        SplashScreenManager.CloseForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción al cerrar forma de espera: \r\n" + ex.ToString(), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static bool MBOK(string strMensaje, string strTitulo, MessageBoxButtons MBoxBotones, MessageBoxIcon MBoxIcon)
        {
            try
            {
                CerrarFormaEspera();
                DialogResult Resultado = XtraMessageBox.Show(strMensaje, strTitulo, MBoxBotones, MBoxIcon);
                if (Resultado == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción al llamar MB DevExpress: \r\n" + ex.ToString(), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static decimal getTypeOfRequest(string p)
        {
            switch (p)
            {
                case "Guardia (desarrolladores)":
                    return 0;
                case "Vacaciones (desarrolladores)":
                    return 1;
                case "Guardia (Analistas)":
                    return 2;
                case "Vacaciones (Analistas)":
                    return 3;
                case "Guardia (Soporte)":
                    return 4;
                case "Vacaciones (Soporte)":
                    return 5;
                case "Guardia (Infraestructura)":
                    return 6;
                case "Vacaciones (Infraestructura)":
                    return 7;
                default:
                    return -1;
            }
        }
    }
}
