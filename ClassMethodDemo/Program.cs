// See https://aka.ms/new-console-template for more information
namespace ClassMethodDemo
{
    class Program 
    {
        static void Main(string[] args)
        {
            Musteri order1= new Musteri();
            order1.Name = "ömer ";
            order1.Soyisim = "Şan";
            order1.Adres = "hatay";
            order1.Musteri_Borc = 100;
            order1.Id= 1;

            Musteri order2 = new Musteri();
            order2.Name = "ONUR ";
            order2.Soyisim = "Şan";
            order2.Adres = "istanbul";
            order2.Musteri_Borc = 200;
            order2.Id = 2;

            Musteri order3 = new Musteri();
            order3.Name = "Nihal ";
            order3.Soyisim = "Şan";
            order3.Adres = "hatay";
            order3.Musteri_Borc = 10;
            order3.Id = 3;

            Musteri order4 = new Musteri();
            order4.Name = "ömer Faruk ";
            order4.Soyisim = "Şan";
            order4.Adres = "hassa";
            order4.Musteri_Borc = 100;
            order4.Id = 4;

            // array tanımladım musteri sayfası ile bağlantılı 
            Musteri[] orders = new Musteri[] { order1 ,order2,order3,order4};

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Customerradd(order4);
            musterimanager.Customerradd(order3);
            musterimanager.Customerradd(order2);
            musterimanager.Customerradd(order1);
            Console.WriteLine("------------------------------------");
            musterimanager.delete(order4);
            musterimanager.delete(order3);
            musterimanager.delete(order2);
            musterimanager.delete(order1);





        }
    }
}
