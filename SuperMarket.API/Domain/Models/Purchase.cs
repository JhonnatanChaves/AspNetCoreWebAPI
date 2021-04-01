using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
    public class Purchase
    {

        public int Id { get; set; }
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public EPaymentMethod PaymentMethod { get; set; }
        public EPurchaseStatus PurchaseStatus { get; set; }
        public string Observation { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
   
}
