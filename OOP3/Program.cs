using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();


            IKrediManager tasitKrediManager = new TasitKrediManager();


            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fiLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerManager(), new FileLoggerService() };

            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,tasitKrediManager
            };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
