using CocVl.Commands;
using CocVl.Models;
using MediatR;

namespace CocVl.Handler
{
    public class UpdateStudentByIdHandler : IRequestHandler<UpdateStudentByIdCommand, Students>
    {
        private readonly CocVlEntities _db;

        public UpdateStudentByIdHandler(CocVlEntities db) 
        { 
            _db = db;
        }

        public async Task<Students?> Handle(UpdateStudentByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = _db.Students.Where(x => x.ID == request._Student.ID).FirstOrDefault();
            if (entity != null) 
            {
                entity.Name = request._Student.Name;
                entity.Email = request._Student.Email;
                entity.Phone = request._Student.Phone;
                entity.Address = request._Student.Address;
                entity.ClassID = request._Student.ClassID;
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
