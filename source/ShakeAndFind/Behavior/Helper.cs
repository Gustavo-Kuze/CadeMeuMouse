using System.Windows.Forms;

namespace ShakeAndFind.Behavior
{
    public class Helper
    {

        public static bool IsEnabled { get; set; } = false;
        public static bool IsSystemCursorHidden { get; set; } = false;


        public static Form getCursorInstance()
        {
            Form frm = null;

            try
            {
                frm = Application.OpenForms["FrmPointer"];
            }
            catch
            {
            }


            return frm;

        }

    }
}
