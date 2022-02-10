using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeSimulation.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateTOfBirth { get; set; }

        public string NationalityNo { get; set; }
    }
}
