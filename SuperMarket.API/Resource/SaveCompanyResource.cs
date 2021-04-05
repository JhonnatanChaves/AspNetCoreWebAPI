using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Resource
{
    public class SaveCompanyResource
    {
        
        [Required]
        [MaxLength]

        public String fancyName { get; set; }
    }
}
