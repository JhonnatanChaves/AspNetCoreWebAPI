using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Resource
{
    public class SavePurchaseResource
    {
        public int Id { get; set; }
        [Required]
        public float Value { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string Observation { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
