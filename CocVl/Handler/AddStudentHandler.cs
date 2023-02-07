using CocVl.Commands;
using CocVl.Models;
using MediatR;

namespace CocVl.Handler
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Students>
    {
        private readonly CocVlEntities _db;

        public AddStudentHandler(CocVlEntities db)
        {
            _db = db;
        }

        public async Task<Students> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            await _db.Students.AddAsync(request._Student);
            await _db.SaveChangesAsync();

            return request._Student;
        }
    }
}
