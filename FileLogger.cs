using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class FileLogger : ILogger
    {
        private string File_path;

        public FileLogger(string file_path)
        {
            File_path = file_path;
        }
        public void LogMessage(string message)
        {
            // here the DB config will be
            Console.WriteLine($"SAVED IN FILE,{message}");
        }
    }
}
