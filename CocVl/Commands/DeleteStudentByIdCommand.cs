using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record DeleteStudentByIdCommand(int Id) : IRequest<Students>;
}
