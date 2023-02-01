using CocVl.Commands;
using CocVl.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;

namespace CocVl.Handler
{
    public class DeleteClassByIdHandler : IRequestHandler<DeleteClassByIdCommand, string>
    {
        private readonly CocVlEntities _dataClass;

        public DeleteClassByIdHandler(CocVlEntities dataClass) 
        {
            _dataClass = dataClass;
        }

        public async Task<string> Handle(DeleteClassByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = _dataClass.Class.Where(x => x.ID == request.Id).FirstOrDefault();
            if (entity!=null)
            {
                _dataClass.Class.RemoveRange(entity);
                await _dataClass.SaveChangesAsync();
                return new string("Lmeo");
            }
            else
            {
                return new string("Lmeow");
            }
        }
    }
}
