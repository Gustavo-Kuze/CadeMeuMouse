using Microsoft.Win32;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CadeMeuMouse.App
{
    internal class Utils
    {
        internal static bool IsEnabled { get; set; } = false;
        internal static bool IsSystemCursorHidden { get; set; } = false;

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
            return Win32API.GetAsyncKeyState(Win32API.VirtualKeys.MouseLeft) != 0 ||
                 Win32API.GetAsyncKeyState(Win32API.VirtualKeys.MouseRight) != 0 ||
                 Win32API.GetAsyncKeyState(Win32API.VirtualKeys.MouseMiddle) != 0;
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
            catch (Exception ex)
            {
                new Logger().add(ex.Message + "\n" + ex.StackTrace);
            }
        }



        internal static Form getCursorInstance()
        {
            Form frm = null;

            try
            {
                frm = Application.OpenForms["FrmPointer"];
            }
            catch (Exception ex)
            {
                new Logger().add(ex.Message + "\n" + ex.StackTrace);
            }


            return frm;

        }
    }
}
