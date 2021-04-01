using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    public class Company
    {

        public int Id { get; set; }
        public string FancyName { get; set; }
        public string SocialReason { get; set; }
        public string Cnpj { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();

    }
}
