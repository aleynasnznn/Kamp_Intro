using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeAnApp(ICreditBaseManager creditBaseManager,List<ILoggerService> loggerServices)
        {
            //Client information is evaluated
            creditBaseManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void GivePreInfo(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
