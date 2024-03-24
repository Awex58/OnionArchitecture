using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDto>>
    {
        IProductRepository _productRepository;
        private readonly IMapper mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<ProductViewDto>(product);

            return new ServiceResponse<ProductViewDto>(dto);
        }
    }
}
