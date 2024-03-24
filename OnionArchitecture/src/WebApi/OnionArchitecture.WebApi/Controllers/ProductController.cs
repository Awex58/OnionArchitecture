using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Commands.CreateProduct;
using OnionArchitecture.Application.Features.Queries.GetAllProducts;
using OnionArchitecture.Application.Features.Queries.GetProductById;

namespace OnionArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediatr;

        public ProductController(IMediator mediatr)
        {
            this.mediatr = mediatr;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();

            return Ok(await mediatr.Send(query));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() {Id=id};

            return Ok(await mediatr.Send(query));

        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediatr.Send(command));
        }

    }
}
