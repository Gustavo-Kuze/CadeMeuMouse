using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace CadeMeuMouse.GUI
{
    public partial class FrmPointer : Form
    {
        public FrmPointer()
        {
            InitializeComponent();
        }

        private void FrmCursor_Load(object sender, EventArgs e)
        {
            App.Utils.IsEnabled = true; // pointer enabled to animate on shake
            loadPointerImageIntoPictureBox();
            createScannerThread();
            createPointerMoverThread();
        }

        #region Create Pointer mover thread
        private void createPointerMoverThread()
        {
            Thread pointerMoverThread = App.Utils.startNewBackgroundThread(() =>
            {

                while (App.Utils.IsEnabled == true && App.Info.IsRunning == true)
                {
                    if (App.Utils.IsEnabled)
                    {
                        PointerBehavior.Controller.moveCursor();
                    }
                    Thread.Sleep(1);
                }
            });
        }
        #endregion

        #region Create scanner thread

        private void createScannerThread()
        {
            Thread scannerThread = App.Utils.startNewBackgroundThread(() =>
            {
                while (App.Utils.IsEnabled == true && App.Info.IsRunning == true)
                {
                    if (PointerBehavior.Controller.isShowTime())
                    {
                        PointerBehavior.Controller.animatePointer(picMouse);
                        Thread.Sleep(Settings.Runtime.Loaded.EnabledTime); //remain on the screen
                    }
                    else
                    {
                        PointerBehavior.Controller.hidePointerForm();
                    }
                    if (App.Utils.IsSystemCursorHidden)
                    {
                        try
                        {
                            Invoke(new MethodInvoker(() =>
                            {
                                Cursor.Show();
                                App.Utils.IsSystemCursorHidden = false;
                            }));
                        }
                        catch (Exception ex)
                        {
                            //new App.Logger().add(ex.Message + "\n" + ex.StackTrace);
                        }

                    }
                    Thread.Sleep(1);
                }
            });

        }

        #endregion

        #region Create Params
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



        private void loadPointerImageIntoPictureBox()
        {
            picMouse.Image = Image.FromFile(Settings.Runtime.Loaded.CursorImagePath);
        }

        private void picMouse_Click(object sender, EventArgs e)
        {
            //Behavior.Controller.hidePointerForm(); //before win32API implementation
        }


        private void FrmCursor_FormClosing(object sender, FormClosingEventArgs e)
        {
            App.Utils.IsEnabled = false;
            if (App.Utils.IsSystemCursorHidden)
            {
                try
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        Cursor.Show();
                    }));
                }
                catch (Exception ex)
                {
                    new App.Logger().add(ex.Message + "\n" + ex.StackTrace);
                }
            }
        }

    }
}


