namespace Consructors
{
    class Program
    {
        // consructors bir class ı new lediğimizde çalışan blok 
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Ömer",LastName="Şan",City="Hatay"};
            Customer customer2 = new Customer ( 2, "Onur", "Şan", "Hatay" );
            Console.WriteLine(customer2.FirstName);
        }

      
    }

    class Customer 
    {
       

        public Customer()
        {

        }
        // default consructors 
        public Customer(int id , string firstname, string lastname, string city)
        {
            //Console.WriteLine("yapıcı blok çalıştı");
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}
