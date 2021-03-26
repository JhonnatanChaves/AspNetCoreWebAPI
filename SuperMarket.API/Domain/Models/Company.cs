using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    public class Company
    {
        public Company()
        {
        }

        public Company(int id, string fancyName, string socialReason, string cnpj)
        {
            Id = id;
            FancyName = fancyName;
            SocialReason = socialReason;
            Cnpj = cnpj;
        }

        public int Id { get; set; }
        public string FancyName { get; set; }
        public string SocialReason { get; set; }
        public string Cnpj { get; set; }

        public IEnumerable<Product> Products { get; set; }
        



    }
}
