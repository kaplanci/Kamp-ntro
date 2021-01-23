using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms yollandı");
        }
    }
}
