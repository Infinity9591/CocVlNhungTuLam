using CocVl.Commands;
using CocVl.Models;
using CocVl.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CocVl.Controllers
{
    [Route("api/classes")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClassesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> AddClass([FromBody] Class _Class)
        {
            var classes = await _mediator.Send(new AddClassCommand(_Class));

            return Ok(classes);
        }

        [HttpGet]
        public async Task<ActionResult> GetClasses()
        {
            var classes = await _mediator.Send(new GetClassesQuery());
            return Ok(classes);
        }

        [HttpGet("{id:int}", Name = "GetClassById")]
        public async Task<ActionResult> GetClassById(int classId)
        {
            var classes = await _mediator.Send(new GetClassByIdQuery(classId));

            return Ok(classes);
        }

        [HttpDelete("{id:int}", Name = "DeleteClassById")]
        public async Task<Class> DeleteClassById(int Id)
        {
            var classes = await _mediator.Send(new DeleteClassByIdCommand(Id));

            return classes;
        }

        [HttpPut]
        public async Task<ActionResult> UpdateClassById(int Id, Class _Class)
        {
            var classes = await _mediator.Send(new UpdateClassByIdCommand(Id, _Class));

            return Ok(classes);
        }

    }


}
