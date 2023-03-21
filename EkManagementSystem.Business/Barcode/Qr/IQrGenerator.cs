﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Business.Qr
{
    public interface IQrGenerator
    {
        void GenerateQrCode(string value, string qrCodeNameWithFileExtension);
        string ReadQrCode(string qrCodeNameToRead);
         string QrCodeFileName { get; set; }
    }
}