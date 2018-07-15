using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CadeMeuMouse.PointerBehavior
{
    internal class Controller
    {
        //private Form Parent { get; set; }
        

        internal Controller(/*Form ParentForm*/)
        {
            //Parent = ParentForm;
        }

        internal static void hidePointerForm()
        {
            try
            {
                App.Utils.getCursorInstance().Invoke(new MethodInvoker(() =>
                {
                    App.Utils.getCursorInstance().Opacity = 0;
                    App.Utils.getCursorInstance().TopMost = false;
                }));
            }
            catch
            {
            }
        }

        internal static void showPointerForm()
        {
            try
            {
                App.Utils.getCursorInstance().Invoke(new MethodInvoker(() =>
                {
                    App.Utils.getCursorInstance().Opacity = 100;
                    App.Utils.getCursorInstance().TopMost = true;
                    App.Utils.getCursorInstance().BringToFront();

                }));
            }
            catch (Exception ex)
            {
                new App.Logger().add(ex.Message + "\n" + ex.StackTrace);
            }
        }



        internal static void animatePointer(PictureBox picMouse)
        {
            int siz = Settings.Runtime.Loaded.CursorAnimationStartSize;

            showPointerForm();
            App.Utils.IsSystemCursorHidden = false;
            while (siz <= Settings.Runtime.Loaded.CursorAnimationEndSize)
            {
                if (App.Utils.isAnyMouseButtonDown())
                {
                    hidePointerForm();
                    break;
                }
                if (App.Info.IsRunning && App.Utils.IsEnabled)
                {
                    try
                    {
                        siz += 1;
                        App.Utils.getCursorInstance().Invoke(new MethodInvoker(() =>
                        {
                            picMouse.Size = new Size(siz, siz);
                            picMouse.Location = new Point((App.Utils.getCursorInstance().Width / 2) - picMouse.Width / 2, App.Utils.getCursorInstance().Height / 2 - picMouse.Height / 2);
                            if (!App.Utils.IsSystemCursorHidden)
                            {
                                Cursor.Hide();
                                App.Utils.IsSystemCursorHidden = true;
                            }

                        }));


                    }
                    catch (Exception ex)
                    {
                        new App.Logger().add(ex.Message + "\n" + ex.StackTrace);
                    }
                    Thread.Sleep(1);
                }
            }
        }



        /*Preciso ver se a propriedade offset me auxilia a fazer com que o cursor esteja alguns
         pixel à frente do mouse, e não "seguindo o meio" do mouse do sistema*/



        internal static void moveCursor()
        {
            if (App.Utils.IsEnabled == true)
            {
                try
                {
                    App.Utils.getCursorInstance().Invoke(new MethodInvoker(() =>
                    {
                        var curP = Cursor.Position;
                        curP = new Point(curP.X - (App.Utils.getCursorInstance().Width / 2), curP.Y - (App.Utils.getCursorInstance().Height / 2));
                        App.Utils.getCursorInstance().Location = curP;
                    }));
                }
                catch
                {
                }
            }
        }


        internal static bool isShowTime()
        {

            if (App.Utils.isAnyMouseButtonDown())
            {
                return false;
            }


            bool isIt = false;
            Point pos1, pos2;

            pos1 = Cursor.Position;
            Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
            pos2 = Cursor.Position;
            if (pos1.Y > pos2.Y)
            {
                Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                pos1 = Cursor.Position;
                if (pos1.Y < pos2.Y)
                {
                    Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                    pos1 = Cursor.Position;
                    if (pos1.Y > pos2.Y)
                    {
                        if (Settings.Runtime.Loaded.Sensitivity == "normal")
                        {
                            Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                            pos1 = Cursor.Position;
                            if (pos1.Y < pos2.Y)
                            {
                                isIt = true;
                            }
                        }
                        else
                        {
                            isIt = true;
                        }

                    }
                }
            }
            else if (pos1.Y < pos2.Y)
            {
                Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                pos1 = Cursor.Position;
                if (pos1.Y > pos2.Y)
                {
                    Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                    pos1 = Cursor.Position;
                    if (pos1.Y < pos2.Y)
                    {
                        if (Settings.Runtime.Loaded.Sensitivity == "normal")
                        {
                            Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                            pos1 = Cursor.Position;
                            if (pos1.Y > pos2.Y)
                            {
                                isIt = true;
                            }
                        }
                        else
                        {
                            isIt = true;
                        }
                    }
                }

            }
            else if (pos1.X > pos2.X)
            {
                Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                pos1 = Cursor.Position;
                if (pos1.X < pos2.X)
                {
                    Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                    pos1 = Cursor.Position;
                    if (pos1.X > pos2.X)
                    {
                        if (Settings.Runtime.Loaded.Sensitivity == "normal")
                        {
                            Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                            pos1 = Cursor.Position;
                            if (pos1.X < pos2.X)
                            {
                                isIt = true;
                            }
                        }
                        else
                        {
                            isIt = true;
                        }

                    }
                }
            }
            else if (pos1.X < pos2.X)
            {
                Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                pos1 = Cursor.Position;
                if (pos1.X > pos2.X)
                {
                    Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                    pos1 = Cursor.Position;
                    if (pos1.X < pos2.X)
                    {
                        if (Settings.Runtime.Loaded.Sensitivity == "normal")
                        {
                            Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
                            pos1 = Cursor.Position;
                            if (pos1.X > pos2.X)
                            {
                                isIt = true;
                            }
                        }
                        else
                        {
                            isIt = true;
                        }

                    }
                }
            }


            return isIt;
        }


       
    }
}


#region Comments

//internal static bool isShowTime2()
//{
//    Point[] pos = new Point[4];
//    bool isIt = false;

//    for (int i = 0; i < pos.Length; i++)
//    {
//        pos[i] = Cursor.Position;
//        Thread.Sleep(Settings.Runtime.Loaded.ScanningInterval);
//        if(i > 0)
//        {
//            if (pos[i - 1] == pos[i])
//            {
//                return false;
//            }
//        }
//    }

//    if(pos[0].Y > pos[1].Y || pos[0].X > pos[1].X)
//    {
//        if (pos[1].Y < pos[2].Y || pos[1].X < pos[2].X)
//        {
//            if (pos[2].Y > pos[3].Y || pos[2].X > pos[3].X)
//            {
//                isIt = true;
//            }
//        }
//    }

//    if (pos[0].Y < pos[1].Y || pos[0].X < pos[1].X)
//    {
//        if (pos[1].Y > pos[2].Y || pos[1].X > pos[2].X)
//        {
//            if (pos[2].Y < pos[3].Y || pos[2].X < pos[3].X)
//            {
//                isIt = true;
//            }
//        }
//    }

//    return isIt;
//}



//internal void setTimeout(Action TheAction, int Timeout)
//{
//    Thread t = new Thread(
//        () =>
//        {
//            Thread.Sleep(Timeout);
//            TheAction.Invoke();
//        }
//    );
//    t.Start();
//}

#endregion