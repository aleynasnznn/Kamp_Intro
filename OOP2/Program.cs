using System;

namespace OOP2
{
    //SOLID
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.Name = "Aleyna";
            customer1.Surname = "Senozan";
            customer1.ID_no = "12345678910";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "54321";
            customer2.CompanyName = "Creative.io";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
