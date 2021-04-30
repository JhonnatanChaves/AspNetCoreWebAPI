using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.API.Models
{
  
    public enum EPaymentMethod : byte
    {
        [Description("BI")]
        Bill = 1,

        [Description("CC")]
        CreditCard = 2,

        [Description("DC")]
        DebitCard = 3,


    }
}
