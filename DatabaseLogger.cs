using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger 
    {
        public void send(string db,string msg)
        {
            Console.WriteLine("log.txt", "EMERGENCY OCCURRED");
        }
    }
}
