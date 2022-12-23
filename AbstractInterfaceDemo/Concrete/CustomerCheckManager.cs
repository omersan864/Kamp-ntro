using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {

        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();

            return true;
        }   
    }
}
