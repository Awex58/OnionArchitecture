using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
    {
        public String Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }



        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
        {
            private IProductRepository repository;
            private readonly IMapper mapper;

            public CreateProductCommandHandler(IProductRepository repository,IMapper mapper)
            {
                this.repository = repository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = mapper.Map<Domain.Entites.Product>(request);
                await repository.AddAsync(product);

                return new ServiceResponse<Guid>(product.Id);
            }
        }
    }
}
