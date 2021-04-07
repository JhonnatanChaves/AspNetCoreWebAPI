﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Resource
{
    public class SaveProductResource
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public float Value { get; set; }

        public string Observation { get; set; }

        public Company Company { get; set; }



    }
}
