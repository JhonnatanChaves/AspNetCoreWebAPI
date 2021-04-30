using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Resource
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public string Observation { get; set; }
        public EPaymentMethod FormOfPayment { get; set; }

        public CompanyResource Company { get; set; }
    }
}
