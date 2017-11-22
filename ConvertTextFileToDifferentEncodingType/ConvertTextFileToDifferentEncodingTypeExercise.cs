using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFileToDifferentEncodingType
{
    class ConvertTextFileToDifferentEncodingTypeExercise
    {
        static void Main(string[] args)
        {
            string currentPath = Environment.CurrentDirectory;
            string filenameToOpen = @"\test.txt";
            string filenameToWrite = @"\test-utf7.txt";
            string pathToOpen = currentPath + filenameToOpen;
            string pathToWrite = currentPath + filenameToWrite;

            StreamReader sr = new StreamReader(pathToOpen);
            StreamWriter sw = new StreamWriter(pathToWrite, false, Encoding.UTF7);

            sw.WriteLine(sr.ReadToEnd());
            sw.Close();
            sr.Close();
        }
    }
}
