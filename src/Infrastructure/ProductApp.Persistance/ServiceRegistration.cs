using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces;
using ProductApp.Persistance.ProductDbContext;
using ProductApp.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Persistance
{
    public static class ServiceRegistration
    {

        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();

        }


    }
}
