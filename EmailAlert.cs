using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmailAlert:IEmailAlert
    {
        private string email;
       
        public EmailAlert(string email)
        {
            this.email = email;
        }

        public void SendEmailToAdmin()
        {
            Console.WriteLine($"Send Email To:{this.email}");
        }
    }
}
