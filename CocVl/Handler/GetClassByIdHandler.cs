using CocVl.Models;
using CocVl.Queries;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CocVl.Handler
{
    public class GetClassByIdHandler : IRequestHandler<GetClassByIdQuery, Class>
    {
        private readonly CocVlEntities _db;

        public GetClassByIdHandler(CocVlEntities db) 
        {
            _db = db;
        }

        public Task<Class> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_db.Class.Single(x => x.ID == request.classId));
        }
    }
}
