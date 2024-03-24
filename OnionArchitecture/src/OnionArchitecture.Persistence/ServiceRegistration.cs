using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Persistence.Context;
using OnionArchitecture.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServives(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("Memorydb"));

            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
