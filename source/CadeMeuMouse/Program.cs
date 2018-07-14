using System;
using System.Windows.Forms;

namespace CadeMeuMouse
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(System.IO.Directory.Exists(Application.StartupPath + "\\resources"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new GUI.FrmWelcome());
            }
            else
            {
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                
                if(culture.Name == "pt-BR")
                {
                    MessageBox.Show("A pasta de recursos não pode ser encontrada, por favor reinstale o aplicativo!", "Erro, arquivos não encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The resources folder could not be found, please reinstall the program", "Error, directory not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            
        }
    }
}
