using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // biri interface yi kullanırsa interface method larını içermeli 
    // okunurluğu arttırmak için interface I harfi ile başlar 
    interface ICreditManager 
    {
        void calculate();
        void BiseyYap();
    }
}
