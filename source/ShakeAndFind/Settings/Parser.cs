using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace ShakeAndFind.Settings
{
    public class Parser
    {
        
        public static SettingsModel createSettingsIfNeeded()
        {
            if (!File.Exists(Application.StartupPath + "\\resources\\settings\\shakeandfind.json"))
            {
                SettingsModel model = new SettingsModel();
                model.ScanningInterval = 100;
                model.EnabledTime = 300;
                model.Sensitivity = "normal";
                model.CursorImagePath = Application.StartupPath + "\\resources\\imgs\\mouse_cursor.png";
                model.CursorAnimationStartSize = 50;
                model.CursorAnimationEndSize = 200;


                string json = JsonConvert.SerializeObject(model);
                File.AppendAllText(Application.StartupPath + "\\resources\\settings\\shakeandfind.json",
                    json);
            }

            return load();
        }


        public static void save(SettingsModel model)
        {
            string json = JsonConvert.SerializeObject(model);
            File.WriteAllText(Application.StartupPath + "\\resources\\settings\\shakeandfind.json",
                json);
        }

        public static SettingsModel load()
        {
            string fileContent = File.ReadAllText(Application.StartupPath + "\\resources\\settings\\shakeandfind.json");
            SettingsModel model = JsonConvert.DeserializeObject<SettingsModel>(fileContent);
            return model;
        }

    }
}
