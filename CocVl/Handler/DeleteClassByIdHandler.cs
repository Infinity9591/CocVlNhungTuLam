using CocVl.Commands;
using CocVl.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;

namespace CocVl.Handler
{
    public class DeleteClassByIdHandler : IRequestHandler<DeleteClassByIdCommand, Class>
    {
        private readonly CocVlEntities _db;

        public DeleteClassByIdHandler(CocVlEntities db) 
        {
            _db = db;
        }

        public async Task<Class> Handle(DeleteClassByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = _db.Class.Where(x => x.ID == request.Id).FirstOrDefault();
            if (entity!=null)
            {
                _db.Class.RemoveRange(entity);
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
