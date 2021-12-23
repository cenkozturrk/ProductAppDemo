using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Persistance.ProductDbContext
{
    public class ApplicationDbContext: DbContext
    {


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Uygulama her çalıştığında sql kullanmadığımız için bu method ile aşağıdaki veriler gelicek.
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 100 },
                new Product() { Id = Guid.NewGuid(), Name = "Paper A4", Value = 1, Quantity = 200 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 30, Quantity = 500 }); ;



            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }

    }
}
