using AbstractInterfaceDemo.Abstract;//bu ikisi bağlama 
using AbstractInterfaceDemo.Entities;//
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemo.Concrete
{
    public class StarbucksCustomerManager :BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        
    }
}
