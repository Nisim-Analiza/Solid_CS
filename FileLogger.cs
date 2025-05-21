using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class FileLogger :ILogger
    {
        public void send(string pathLog ,string msg)
        {
            Console.WriteLine("pathLog.txt", "Maesseag");
        }

    }
}
