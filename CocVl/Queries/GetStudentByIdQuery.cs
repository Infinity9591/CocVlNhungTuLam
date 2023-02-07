using CocVl.Models;
using MediatR;

namespace CocVl.Queries
{
    public record GetStudentByIdQuery(int studentId) : IRequest<Students>;
}
