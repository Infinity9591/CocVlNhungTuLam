using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record UpdateClassByIdCommand(int Id, Class _Class) : IRequest<Class>;
}
