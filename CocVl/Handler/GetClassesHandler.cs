using MediatR;
using CocVl.Queries;
using CocVl.Models;

namespace CocVl.Handler
{
    public class GetClassesHandler :IRequestHandler<GetClassesQuery, List<Class>>
    {
        private readonly CocVlEntities _db;

        public GetClassesHandler(CocVlEntities db) => _db = db;

        public Task<List<Class>> Handle(GetClassesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_db.Class.ToList());
        }
            
    }
}
