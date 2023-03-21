using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.DependencyResolvers.Ninject;
using EkManagementSystem.Business.InstanceFactory_;
using EkManagementSystem.Business.Qr;
using EKManagementSystem.DataAccess.Concrete;
using EkUserManagementSystem.Entities;
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
using System.Windows.Shapes;

namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private IInstanceService _instanceService;
        
        public Window1()
        {
            InitializeComponent();
            _instanceService = new InstanceManager();
            _mainFrame.NavigationService.Navigate(new Page1(_instanceService));

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Page1(_instanceService));
           
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Page2(_instanceService));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Page3(_instanceService));
        }

        private void _mainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
