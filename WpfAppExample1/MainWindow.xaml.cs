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

namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindow currentWindow { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //App.Current.Shutdown();  -> shuts down the entire application
        // this.Close() -> only closes active window
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string password = "Vault";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPage4_Click(object sender, RoutedEventArgs e)
        {
            //Page1 pg1 = new Page1();
            //Main.Navigate(pg1);
        }

        private void btnPage5_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
