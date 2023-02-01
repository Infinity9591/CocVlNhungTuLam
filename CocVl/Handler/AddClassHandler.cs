using CocVl.Commands;
using CocVl.Models;
using MediatR;

namespace CocVl.Handler
{
    public class AddClassHandler : IRequestHandler<AddClassCommand, Class>
    {
        private readonly CocVlEntities _dataClass;

        public AddClassHandler(CocVlEntities dataClass)
        {
            _dataClass = dataClass; 
        }

        public async Task<Class> Handle(AddClassCommand request, CancellationToken cancellationToken)
        {
            await _dataClass.Class.AddAsync(request.Class);
            await _dataClass.SaveChangesAsync();
            return request.Class;
        }
    }
}
