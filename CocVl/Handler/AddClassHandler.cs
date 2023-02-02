using CocVl.Commands;
using CocVl.Models;
using MediatR;

namespace CocVl.Handler
{
    public class AddClassHandler : IRequestHandler<AddClassCommand, Class>
    {
        private readonly CocVlEntities _db;

        public AddClassHandler(CocVlEntities db)
        {
            _db = db;
        }

        public async Task<Class> Handle(AddClassCommand request, CancellationToken cancellationToken)
        {
            await _db.Class.AddAsync(request._Class);
            await _db.SaveChangesAsync();
            return request._Class;
        }
    }
}
