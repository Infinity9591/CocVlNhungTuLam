using CocVl.Models;
using CocVl.Queries;
using MediatR;
using System.Linq;

namespace CocVl.Handler
{
    public class GetStudentsHandler : IRequestHandler<GetStudentsQuery, List<Students>>
    {
        private readonly CocVlEntities _db;

        public GetStudentsHandler(CocVlEntities db)
        {
            _db = db;
        }

        public Task<List<Students>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var result = _db.Students.ToList();

            return Task.FromResult(result);
        }
    }
}
