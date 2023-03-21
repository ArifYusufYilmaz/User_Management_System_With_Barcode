using EkManagementSystem.Business.Abstract;
using EkManagementSystem.Business.InstanceFactory_;
using EkManagementSystem.Business.Qr;
using EkUserManagementSystem.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private IInstanceService _instanceService;
        private IQrGenerator _qrGenerator;
        private IUserService _userService;
        private  string ResourcePathOfPicture { get; set; }
        private string UserInfo { get; set; }
        public string QrPath { get; set; }
        private FileManager fileManager = new FileManager();

        //FileManager' i daha iyi kullan!


        public Page1(IInstanceService instanceService)
        {
            InitializeComponent();
            _instanceService = instanceService;
            _qrGenerator = _instanceService.GetQrGeneratorService();
            _userService = _instanceService.GetUserService();
            
        }
        private void userSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = createUserByTextBoxValues();
                _userService.Add(user);
                UserInfo = user.ToString();
                fileManager.SaveSomethingToFolder(ResourcePathOfPicture, Convert.ToString(user.IdCardNo),"Pictures");
                QrCodeGenerator.IsEnabled = true;
                _qrGenerator.QrCodeFileName = Convert.ToString(user.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
       
        private User createUserByTextBoxValues()
        {
            User user = new User();
            user.FirstName = tbxFirstName.Text;
            user.LastName = tbxLastName.Text;
            user.PhoneNumber = Convert.ToInt64(tbxPhoneNumber.Text);
            user.IdCardNo = Convert.ToInt64(tbxIdCardNo.Text);
            user.Email = tbxEmail.Text;
            user.Address = tbxAddress.Text;
            return user;
        }
        private void DisplayImage(Image image, string resourceName)
        {
            image.Source = Image_Generator(resourceName);
        }
        private void QrCodeGenerator_Click(object sender, RoutedEventArgs e)
        {
            string value = UserInfo;
            string resourceName = QrCodeTargetPath();
            _qrGenerator.GenerateQrCode(value, resourceName);
            DisplayQrCode(QrCodeTargetPath());
            QrCodeDecoder.IsEnabled = true;
        }
        private void DisplayQrCode(string resourceName)
        {
            DisplayImage(ImgQrCode, resourceName);
        }
        private void DisplayPicture(string resourceName)
        {
            DisplayImage(ImgPicture, resourceName);
        }
        
        private BitmapImage Image_Generator(string resourceName)
        {   
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(resourceName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            return bitmap;
        }
        
        private string ResolveQrCode(string qrCodeNameToRead)
        {
            return _qrGenerator.ReadQrCode(qrCodeNameToRead);
        }
        private void ShowResolvedQrCode(string qrCodeNameToRead)
        {
            tbkDecodedQr.Text = ResolveQrCode(qrCodeNameToRead);
        }

        private void QrCodeDecoder_Click(object sender, RoutedEventArgs e)
        {
            string _rsrc = QrCodeTargetPath(); 
            ShowResolvedQrCode(_rsrc);
        }
       
        private void PictureLoader_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                // filter
                if (openFileDialog.ShowDialog() == true)
                {
                    DisplayPicture(openFileDialog.FileName);
                    ResourcePathOfPicture = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        private string QrCodeTargetPath()
        {
            //return GetDestinationPath(QrPath, "QrCodes");
            string fileName = _qrGenerator.QrCodeFileName;
            return fileManager.GetDestinationPath(fileName, "QrCodes");
        }
    }
}
