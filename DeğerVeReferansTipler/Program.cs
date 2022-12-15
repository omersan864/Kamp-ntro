// See https://aka.ms/new-console-template for more information
namespace DeğerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // değer tip 
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1= sayi2;

             sayi2 = 65;
            
            // sayı1 = ? 30 
            // 
            //referans tip 
            int[] sayılar1 = new int[] { 12, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };

            sayılar1 = sayılar2;

            sayılar2[0] = 999;

            //sayılar1[0]= ? ?  999
        }
    }
}
