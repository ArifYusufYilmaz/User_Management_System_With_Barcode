using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.InstanceFactory_;
using EkUserManagementSystem.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private IInstanceService _instanceService;
        private IUserService _userService;
        private IExternalFileUserService _externalFileUserService;
        

        public Page2(IInstanceService instanceService)
        {
            _instanceService = instanceService;
            _userService = _instanceService.GetUserService();
            _externalFileUserService = _instanceService.GetExcelUserService();
            InitializeComponent();
            //ShowAllUsers();
            
        }

        private void ShowAllUsers()
        {
            var result = _userService.GetAll();
            dg1.ItemsSource = result;
        }
        private bool IsFileOpenedSuccessfully = false;
        private List<User> GetUsersFromExcelFile()
        {
            List<User> users = null;
            try
            {
               users = _externalFileUserService.GetAll(txtSelectFile.Text);
                IsFileOpenedSuccessfully = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return users;

        }
        private void ShowUsersInExcelFile()
        {
            dg1.ItemsSource = GetUsersFromExcelFile();
        }
        private void AddByExcel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _externalFileUserService.AddAllUsers(_userService, GetUsersFromExcelFile());
                ShowAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    txtSelectFile.Text = openFileDialog.FileName;
                    ShowUsersInExcelFile();
                    AddByExcel.IsEnabled = checkIfFileSelectedForAddingByExcelButton();
                }
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        private bool checkIfFileSelectedForAddingByExcelButton()
        {
            return IsFileOpenedSuccessfully;
        }
    }
}
