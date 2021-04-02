using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Repository
{
        public interface ICompanyRepository
        {
            Task<IEnumerable<Company>> ListAsync();
            Task AddAsync(Company company);
        }
    
}
