using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public  class Product
    {
        // snippet hazır kodlar demek iki kere tab tuşuna bak
        public int Id { get; set; } // primary key
        public int CategoryId { get; set; } // referens değerleri for in  key 
        public string ProductName { get; set; }
        public double  UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        // CRUD OPERASYONLARI
        // CREATE  >> READ >> UPDATE >> DELETE 
    }
}
