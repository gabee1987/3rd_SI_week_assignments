using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsUpdateLogFormatter
{
    class WindowsUpdateLogformatterExercise
    {
        static void Main(string[] args)
        {
            WindowsUpdateLogformatterExercise updateLog = new WindowsUpdateLogformatterExercise();
            string fileToOpen = @"WindowsUpdate.log";
            List<String> rawList = OpenFile(fileToOpen);
            List<String> formattedList = FormatDate(rawList);
            WriteFile(formattedList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successfully formatted the file.");
            Console.ResetColor();
            Console.ReadLine();
        }

        static List<String> OpenFile(string filePath)
        {
            var resultLines = new List<String>();
            try
            {
                resultLines = File.ReadAllLines(filePath).ToList();
            }
            catch (IOException ie)
            {
                Console.WriteLine(ie);
            }
            return resultLines;
        }

        static void WriteFile(List<String> contentToWrite)
        {
            try
            {
                File.WriteAllLines(@"WindowsUpdateFormatted.log", contentToWrite);
            }
            catch (IOException ie)
            {
                Console.WriteLine(ie);
            }
        }

        static List<String> FormatDate(List<String> inputList)
        {
            var modifiedDates = new List<String>();
            string pattern = @"^\d{4}\/(0?[1-9]|1[012])\/(0?[1-9]|[12][0-9]|3[01])$";
            string newPattern = @"(0\d{1}|1[0-2])\/([0-2]\d{1}|3[0-1])\/(19|20)\d{2}";
            
            Regex regex = new Regex(pattern);
            
            foreach (String line in inputList)
            {
                modifiedDates.Add(ReformatDate(line));
            }
            return modifiedDates;
        }

        private static string ReformatDate(String dateInput)
        {
            string pattern = @"([12]\d{3}/(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01]))";
            string foundDate = DateTime.Parse(Regex.Match(dateInput, pattern).Value).ToString("MM/dd/yyyy");

            return Regex.Replace(dateInput, pattern, foundDate);
        }
    }
}
