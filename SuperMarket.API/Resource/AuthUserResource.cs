using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Resource
{
    public class AuthUserResource
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Password { get; set; }

    }
}
