using AutoMapper;
using OnionArchitecture.Application.Features.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entites.Product, Dto.ProductViewDto>().ReverseMap();

            CreateMap<Domain.Entites.Product, CreateProductCommand>().ReverseMap();


        }
    }
}
