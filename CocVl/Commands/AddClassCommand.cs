using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record AddClassCommand(Class _Class) : IRequest<Class>;
}
