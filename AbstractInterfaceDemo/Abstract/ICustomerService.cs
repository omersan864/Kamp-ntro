using AbstractInterfaceDemo.Entities;// bu kısım eklendi sonradan //entities dosyası ve Abstract dosyası bağlantı  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemo.Abstract
{
    public interface ICustomerService
    {
        void save(Customer customer); 
    }
}
