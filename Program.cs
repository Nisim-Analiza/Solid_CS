using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {// TODO: move to ENV file
            bool useDatabase = false;
            string DB = "my-server-path";
            string FILE_PATH = "log.txt";
            string ADMIN_EMAIL = "admin@spaceagency.com";

            ILogger logger;
            if (useDatabase)
            {
                logger = new DatabaseLogger(DB);
            }
            else
            {
                logger = new FileLogger(FILE_PATH);
            }
            TelemetrySender telemetrySender = new TelemetrySender();
            RocketLauncher rocketLauncher = new RocketLauncher();
            telemetrySender.SendTelementry();
            rocketLauncher.Launch();
            EmailAlert alert = new EmailAlert(ADMIN_EMAIL);
            EmergencyHandler handler = new EmergencyHandler(logger, alert);
            handler.TriggerShutdown();
        }
    }
}
