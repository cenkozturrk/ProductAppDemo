using ProductApp.Application.Interfaces;
using ProductApp.Domain.Entities;
using ProductApp.Persistance.ProductDbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Persistance.Repositories
{
    public class ProductRepository: GenericRepository<Product>,IProductRepository
    {
        //Kod tekrarından yine kaçmak için GenericRepositoryi buraya çekiyoruz.

        public ProductRepository(ApplicationDbContext dbContext): base(dbContext)
        {

        } 

    }
}
