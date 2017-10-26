using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Classes
{
    public static class UploadedDocumentClass
    {
        static string fileName;
        static string filePath;
        static string fileContent;

        /// <summary>
        /// Konstruktor klase
        /// </summary>
        /// <param name="name">Ime datoteke</param>
        /// <param name="path">Putanja datoteke</param>
        /// <param name="content">Sadržaj datoteke</param>
        public static void SetUploadedDocument(string name, string path, string content)
        {
            fileName = name;
            filePath = path;
            fileContent = content;
        }

        /// <summary>
        /// Getter koji vraća ime datoteke
        /// </summary>
        /// <returns>Ime datoteke</returns>
        public static string GetFileName()
        {
            return fileName;
        }

        /// <summary>
        /// Getter koji vraća putanju datoteke
        /// </summary>
        /// <returns>Putanja datoteke</returns>
        public static string GetFilePath()
        {
            return filePath;
        }

        /// <summary>
        /// Getter koji vraća sadržaj datoteke
        /// </summary>
        /// <returns>Sadržaj datoteke</returns>
        public static string GetFileContent()
        {
            return fileContent;
        }

        /// <summary>
        /// Čisiti sve podatke iz klase
        /// </summary>
        public static void CleanData()
        {
            fileName = "";
            filePath = "";
            fileContent = "";
        }

    }
}
