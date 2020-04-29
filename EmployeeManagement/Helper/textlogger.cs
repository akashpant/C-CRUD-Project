using System;
using System.IO;

namespace ConsoleApp2
{
    class textlogger
    {
        public static void Text (string message)
        {
            string fileLocation = @"C:\Users\uchiha\source\repos\ConsoleApp2\bin\Debug\netcoreapp3.1\date.Txt";
            if (!File.Exists(fileLocation))
            {
                using (StreamWriter sw = File.CreateText(fileLocation))
                {
                    sw.WriteLine( $"{DateTime.Now} { message}");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(fileLocation))
                {
                    sw.WriteLine($"{ DateTime.Now} {message}");
                }
            }
        }
    }
}
