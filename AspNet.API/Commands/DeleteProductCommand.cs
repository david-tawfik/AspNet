using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.API.Commands
{
    public record DeleteProductCommand(int id) : IRequest<ActionResult>;
}
