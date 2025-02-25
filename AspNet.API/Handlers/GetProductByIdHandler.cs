using AspNet.API.Queries;
using AspNet.Application.IService;
using MediatR;
using AspNet.Domain;

namespace AspNet.API.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductService _productService;
        public GetProductByIdHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductById(request.id);
        }
    }
}
