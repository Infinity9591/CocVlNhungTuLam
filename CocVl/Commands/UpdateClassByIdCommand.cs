using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record UpdateClassByIdCommand(int Id, string classname) : IRequest<Class>;
}
