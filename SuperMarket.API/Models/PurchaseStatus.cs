using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    enum Status
    {
        realizado,aguardando
    }
    public class PurchaseStatus
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
