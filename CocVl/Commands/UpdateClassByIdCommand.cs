using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record UpdateClassByIdCommand(int Id, Class Class) : IRequest<Class>;
}
