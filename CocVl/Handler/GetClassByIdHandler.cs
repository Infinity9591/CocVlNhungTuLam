using CocVl.Models;
using CocVl.Queries;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CocVl.Handler
{
    public class GetClassByIdHandler : IRequestHandler<GetClassByIdQuery, Class>
    {
        private readonly CocVlEntities _dataClass;

        public GetClassByIdHandler(CocVlEntities dataClass) 
        {
            _dataClass = dataClass;
        }

        public Task<Class> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataClass.Class.Single(x => x.ID == request.ID));
        }
    }
}
