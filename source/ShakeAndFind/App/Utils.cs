using System.Threading;

namespace ShakeAndFind.App
{
    public class Utils
    {

        public static Thread startNewBackgroundThread(ThreadStart method)
        {
            Thread th = new Thread(method);
            th.IsBackground = true;
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
            return th;
        }


        public static bool isAnyMouseButtonDown()
        {
            return Win32API.GetAsyncKeyState(App.Win32API.VirtualKeys.MouseLeft) != 0 ||
                 Win32API.GetAsyncKeyState(App.Win32API.VirtualKeys.MouseRight) != 0 ||
                 Win32API.GetAsyncKeyState(App.Win32API.VirtualKeys.MouseMiddle) != 0;
        }
    }
}
