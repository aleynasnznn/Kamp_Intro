using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tasit Credit payment plan has been calculated");        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
