using CocVl.Models;
using MediatR;

namespace CocVl.Queries
{
    public record GetClassByIdQuery(int classId) : IRequest<Class>;
}
