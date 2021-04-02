using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMarket.API.Data;
using SuperMarket.API.Domain.Repository;
using SuperMarket.API.Models;

namespace SuperMarket.API.Persistence.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(SuperMarketContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _context.Companies.ToListAsync();
        }
        public async Task AddAsync(Company company)
        {
            await _context.Companies.AddAsync(company);
        }

    }
}
