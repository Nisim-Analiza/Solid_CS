using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class TelemetrySender : ISmsAlert ,IEmailAlert
    {
        public void SendSms(int pn ,string msg)
        {
            Console.WriteLine();
        }
        public void SendEmail(string ea ,string msg)
        {
            Console.WriteLine();
        }
    }
}
