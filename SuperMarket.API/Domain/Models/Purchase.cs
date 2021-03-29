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


      
        /*
        public Purchase()
        {
        }

        public Purchase(int id, float value, DateTime date, EPaymentMethod paymentMethod, EPurchaseStatus purchaseStatus, string observation, string zipCode, string address, int userId)
        {
            Id = id;
            Value = value;
            Date = date;
            PaymentMethod = paymentMethod;
            PurchaseStatus = purchaseStatus;
            Observation = observation;
            ZipCode = zipCode;
            Address = address;
            UserId = userId;
        }
        */
    }
   
}
