namespace OOP2
{
    class Program
    {
        // soyutlama kavramına giriş yapılacak 
        public static void Main(string[] args)
        {
            IndividualCustomer customer1= new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "1234";
            customer1.Name = "ömer";
            customer1.LastName = "Şan";
            customer1.TcNo = "27655";



            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "12345";
            customer2.CompanyName = "Axa";
            customer2.TaxNumber = "1234";


            //Gerçek müşteri -  Tüzel müşteri
            //SOLID 

            Customer customer3= new IndividualCustomer ();
            Customer customer4= new CoorporateCustomer();

            CustomerManager customerManager= new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}