using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Concrete;
using System.Security.Cryptography.X509Certificates;

namespace AbstractInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager starbucksCustomer= new StarbucksCustomerManager(new CustomerCheckManager());
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.save(new Entities.Customer
            {DateOfBirth=new DateTime(1993,02,05),
             Name="Ömer",
             LastName="şan",
             Id=1993,NatinonalityId="27655"
            });

            starbucksCustomer.save(new Entities.Customer
            {
                DateOfBirth = new DateTime(2000, 02, 05),
                Name = "Ömer",
                LastName = "şan",
                Id = 1993,
                NatinonalityId = "27655"
            });
            Console.ReadLine();

        }
    }
}