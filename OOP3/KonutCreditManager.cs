using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Credit payment plan has been calculated");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
