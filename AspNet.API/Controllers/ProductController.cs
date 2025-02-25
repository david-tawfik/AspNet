using Microsoft.AspNetCore.Mvc;
using AspNet.Application.IService;
using MediatR;
using AspNet.Domain;
using AspNet.API.Queries;
using AspNet.API.Commands;
namespace AspNet.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await _mediator.Send(new GetProductsQuery());
    }

    [HttpPost]
    public async Task<ActionResult> AddProduct([FromBody] Product product)
    {
        await _mediator.Send(new AddProductCommand(product));
        return StatusCode(201);
    }

    [HttpGet("{id}")]
    public async Task<Product> GetProductById(int id)
    {
        return await _mediator.Send(new GetProductByIdQuery(id));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        await _mediator.Send(new DeleteProductCommand(id));
        return StatusCode(204);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateProduct(int id, [FromBody] Product product)
    {
        await _mediator.Send(new UpdateProductCommand(id, product));
        return StatusCode(204);
    }


}
