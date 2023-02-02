using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record DeleteClassByIdCommand(int Id) : IRequest<Class>;
}
