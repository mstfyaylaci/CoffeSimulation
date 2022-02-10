using CoffeeSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeSimulation.Abstract
{
   public interface ICustomerCheckService
    {
       public bool CheckIfRealPerson(Customer customer);
    }
}
