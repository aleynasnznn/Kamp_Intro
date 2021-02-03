using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyac Credit payment plan has been calculated");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
