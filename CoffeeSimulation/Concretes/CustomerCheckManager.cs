using CoffeeSimulation.Abstract;
using CoffeeSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeSimulation.Concretes
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return  true;
        }
    }
}
