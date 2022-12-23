using AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemo.Abstract
{
    public abstract class  BaseCustomerManager : ICustomerService // manager bir yönetim sistemi temel . içinde save methodu var bunu implemente ettik
    {
        public virtual void save(Customer customer)
        {
            Console.WriteLine("saved to db : " + customer.Name);
        }
    }
}
