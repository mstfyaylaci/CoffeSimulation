using CoffeeSimulation.Abstract;
using CoffeeSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeSimulation.Adapters
{
    public class MernisServiceAdapters : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrulaAsync(customer.NationalityNo, customer.FirstName.ToUpper(), customer.LastName.ToUpper()
                , customer.DateTOfBirth);
        }
    }
}
