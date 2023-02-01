using CocVl.Models;
using MediatR;

namespace CocVl.Queries
{
    public record GetClassByIdQuery(int ID) : IRequest<Class>;
}
