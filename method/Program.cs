// See https://aka.ms/new-console-template for more information
namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            // methodlar bizim için tekrar tekrar  kullanılabilirliği sağlayan kod bloklarıdır 

            //Product[] fruits = new Product[] { };

            Product product1 = new Product();
            product1.Adi = "çilek";
            product1.Fiyati = 15;
            product1.Aciklama = "çilek gibi çilek";
            product1.Id= 1;

            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "diyarbakır karpuzu";
            product2.Id= 2;

            Product[] fruits= new Product[] { product1, product2 };

            foreach (Product product in fruits)
            {
               //property > özellik demek 
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Id);
                Console.WriteLine("-----------------------------------------");
            }

            Console.WriteLine("-------------------Metotlar-------------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            
            sepetManager.Add2("elma ", "adam gibi", 15);

        }
    }
}
