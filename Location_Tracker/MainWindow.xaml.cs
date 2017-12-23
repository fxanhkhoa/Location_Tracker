using System;
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
using System.IO;

namespace Location_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String sURL = AppDomain.CurrentDomain.BaseDirectory + "html/Google_Maps_Satellite.html";
        string filePath_satellite = AppDomain.CurrentDomain.BaseDirectory + "html/Google_Maps_Satellite.html";
        string filePath_terran = AppDomain.CurrentDomain.BaseDirectory + "html/Google_Maps_Terran.html";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DockPanel_Loaded(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(sURL);
            webBrowser1.Navigate(uri);
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void setupObjectForScripting(object sender, RoutedEventArgs e)
        {

        }

        private void refresh_button_Click(object sender, RoutedEventArgs e)
        {
            //var file = new List<string>(File.ReadAllLines(sURL));
            //string s = "abcd";
            //file.RemoveAt(19);
            //file.Insert(19, s);
            //File.WriteAllLines(sURL, file.ToArray());

            GetMap(11.4708344, 106.9748374);
            webBrowser1.Refresh();
        }

        private void GetMap(double lat, double lon)
        {
            string command = "        var myLatlng = new google.maps.LatLng(" + lat.ToString() + "," + lon.ToString() + ")";
            string title = "            title:\"" + lat.ToString() + "," + lon.ToString() + "\"";

            var file = new List<string>(File.ReadAllLines(sURL));
            file.RemoveAt(41); // title of Lat and Lon
            file.Insert(41, title);
            file.RemoveAt(19); // Function Get map from Lat and Lon
            file.Insert(19, command);
            File.WriteAllLines(sURL, file.ToArray());
        }
    }
}
