using CoffeeSimulation.Abstract;
using CoffeeSimulation.Entities;
using System;

namespace CoffeeSimulation.CoffeeSimulation.Concretes
{
    public class StarBucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

       

        public StarBucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                 base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
        }

       
    }
}
