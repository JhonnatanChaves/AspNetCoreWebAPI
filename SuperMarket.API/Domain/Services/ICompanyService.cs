using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Services
{
        public interface ICompanyService
        {
            Task<IEnumerable<Company>> ListAsync();
            Task<Company> FindByIdAsync(int id);
            Task<IEnumerable<Company>> FindByNameAsync(string name);

            Task<CompanyResponse> SaveAsync(Company company);
            Task<CompanyResponse> UpdateAsync(int id,Company company);
            Task<CompanyResponse> DeleteAsync(int id);

            



        }
    
}
