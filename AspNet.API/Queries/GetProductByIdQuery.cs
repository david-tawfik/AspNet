using AspNet.Domain;
using MediatR;

namespace AspNet.API.Queries
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
