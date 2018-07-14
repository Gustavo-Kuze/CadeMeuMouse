using System;
using System.Windows.Forms;

namespace CadeMeuMouse.Behavior
{
    internal class Helper
    {

        internal static bool IsEnabled { get; set; } = false;
        internal static bool IsSystemCursorHidden { get; set; } = false;


        internal static Form getCursorInstance()
        {
            Form frm = null;

            try
            {
                frm = Application.OpenForms["FrmPointer"];
            }
            catch (Exception ex)
            {
                new App.Logger().add(ex.Message + "\n" + ex.StackTrace);
            }


            return frm;

        }

    }
}
