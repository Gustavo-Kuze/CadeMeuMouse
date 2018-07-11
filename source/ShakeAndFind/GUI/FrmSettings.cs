using System;
using System.Linq;
using System.Windows.Forms;

namespace ShakeAndFind.GUI
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void loadSettings()
        {
            var model = Settings.Parser.load();
            nudScanningInterval.Value = decimal.Parse(model.ScanningInterval.ToString());
            nudEnabledTime.Value = decimal.Parse(model.EnabledTime.ToString());
            if (model.Sensitivity == "normal")
            {
                rdoSensitivityNormal.Checked = true;
            }
            else
            {
                rdoSensitivityVeryStrong.Checked = true;
            }
            nudStartSize.Value = decimal.Parse(model.CursorAnimationStartSize.ToString());
            nudEndSize.Value = decimal.Parse(model.CursorAnimationEndSize.ToString());
            txtCursorImgPath.Text = model.CursorImagePath;
        }

        private void saveSettings()
        {
            Settings.SettingsModel model = new Settings.SettingsModel();
            model.ScanningInterval = Convert.ToInt32(nudScanningInterval.Value);
            model.EnabledTime = Convert.ToInt32(nudEnabledTime.Value);
            if (rdoSensitivityNormal.Checked)
            {
                model.Sensitivity = "normal";
            }
            else
            {
                model.Sensitivity = "very-strong";
            }
            model.CursorAnimationStartSize = Convert.ToInt32(nudStartSize.Value);
            model.CursorAnimationEndSize = Convert.ToInt32(nudEndSize.Value);

            model.CursorImagePath = txtCursorImgPath.Text;

            Settings.Parser.save(model);
            Settings.Runtime.Loaded = Settings.Parser.load();
        }

        private void btnSearchCursorImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Procure pela imagem do cursor!";
            ofd.Filter = "Image Files(*.bmp;*.jpg;*.png;*.ico)|*.bmp;*.jpg;*.png;*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCursorImgPath.Text = ofd.FileName;
            }
        }

    }
}

//private void dropShadow(object sender, PaintEventArgs e)
//{
//    Panel panel = (Panel)sender;
//    Color[] shadow = new Color[3];
//    shadow[0] = Color.FromArgb(181, 181, 181);
//    shadow[1] = Color.FromArgb(195, 195, 195);
//    shadow[2] = Color.FromArgb(211, 211, 211);
//    Pen pen = new Pen(shadow[0]);
//    using (pen)
//    {
//        foreach (Panel p in panel.Controls.OfType<Panel>())
//        {
//            Point pt = p.Location;
//            pt.Y += p.Height;
//            for (var sp = 0; sp < 3; sp++)
//            {
//                pen.Color = shadow[sp];
//                e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
//                pt.Y++;
//            }
//        }
//    }
//}