using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Resource
{
    public class CompanyResource
    {
        public int id { get; set; }
        [Required]
        public string FancyName { get; set; }
        
    }
}
