
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizilerdeki problem dizinin genişletilebilir olmamasıdır 4 elemanlı bir diziye ek bir eleman ekleyemiyoruz 
            // yaparsak eski elemanları kaybederiz yeni referans değeri üretilir 
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Ömer" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string>() { "engin ", "Murat", "Kerem", "Ömer" };
            //isimler2.Add("onur");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("onur");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}