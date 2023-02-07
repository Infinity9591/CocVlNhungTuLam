using CocVl.Queries;
using CocVl.Models;
using MediatR;
using System.Linq;

namespace CocVl.Handler
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Students>
    {
        private readonly CocVlEntities _db;

        public GetStudentByIdHandler(CocVlEntities db) 
        { 
            _db = db;
        }

        public Task<Students?> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        { 
            var result = _db.Students.Where(x => x.ID == request.studentId).FirstOrDefault();

            return Task.FromResult(result);
        }
    }
}
