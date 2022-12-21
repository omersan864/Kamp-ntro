using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // Miras inheratance // müşteri sınıfından tüzel müşteriyi miras aldı 
    internal class CoorporateCustomer:Customer
    {
        // Tüzel Müşteri

        
        public string CompanyName { get; set; }

        public string TaxNumber { get; set; }// vergi no
    }
}
}
