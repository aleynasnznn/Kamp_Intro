using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager ihtiyacCreditManager = new İhtiyacCreditManager();
            ICreditBaseManager tasitCreditManager = new TasitCreditManager();
            ICreditBaseManager konutCreditManager = new KonutCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApp(ihtiyacCreditManager, new List<ILoggerService> { new DatabaseLoggerService(),new FileLoggerService() });
            Console.WriteLine("//");

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() { ihtiyacCreditManager , tasitCreditManager };
            applicationManager.GivePreInfo(credits);
        }
    }
}
