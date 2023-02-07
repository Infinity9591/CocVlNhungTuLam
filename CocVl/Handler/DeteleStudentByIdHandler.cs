using CocVl.Models;
using CocVl.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CocVl.Handler
{
    public class DeteleStudentByIdHandler : IRequestHandler<DeleteStudentByIdCommand, Students>
    {
        private readonly CocVlEntities _db;

        public DeteleStudentByIdHandler(CocVlEntities db)
        { 
            _db = db;
        }

        public async Task<Students> Handle(DeleteStudentByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = _db.Students.Where(x => x.ID == request.Id).FirstOrDefault();
            if (entity != null) 
            {
                _db.Students.RemoveRange(entity);
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
