using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Models;

namespace SuperMarket.API.Services
{
    public interface IPurchaseService
    {
        Task<IEnumerable<Purchase>> ListAsync();
        Task<PurchaseResponse> SaveAsync(Purchase purchase);

    }
}
