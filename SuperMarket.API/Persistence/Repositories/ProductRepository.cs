﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMarket.API.Data;
using SuperMarket.API.Domain.Repositories;
using SuperMarket.API.Models;

namespace SuperMarket.API.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(SuperMarketContext context) : base(context)
        {
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Company).ToListAsync();
        }

        public async Task<IEnumerable<Product>> FindByNameAsync(string name)
        {
            return await _context.Products.Where(x => x.Name.Contains(name)).ToListAsync();

        }

        public async Task<IEnumerable<Product>> FindProductByCompanyAsync(string nameCompanhia)
        {
            return await _context.Products.Where(x => x.Company.FancyName.Contains(nameCompanhia)).ToListAsync();

        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
        }

    }
}
