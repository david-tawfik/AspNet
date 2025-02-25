using AspNet.API.Commands;
using AspNet.Application.IService;
using MediatR;

namespace AspNet.API.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IProductService _productService;
        public AddProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.AddProduct(request.Product);
            return;
        }
    }
}
