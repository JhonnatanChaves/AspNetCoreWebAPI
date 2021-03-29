using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMarket.API.Models;

namespace SuperMarket.API.Data
{
    public class SuperMarketContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        
        public SuperMarketContext(DbContextOptions<SuperMarketContext>options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired();
            builder.Entity<User>().Property(p => p.Name).IsRequired();            
            builder.Entity<User>().Property(p => p.Cpf).IsRequired().HasMaxLength(14);
            builder.Entity<User>().Property(p => p.Email).IsRequired();
            builder.Entity<User>().Property(p => p.Password).IsRequired().HasMaxLength(8);
            builder.Entity<User>().Property(p => p.Purchases);


            builder.Entity<User>().HasData
            (
                new User { Id = 1, Name = "José Caetano Rodrigues de Freitas", Cpf = "456.123.148-52", Email = "jc@outmail.com", Password="12345678"  },
                new User { Id = 2, Name = "Roberta Ana Souza Passos", Cpf = "058.657.789-12", Email = "roberta@outmail.com", Password = "12345678" }

            );

            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired();
            builder.Entity<Company>().Property(p => p.FancyName).IsRequired();
            builder.Entity<Company>().Property(p => p.SocialReason);
            builder.Entity<Company>().Property(p => p.Cnpj).IsRequired().HasMaxLength(18);

            builder.Entity<Company>().HasData
            (
                
             new Company { Id = 1, FancyName = "Depósito Jaguatirica", Cnpj = "12.785.496/0001-23" },
             new Company { Id = 2, FancyName = "Armazém Central de Anápolis ", Cnpj = "07.663.123/0001-78" }
            );

            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired();
            builder.Entity<Product>().Property(p => p.Name).IsRequired();
            builder.Entity<Product>().Property(p => p.Description).IsRequired();
            builder.Entity<Product>().Property(p => p.Value).IsRequired();
            builder.Entity<Product>().Property(p => p.Observation);
            builder.Entity<Product>().Property(p => p.Purchases);

            builder.Entity<Company>()
                .HasMany(p => p.Products)
                .WithOne(p => p.Company)
                .HasForeignKey(p => p.CompanyId);




        }



    }
}
