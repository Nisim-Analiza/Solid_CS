using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        private ILogger Logger;
        private EmailAlert EmailAlert;
        public EmergencyHandler(ILogger logger, EmailAlert emailAlert)
        {
            Logger = logger;
            EmailAlert = emailAlert;
        }
        public void LogEvent()
        {
            Logger.LogMessage("EMERGENCY OCCURRED");
        }
        public void SendEmail()
        {
            EmailAlert.SendEmailToAdmin();
        }
        public void TriggerShutdown()  {
            Console.WriteLine("System Emergency shutdown triggered!");
            LogEvent();
            SendEmail();
        }

    }
    
}
