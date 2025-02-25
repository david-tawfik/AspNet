using AspNet.API.Commands;
using AspNet.Application.IService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.API.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, ActionResult>
    {
        private readonly IProductService _productService;
        public UpdateProductHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<ActionResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return await _productService.UpdateProduct(request.id, request.Product);
        }

    }
}
