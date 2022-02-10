using CoffeeSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeSimulation.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
