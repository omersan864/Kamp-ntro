// See https://aka.ms/new-console-template for more information
namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği 
            // do not repeat yourself >> kendini tekrarlanma 
            // değer tutucu  alias kategoriEtiketi 
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları Butonu ");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }

            Console.WriteLine(kategoriEtiketi);
        }

    }
}
