using Microsoft.Win32;
using System.Threading;
using System.Windows.Forms;

namespace CadeMeuMouse.App
{
    internal class Utils
    {

        internal static Thread startNewBackgroundThread(ThreadStart method)
        {
            Thread th = new Thread(method);
            th.IsBackground = true;
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
            return th;
        }


        internal static bool isAnyMouseButtonDown()
        {
            return Win32API.GetAsyncKeyState(App.Win32API.VirtualKeys.MouseLeft) != 0 ||
                 Win32API.GetAsyncKeyState(App.Win32API.VirtualKeys.MouseRight) != 0 ||
                 Win32API.GetAsyncKeyState(App.Win32API.VirtualKeys.MouseMiddle) != 0;
        }

        internal static void startProgramWithWindows(bool isChecked)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                        ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (isChecked)
                {
                    registryKey.SetValue(Application.ProductName, Application.ExecutablePath);
                }
                else
                {
                    registryKey.DeleteValue(Application.ProductName);
                }
            }
            catch (System.Exception ex)
            {
                new App.Logger().add(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}


//old catch
//if(System.Globalization.CultureInfo.CurrentCulture.Name == "pt-BR")
//{
//    if(MessageBox.Show("Não foi possível criar a chave no registro do Windows, você deseja reiniciar o programa como administrador?", 
//        "Erro: Permissão negada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//    {
//        System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
//        info.FileName = Application.ExecutablePath;
//        info.Verb = "runas";
//        System.Diagnostics.Process.Start(info);
//        System.Environment.Exit(0);
//    }
//}
//else
//{
//    if (MessageBox.Show("Impossible to create the key at Windows registry, do You want to restart the program as administrator?",
//        "Error: Access denied ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//    {
//        System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
//        info.FileName = Application.ExecutablePath;
//        info.Verb = "runas";
//        System.Diagnostics.Process.Start(info);
//        System.Environment.Exit(0);
//    }
//}
//MessageBox.Show(ex.Message);