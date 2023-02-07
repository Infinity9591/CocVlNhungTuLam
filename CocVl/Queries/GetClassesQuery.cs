using CocVl.Models;
using MediatR;

namespace CocVl.Queries
{
    public record GetClassesQuery() : IRequest<List<Class>>;
}
