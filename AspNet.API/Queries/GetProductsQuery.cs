using AspNet.Domain;
using MediatR;

namespace AspNet.API.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
