namespace CadeMeuMouse.Settings
{
    public class SettingsModel
    {
        public int ScanningInterval { get; set; }
        public int EnabledTime { get; set; }
        public string Sensitivity { get; set; }
        public int CursorAnimationStartSize { get; set; }
        public int CursorAnimationEndSize { get; set; }
        public string CursorImagePath { get; set; }
        public bool OpenAtStartup { get; set; }

    }
}
