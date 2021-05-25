using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Repository
{
        public interface ICompanyRepository
        {
            Task<IEnumerable<Company>> ListAsync();
            Task AddAsync(Company company);
            Task<Company> FindByIdAsync(int id);

            Task<IEnumerable<Company>> FindByNameAsync(string name);

            void Update(Company company);
            void Remove(Company company);



    }
    
}
