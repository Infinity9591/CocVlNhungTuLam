using CocVl.Commands;
using CocVl.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;

namespace CocVl.Handler
{
    public class DeleteClassByIdHandler : IRequestHandler<DeleteClassByIdCommand, Class>
    {
        private readonly CocVlEntities _dataClass;

        public DeleteClassByIdHandler(CocVlEntities dataClass) 
        {
            _dataClass = dataClass;
        }

        public async Task<Class> Handle(DeleteClassByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = _dataClass.Class.Where(x => x.ID == request.Id).FirstOrDefault();
            if (entity!=null)
            {
                _dataClass.Class.RemoveRange(entity);
                await _dataClass.SaveChangesAsync();
                return entity;
            }
            else
            {
                return default;
            }
        }
    }
}
