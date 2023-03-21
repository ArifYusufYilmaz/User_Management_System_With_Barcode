using IronBarCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.Qr
{
    public class QrGenerator : IQrGenerator
    {
        private string qrCodeFileName;
        public string QrCodeFileName { get { return qrCodeFileName; } set { qrCodeFileName = value + ".png"; } }
        public void GenerateQrCode(string value, string qrCodeNameWithFileExtension)
        {
            GeneratedBarcode qrCode1 = IronBarCode.BarcodeWriter.CreateBarcode(value, BarcodeWriterEncoding.QRCode);
            qrCode1.SaveAsImage(qrCodeNameWithFileExtension);
        }

        public string ReadQrCode(string qrCodeNameToRead)
        {
            BarcodeResult QRResult = BarcodeReader.QuicklyReadOneBarcode(qrCodeNameToRead);
            // Work with the results
            //string qrValues;
            string valueOfQr="";
            if (QRResult != null)
            {
                valueOfQr = QRResult.Value;
                Bitmap Img = QRResult.BarcodeImage;
                BarcodeEncoding BarcodeType = QRResult.BarcodeType;
                byte[] Binary = QRResult.BinaryValue;
                
                Console.WriteLine("*********: " + QRResult.Value);
              //   qrValues = QRResult.Value.Split(' ');
                
            }
            return valueOfQr;
        }
      
    }
    
}
