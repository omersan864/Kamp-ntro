using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    // ürünler ile ilgili operasyonları içerir CRUD CREATE READ UPDATE DELETE 
    public class ProductManager
    {
        // encapsulation   class ı kümülatif olarak yolluyoruz 
        public void Add (Product product ) // product türünde bir product vermek gerekir add fonk. 
        {
            Console.WriteLine(product.ProductName + "product in added");
        }
        public void Update (Product product ) 
        {
            Console.WriteLine(product.ProductName + "product in update");
        }

        // aşağıda void ve int kullanımı gösterilmiştir bu ikisinin kullanımında 
        // eğer sonucu daha sonra kullanmak istersek void kullanmamız gerekir 
        // örnek olarak faiz hesaplamasından sonra çıkan değeri kullanacak isek void return sayesinde tekrar kullanabiliriz 
        public int Topla (int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }

        public void Topla2(int sayı1, int sayı2)
        {
            Console.WriteLine(sayı1 + sayı2);
        }

    }
}
