using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickDeskTool.Tool
{
    class DesktopHelper
    {
        public static void getDesktopScreen()
        {
            using (Bitmap bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                            Screen.PrimaryScreen.Bounds.Height))
            using (Graphics g = Graphics.FromImage(bmpScreenCapture))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                 Screen.PrimaryScreen.Bounds.Y,
                                 0, 0,
                                 bmpScreenCapture.Size,
                                 CopyPixelOperation.SourceCopy);
                bmpScreenCapture.Save(@"C:\Users\zhouh\OneDrive\画像\screenshot.jpg", ImageFormat.Jpeg);

            }
        }
        public static void paintOnScreen(string filepath)
        {

        }
    }
}
