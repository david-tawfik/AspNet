using AspNet.Domain;
using MediatR;

namespace AspNet.API.Commands
{
    public record AddProductCommand(Product Product) : IRequest;
}
