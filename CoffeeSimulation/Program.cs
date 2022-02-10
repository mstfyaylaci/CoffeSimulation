using CoffeeSimulation.Abstract;
using CoffeeSimulation.Adapters;
using CoffeeSimulation.CoffeeSimulation.Concretes;
using CoffeeSimulation.Entities;
using System;

namespace CoffeeSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarBucksCustomerManager(new MernisServiceAdapters);

            customerManager.Save(new Customer { DateTOfBirth = new DateTime(2001, 2, 1),
                FirstName="Mervan",LastName="Yaylacı",NationalityNo="13592519208" });

            Console.ReadLine();

        }
    }
}
