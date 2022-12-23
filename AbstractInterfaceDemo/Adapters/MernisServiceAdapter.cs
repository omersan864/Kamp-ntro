using AbstractInterfaceDemo.Entities;
using MernisServiceReference; // bu kısım olmalı
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemo.Adapters
{
    public class MernisServiceAdapter : Abstract.ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient Client = new KPSPublicSoapClient();
            return Client.TCKimlikNoDogrula(Convert.ToInt64(customer.NatinonalityId),
                                            customer.Name.ToUpper(),
                                            customer.LastName.ToUpper(),
                                            customer.DateOfBirth.Year);

        }
    }
}
