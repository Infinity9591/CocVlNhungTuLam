using MediatR;
using CocVl.Queries;
using CocVl.Models;

namespace CocVl.Handler
{
    public class GetClassHandler :IRequestHandler<GetClassQuery, List<Class>>
    {
        private readonly CocVlEntities _db;

        public GetClassHandler(CocVlEntities db) => _db = db;

        public Task<List<Class>> Handle(GetClassQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_db.Class.ToList());
        }
            
    }
}
