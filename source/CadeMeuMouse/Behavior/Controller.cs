using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CadeMeuMouse.Behavior
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
                Helper.getCursorInstance().Invoke(new MethodInvoker(() =>
                {
                    Helper.getCursorInstance().Opacity = 0;
                    Helper.getCursorInstance().TopMost = false;
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
                Helper.getCursorInstance().Invoke(new MethodInvoker(() =>
                {
                    Helper.getCursorInstance().Opacity = 100;
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
            Helper.IsSystemCursorHidden = false;
            while (siz <= Settings.Runtime.Loaded.CursorAnimationEndSize)
            {
                if (App.Utils.isAnyMouseButtonDown())
                {
                    hidePointerForm();
                    break;
                }
                if (App.Info.IsRunning && Helper.IsEnabled)
                {
                    try
                    {
                        siz += 1;
                        Helper.getCursorInstance().Invoke(new MethodInvoker(() =>
                        {
                            picMouse.Size = new Size(siz, siz);
                            picMouse.Location = new Point((Helper.getCursorInstance().Width / 2) - picMouse.Width / 2, Helper.getCursorInstance().Height / 2 - picMouse.Height / 2);
                            if (!Helper.IsSystemCursorHidden)
                            {
                                Cursor.Hide();
                                Helper.IsSystemCursorHidden = true;
                            }

                        }));


                    }
                    catch (Exception ex)
                    {
                        new App.Logger().add(ex.Message + "\n" + ex.StackTrace);
                    }
                    Thread.Sleep(2);
                }
            }
        }

        internal static void moveCursor()
        {
            if (Helper.IsEnabled == true)
            {
                try
                {
                    Helper.getCursorInstance().Invoke(new MethodInvoker(() =>
                    {
                        var curP = Cursor.Position;
                        curP = new Point(curP.X - (Helper.getCursorInstance().Width / 2), curP.Y - (Helper.getCursorInstance().Height / 2));
                        Helper.getCursorInstance().Location = curP;
                        Helper.getCursorInstance().TopMost = true;
                        Helper.getCursorInstance().BringToFront();

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


        internal void setTimeout(Action TheAction, int Timeout)
        {
            Thread t = new Thread(
                () =>
                {
                    Thread.Sleep(Timeout);
                    TheAction.Invoke();
                }
            );
            t.Start();
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

#endregion