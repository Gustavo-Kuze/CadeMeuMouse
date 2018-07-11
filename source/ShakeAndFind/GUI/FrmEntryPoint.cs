using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShakeAndFind.GUI
{
    public partial class FrmWelcome : Form
    {
        NotifyIcon nIcon;

        public FrmWelcome()
        {
            InitializeComponent();
            Opacity = 0;
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            createSettingsAndLoadToRuntime();
            createNotifyIcon();
            enable();
        }

        private void createSettingsAndLoadToRuntime()
        {
            Settings.Runtime.Loaded = Settings.Parser.createSettingsIfNeeded();
        }

        private void createNotifyIcon()
        {
            NotifyIcon notify = new NotifyIcon();
            nIcon = notify;
            Bitmap bMap = (Bitmap)Image.FromFile(Application.StartupPath + "\\resources\\imgs\\mouse_cursor_enabled.png");
            notify.Icon = Icon.FromHandle(bMap.GetHicon());
            notify.Visible = true;

            notify.MouseDoubleClick += (send, ev) =>
            {
                if (ev.Button == MouseButtons.Left)
                {
                    if (Behavior.Helper.IsEnabled == true)
                    {
                        disable();
                    }
                    else
                    {
                        enable();
                    }
                }
            };


            ContextMenu menu = new ContextMenu();

            MenuItem mItemSettings = new MenuItem("Settings");
            MenuItem mItemSep1 = new MenuItem("-");
            MenuItem mItemAbout = new MenuItem("About");
            MenuItem mItemSep2 = new MenuItem("-");
            MenuItem mItemExit = new MenuItem("Exit");


            if (System.Globalization.CultureInfo.CurrentCulture.Name == "pt-BR")
            {
                mItemSettings.Text = "Configurações";
                mItemAbout.Text = "Sobre";
                mItemExit.Text = "Sair";
            }

            menu.MenuItems.Add(mItemSettings);
            menu.MenuItems.Add(mItemSep1);
            menu.MenuItems.Add(mItemAbout);
            menu.MenuItems.Add(mItemSep2);
            menu.MenuItems.Add(mItemExit);

            mItemAbout.Click += (send, ev) =>
            {
                if (Application.OpenForms["FrmAbout"] == null)
                {
                    new FrmAbout().ShowDialog();
                }
            };

            mItemSettings.Click += (send, ev) =>
            {
                if (Application.OpenForms["FrmSettings"] == null)
                {
                    FrmSettings settings = new FrmSettings();
                    settings.Show();
                }

            };

            mItemExit.Click += (send, ev) =>
            {
                Environment.Exit(0);
            };

            notify.ContextMenu = menu;

        }

        private void enable()
        {
            Bitmap map = (Bitmap)Image.FromFile(Application.StartupPath + "\\resources\\imgs\\mouse_cursor_enabled.png");
            nIcon.Icon = Icon.FromHandle(map.GetHicon());
            new FrmPointer().Show();
        }


        private void disable()
        {
            Bitmap map = (Bitmap)Image.FromFile(Application.StartupPath + "\\resources\\imgs\\mouse_cursor_disabled.png");
            nIcon.Icon = Icon.FromHandle(map.GetHicon());
            var pointerInstance = Behavior.Helper.getCursorInstance();
            pointerInstance.Close();
        }


        #region CreateParams
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
        #endregion

        private void FrmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            App.Info.IsRunning = false;
        }
    }
}
