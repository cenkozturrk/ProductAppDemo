using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProduct();
        Task<Product> GetProductById(Guid Id);

    }
}
