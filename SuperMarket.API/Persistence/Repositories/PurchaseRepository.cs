using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMarket.API.Data;
using SuperMarket.API.Domain.Repositories;
using SuperMarket.API.Models;

namespace SuperMarket.API.Persistence.Repositories
{
    public class PurchaseRepository : BaseRepository, IPurchaseRepository
    {
        public PurchaseRepository(SuperMarketContext context) : base(context)
        {
        }


        public async Task<IEnumerable<Purchase>> ListAsync()
        {
            return await _context.Purchases.ToListAsync();
        }
        public async Task AddAsync(Purchase purchase)
        {
            await _context.Purchases.AddAsync(purchase);
        }


    }
}
