using System;
using System.Windows.Forms;

namespace ShakeAndFind.GUI
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {

            if (System.Globalization.CultureInfo.CurrentCulture.Name == "pt-BR")
            {
                lblVersion.Text = string.Format("Versão: v{0}", Application.ProductVersion);
            }
            else
            {
                lblVersion.Text = string.Format("Version: v{0}", Application.ProductVersion);
            }
        }
    }
}
