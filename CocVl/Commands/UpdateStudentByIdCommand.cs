using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record UpdateStudentByIdCommand(int Id, Students _Student) : IRequest<Students>;
}
