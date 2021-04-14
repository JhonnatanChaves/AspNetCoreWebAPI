using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Resource
{
    public class PurchaseResource
    {
        public int Id { get; set; }
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public string Observation { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }             
}
