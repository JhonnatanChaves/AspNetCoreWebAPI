using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public string Observation { get; set; }
        public IList<Purchase> Purchases { get; set; } = new List<Purchase>();
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
