using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.InstanceFactory_;
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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private IInstanceService _insanceService;
        private IUserService _userService;
        public Page3(IInstanceService instanceService)
        {
            _insanceService = instanceService;
            InitializeComponent();
            _userService = _insanceService.GetUserService();
            ShowAll();
        }
        private void ShowAll()
        {
            dgAll.ItemsSource = _userService.GetAll();
        }

        private void dgAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
