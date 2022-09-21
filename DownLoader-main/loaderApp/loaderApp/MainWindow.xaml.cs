using System;
using System.Net;
using System.Collections.Generic;
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
using System.Diagnostics;
using System.Reflection;

namespace loaderApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        public void download(string link, string name)
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile(link, name);
            }
        }




      





        private void firefox(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please click OK and wait for installation");
            download("https://download.mozilla.org/?product=firefox-stub&os=win&lang=ru", "firefox.exe");
            Process.Start(@"firefox.exe");

        }




        private void sharex(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please click OK and wait for installation");
            download("https://github.com/ShareX/ShareX/releases/download/v14.1.0/ShareX-14.1.0-setup.exe", "ShareX.exe");
            Process.Start(@"ShareX.exe");

        }



        private void spot(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please click OK and wait for installation");
            download("https://download.scdn.co/SpotifySetup.exe", "spotifi.exe");
            Process.Start(@"spotifi.exe");

        }




        private void steam(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please click OK and wait for installation");
            download("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe", "steam.exe");
            Process.Start(@"steam.exe");

        }






        private void telegram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please click OK and wait for installation");
            download("https://telegram.org/dl/desktop/win64", "telegram.exe");
            Process.Start(@"telegram.exe");

        }





        




        
        private void py(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please click OK and wait for installation");
            download("https://download.jetbrains.com/python/pycharm-community-2022.2.2.exe", "pytcharm.exe");
            Process.Start(@"pytcharm.exe");


        }


        private void git(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please click OK and wait for installation");
            download("https://central.github.com/deployments/desktop/desktop/latest/win32", "github.exe");
            Process.Start(@"github.exe");


        }




    }







}
