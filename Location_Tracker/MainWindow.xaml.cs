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

namespace Location_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String sURL = AppDomain.CurrentDomain.BaseDirectory + "html/Google_Maps_Satellite.html";
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
    }
}
