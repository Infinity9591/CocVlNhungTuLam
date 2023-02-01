using MediatR;
using CocVl.Queries;
using CocVl.Models;

namespace CocVl.Handler
{
    public class GetClassHandler :IRequestHandler<GetClassQuery, List<Class>>
    {
        private readonly CocVlEntities _dataClass;

        public GetClassHandler(CocVlEntities dataClass) => _dataClass = dataClass;

        public Task<List<Class>> Handle(GetClassQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataClass.Class.ToList());
        }
            
    }
}
