using CocVl.Models;
using MediatR;

namespace CocVl.Commands
{
    public record AddStudentCommand(Students _Student) : IRequest<Students>;
}
