using CocVl.Commands;
using CocVl.Models;
using MediatR;

namespace CocVl.Handler
{
    public class UpdateClassByIdHandler : IRequestHandler<UpdateClassByIdCommand, Class>
    {
        private readonly CocVlEntities _db;

        public UpdateClassByIdHandler(CocVlEntities db)
        {
            _db = db;
        }

        public async Task<Class?> Handle(UpdateClassByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = _db.Class.Where(x => x.ID == request.Class.ID).FirstOrDefault();
            if (entity != null)
            {
                entity.ClassName = request.Class.ClassName;
                await _db.SaveChangesAsync();
                return entity;
            }
            else
            {
                return default;
            }
        }
    }
}
