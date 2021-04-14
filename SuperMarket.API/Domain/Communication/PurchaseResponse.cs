using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Communication
{
    public class PurchaseResponse : BaseResponse
    {
        public Purchase Purchase { get; private set; }
        private PurchaseResponse(bool sucess, string message, Purchase purchase) : base(sucess, message)
        {
            Purchase = purchase;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="purchase">Saved purchase.</param>
        /// <returns>Response.</returns>
        public PurchaseResponse(Purchase purchase) : this(true, string.Empty, purchase) { }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="message">Error message. </param>
        /// <returns>Response.</returns>
        public PurchaseResponse(string message) : this(false, message, null) { }
    }
}
