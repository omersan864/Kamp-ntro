using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void Customerradd(Musteri orders)
        {
            Console.WriteLine("müşteri eklendi : " + orders.Name);
        }
        
        public void delete(Musteri orders)
        {
            Console.WriteLine("müşteri silindi : " + orders.Name,orders.Soyisim);
        }





    }
}
