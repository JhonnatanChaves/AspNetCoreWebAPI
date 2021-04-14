using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Repositories
{
    public interface IPurchaseRepository
    {
        Task<IEnumerable<Purchase>> ListAsync();
        Task AddAsync(Purchase purchase);
    }
}
