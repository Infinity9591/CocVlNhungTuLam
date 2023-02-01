using CocVl.Models;
using MediatR;

namespace CocVl.Queries
{
    public record GetClassQuery() : IRequest<List<Class>>;
}
