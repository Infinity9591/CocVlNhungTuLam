using CocVl.Models;
using MediatR;

namespace CocVl.Queries
{
    public record GetStudentsQuery() : IRequest<List<Students>>;
}
