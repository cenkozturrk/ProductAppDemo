using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces
{
    public interface IProductRepository: IGenericRepositoryAsync<Product>
    {
        //ById methodları süreklü bütün repositorylerin içinde olucak.Bu yüzden her repository içine aynı kodları yazmak yerine GenericRepository yazabiliriz.     
    }
}
