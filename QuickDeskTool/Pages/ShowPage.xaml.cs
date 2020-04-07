using QuickDeskTool.Tool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuickDeskTool.Pages
{
    /// <summary>
    /// ShowPage.xaml 的交互逻辑
    /// </summary>
    public partial class ShowPage : Window
    {
        List<string> imageslist = new List<string>();
        int imageNum = 0;
        string path;
        public ShowPage()
        {
            InitializeComponent();
        }
        public void showMutiImages(string folder)
        {
            path = folder;
            var files= Directory.GetFiles(folder);
            var images = from i in files
                         where i.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) | i.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                         select i;
            imageslist.AddRange(images);
            showImage(imageslist[imageNum]);
        }
        public void showImage(string imgpath)
        {
            try
            {
            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            bi.UriSource = new Uri(imgpath, UriKind.Absolute);
            bi.EndInit();

            //Stream imageStreamSource = new FileStream(imgpath, FileMode.Open, FileAccess.Read, FileShare.Read);
            //JpegBitmapDecoder decoder = new JpegBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            //BitmapSource bi = decoder.Frames[0];

            //ImageHelper.GetImageSource(imgpath);

            img.Source = bi;
            }
            catch (Exception)
            {
                 
                showNext();
            }

        }

        private void img_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            showNext();
        }
        private void refresh()
        {
            imageslist.Clear();
            showMutiImages(path);
        }
        private void showNext()
        {
            if (imageslist.Count() > 0)
            {
                if (imageNum == imageslist.Count() - 1)
                {
                    imageNum = 0;

                }
                else
                {
                    imageNum++;
                }
                if (!File.Exists(imageslist[imageNum]))
                    refresh();
                else
                    showImage(imageslist[imageNum]);
            }
        }
    }
}
