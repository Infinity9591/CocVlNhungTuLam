﻿using CocVl.Commands;
using CocVl.Models;
using MediatR;

namespace CocVl.Handler
{
    public class UpdateClassByIdHandler : IRequestHandler<UpdateClassByIdCommand, Class>
    {
        private readonly CocVlEntities _dataClass;

        public UpdateClassByIdHandler(CocVlEntities dataClass)
        {
            _dataClass = dataClass;
        }

        public async Task<Class?> Handle(UpdateClassByIdCommand request, CancellationToken cancellationToken)
        {
            var entity = _dataClass.Class.Where(x => x.ID == request.Id).FirstOrDefault();
            if (entity != null)
            {
                entity.ID = request.Id;
                entity.ClassName = request.classname;
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
