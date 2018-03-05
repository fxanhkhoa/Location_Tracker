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
using System.Windows.Threading;

namespace Location_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /***** Variables *******************************************************************
        *
        *                                                                               
        ************************************************************************************/
        String sURL = AppDomain.CurrentDomain.BaseDirectory + "html/Google_Maps_Satellite.html";
        string filePath_satellite = AppDomain.CurrentDomain.BaseDirectory + "html/Google_Maps_Satellite.html";
        string filePath_terran = AppDomain.CurrentDomain.BaseDirectory + "html/Google_Maps_Terran.html";
        Uri uri;
        
        double Lat, Lon,speed;
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnLastWindowClose;
        }

        private void DockPanel_Loaded(object sender, RoutedEventArgs e)
        {
            uri = new Uri(sURL);
            webBrowser1.Navigate(uri);
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);

            radio_btn_satellite.IsChecked = true;

            /******* Timer ******
            *
                *
            ********************/
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Current_Location.Text = GlobalVar.Lat.ToString() + "\n" + GlobalVar.Lon.ToString();
                GetMap(GlobalVar.Lat, GlobalVar.Lon);
                speed = GlobalVar.Speed_Time_Calculate.getSpeed();
                Current_Speed.Text = speed.ToString();
                Remain_Distance.Text = GlobalVar.Distance.ToString();
                webBrowser1.Refresh();
            }
            catch (Exception ex)
            {

            }
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

            //Lat = 11.4708344;
            //Lon = 106.9748374;
            //GetMap(Lat, Lon);
            webBrowser1.Refresh();
        }

        private void radio_btn_Terran_Checked(object sender, RoutedEventArgs e)
        {
            sURL = filePath_terran;
            uri = new Uri(sURL);
            webBrowser1.Navigate(uri);
        }

        private void radio_btn_satellite_Checked(object sender, RoutedEventArgs e)
        {
            sURL = filePath_satellite;
            uri = new Uri(sURL);
            webBrowser1.Navigate(uri);
        }

        private void btn_Serial_Refresh_Click(object sender, RoutedEventArgs e)
        {
            Serial_Add_Element();
        }

        private void btn_Serial_Connect_Click(object sender, RoutedEventArgs e)
        {
            string comName, Baud, Databits, Parity, Stopbit;
            Boolean OK;

            try
            {
                comName = combo_box_COM.SelectedItem.ToString();
                Baud = combo_box_BaudRate.SelectedItem.ToString();
                Databits = combo_box_Databits.SelectedItem.ToString();
                Parity = combo_box_Parity.SelectedItem.ToString();
                Stopbit = combo_box_Stopbit.SelectedItem.ToString();

                OK = GlobalVar.Serial_Data.connect(comName, Baud, Databits, Parity, Stopbit);
                if (OK)
                {
                    ProgressBar_Connection_Status.Value = 100;

                }
                else
                {
                    ProgressBar_Connection_Status.Value = 0;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Serial_Add_Element()
        {
            List<string> temp = new List<string>();

            // Get All PortName
            temp = GlobalVar.Serial_Data.Get_PORT();
            combo_box_COM.ItemsSource = temp;
            //combo_box_COM.SelectedIndex = 0;

            //Get BaudRate
            temp = GlobalVar.Serial_Data.Get_Baud();
            combo_box_BaudRate.ItemsSource = temp;
            combo_box_BaudRate.SelectedIndex = 2;

            //Get Databits
            temp = GlobalVar.Serial_Data.Get_Databits();
            combo_box_Databits.ItemsSource = temp;
            combo_box_Databits.SelectedIndex = 1;

            //Get Parity
            temp = GlobalVar.Serial_Data.Get_Parity();
            combo_box_Parity.ItemsSource = temp;
            combo_box_Parity.SelectedIndex = 0;

            //Get Stopbit
            temp = GlobalVar.Serial_Data.Get_Stopbit();
            combo_box_Stopbit.ItemsSource = temp;
            combo_box_Stopbit.SelectedIndex = 1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GlobalVar.Serial_Data = new Serial_Data();
            GlobalVar.Speed_Time_Calculate = new Speed_Time_Calculate();
            Serial_Add_Element();
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
