using QuickDeskTool.Pages;
using QuickDeskTool.Tool;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickDeskTool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ShowPage showPage;
        public MainWindow()
        {
            InitializeComponent();
            //img.Source=
            //using (FileStream)
            //{

            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (showPage == null)
            {
                showPage = new ShowPage();
                showPage.Show();
                string path = @"C:\Users\zhouh\OneDrive\画像\wallpapers\【P站日榜】_2020_年3月5日_Pixiv日榜美图__P556_–_ACG调查小队";
                path = @"C:\Users\zhouh\OneDrive\画像\wallpapers\WallPaper";
                showPage.showMutiImages(path);
                showPage.Closing += ShowPage_Closing;
            }
        }

        private void ShowPage_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            showPage = null;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (showPage!=null)
            {
                showPage.Close();
                showPage =null;
            }
        }

        private void screenshot_Click(object sender, RoutedEventArgs e)
        {
            DesktopHelper.getDesktopScreen();
        }

        private void image_Click(object sender, RoutedEventArgs e)
        {
            //using (FileStream fs = File.OpenRead(@"C:\Users\zhouh\OneDrive\画像\wallpapers\WallPaper\2017-01-2girls-animal-ears-aoyama-sumika-black-eyes-black-hair-bow-breasts-brown-eyes-bunnygirl-coffee-kizoku-drink-long-hair-original-pantyhose-shiramine-rika-short-hair-tail.jpg"))
            //{

            //}

            var path = @"C:\Users\zhouh\OneDrive\画像\wallpapers\WallPaper\2017-01-2girls-animal-ears-aoyama-sumika-black-eyes-black-hair-bow-breasts-brown-eyes-bunnygirl-coffee-kizoku-drink-long-hair-original-pantyhose-shiramine-rika-short-hair-tail.jpg";
            path = @"C:\Users\zhouh\OneDrive\画像\wallpapers\WallPaper\2017-01-1991-blz-aqua-eyes-blue-blood-lagoon-blush-bow-braids-brown-hair-butterfly-food-fruit-green-hair-hat-instrument-long-hair-seifuku-short-hair-signed-skirt-socks-tagme-character-thighhighs-tree-watermark.jpg";
            path = @"C:\Users\zhouh\OneDrive\画像\WALLPA~1\WALLPA~1\2017-01-2girls-aliasing-animal-ears-black-hair-blush-bow-breasts-dress-eyepatch-flowers-garter-belt-goth-loli-headdress-jpeg-artifacts-lolita-fashion-long-hair-ribbons-rubi-sama-tsukikage-nemu-white-hair-yellow-eyes.jpg";
            ////BitmapImage MyBitmapImage = new BitmapImage(new Uri(path));   //BitmapImage可通过image.source显示到image控件中
            //var MyBitmapImage= ImageHelper.ByteArrayToBitmapImage( File.ReadAllBytes(path));
            //img.Source = MyBitmapImage;

            //            if (File.Exists(path))
            //            {
            //File.ReadAllBytes(path);
            //            }

            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(path);
            img.Source = ImageHelper.bitmapToBitmapSource(new Bitmap(originalImage));

            // Open the stream and read it back.
            //var folder = @"C:\Users\zhouh\OneDrive\画像\wallpapers\WallPaper";
            //var list = new List<string>();
            //var blist = new List<string>();
            //foreach (var item in Directory.GetFiles(folder))
            //{
            //    try
            //    {
            //        System.Drawing.Image originalImage = System.Drawing.Image.FromFile(item);
            //        blist.Append(String.Format("{0} {1}", item, originalImage.Width));

            //    }
            //    catch (Exception)
            //    {

            //        list.Append(item);
            //    }

            //}
            //File.AppendAllLines(@"C:\Users\zhouh\OneDrive\桌面\a.txt", list);
            //File.AppendAllLines(@"C:\Users\zhouh\OneDrive\桌面\b.txt", blist);
        }
    }
}
