using AspNet.API.Commands;
using AspNet.Application.IService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.API.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, ActionResult>
    {
        private readonly IProductService _productService;
        public DeleteProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ActionResult> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await _productService.DeleteProduct(request.id);

        }
    }
}
