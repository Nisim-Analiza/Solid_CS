using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        private string DbConnetion;
        public DatabaseLogger(string db) { 
            DbConnetion = db;
        }
        public void LogMessage(string message)
        {
            Console.WriteLine($"Saved in DB,{message}");
        }
    }
}
