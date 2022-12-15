using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    internal class SepetManager
    {
        //convention >> isimlendirme kuralları 
        // encapsulation  >> product isismli sayfaya stok adedi ekledim 
        public void Add(Product fruits)
        {
            Console.WriteLine("sepete eklendi : " + fruits.Adi);
        }

        public void Add2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urunAdi);
        }
    }
}
