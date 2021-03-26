using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Repository
{
    interface IProductRepository
    {
        public interface IProductRepository
        {
            Task<IEnumerable<Product>> ListAsync();

        }

        Task<IEnumerable<Product>> ListAsync();
    }
}
