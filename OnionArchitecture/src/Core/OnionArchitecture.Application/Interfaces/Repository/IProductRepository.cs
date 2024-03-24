using OnionArchitecture.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Interfaces.Repository
{
    public interface IProductRepository:IGenericRepositoryAsync<Product>
    {
        
    }
}
