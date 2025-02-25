using AspNet.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.API.Commands
{
    public record UpdateProductCommand(int id,Product Product) : IRequest<ActionResult>;
}
