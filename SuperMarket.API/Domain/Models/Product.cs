using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    public class Product
    {

        /*
        public Product()
        {
        }

        public Product(int id, string name, string description, float value, string observation)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
            Observation = observation;
        }
        */

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public string Observation { get; set; }
        public IEnumerable<Purchase> Purchases { get; set; }

        public int CompanyId { get; set; }
        public Company Company;

    }
}
