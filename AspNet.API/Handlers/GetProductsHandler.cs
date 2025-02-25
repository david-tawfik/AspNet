using AspNet.API.Queries;
using AspNet.Application.IService;
using AspNet.Domain;
using MediatR;

namespace AspNet.API.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductService _productService;
        public GetProductsHandler(IProductService productService)
        {
            _productService = productService;
        }

        public Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return _productService.GetAllProducts();
        }
    }
}
