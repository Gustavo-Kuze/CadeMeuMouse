using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeMeuMouse.App
{
    internal class Logger
    {
        private string logsDir = Application.StartupPath + "\\logs";

        internal Logger()
        {
            if (!System.IO.Directory.Exists(logsDir))
            {
                System.IO.Directory.CreateDirectory(logsDir);
            }
        }
        
        internal void add(string logText)
        {
            string text = "\n\nTime_" + DateTime.Now.ToString("HH:mm:ss") + ">>> " + logText;
            string fileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm");
            logRecursive(logsDir + "\\" + fileName, text);
            
        }

        private void logRecursive(string path, string text)
        {
            try
            {
                System.IO.File.AppendAllText(path, text);
            }
            catch
            {
                System.Threading.Thread.Sleep(100);
                logRecursive(path, text);
            }
            
        }

        /*internal void logException(Exception ex)
        {
            string text = "\n\nERR_" + DateTime.Now.ToString("HH/mm/ss") + ">>> "+ex.Message;
            string fileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm");
            System.IO.File.AppendAllText(logsDir + "\\" + fileName, text);
        }*/

    }
}
