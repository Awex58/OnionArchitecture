using MediatR;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery:IRequest<ServiceResponse<ProductViewDto>>
    {
        public Guid Id { get; set; }
    }
}
