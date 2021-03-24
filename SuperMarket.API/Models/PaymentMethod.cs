using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    enum Methods
    {
        cartao, boleto
    }
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
