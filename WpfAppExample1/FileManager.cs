using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExample1
{
    public class FileManager
    {
        public string GetDestinationPath(string fileName, string folderName)
        {
            string appStartPath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

            appStartPath = string.Format(appStartPath + "\\{0}\\" + fileName, folderName);
            return appStartPath;
        }
       
        public string DestinationPath(string fileNameWithoutExtension, string folderName)
        {
            string fileName = fileNameWithoutExtension + ".jpg"; // kötü kullanım!
            return  GetDestinationPath(fileName, folderName);
             
        }
        public void SaveSomethingToFolder(string sourcePath,string fileNameWithoutExtension, string folderName)
        {
            string destinationPath = DestinationPath(fileNameWithoutExtension, folderName);
            File.Copy(sourcePath, destinationPath, true);
        }

    }
}
