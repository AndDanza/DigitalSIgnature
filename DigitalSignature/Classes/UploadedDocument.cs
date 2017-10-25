using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Classes
{
    public static class UploadedDocument
    {
        static string fileName;
        static string filePath;
        static string fileContent;

        public static void setFileName(string name, string path, string content)
        {
            fileName = name;
            filePath = path;
            fileContent = content;
        }

        public static string getFileName()
        {
            return fileName;
        }

        public static string getFilePath()
        {
            return filePath;
        }

        public static string getFileContent()
        {
            return fileContent;
        }

    }
}
