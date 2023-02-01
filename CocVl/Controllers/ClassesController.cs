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
        public async Task<ActionResult> AddClass([FromBody] Class Class)
        {
            var classToReturn = await _mediator.Send(new AddClassCommand(Class));

            return CreatedAtRoute("GetClassById", new { id = classToReturn.ID }, classToReturn);
        }

        [HttpGet]
        public async Task<ActionResult> GetClasses()
        {
            var classes = await _mediator.Send(new GetClassQuery());
            return Ok(classes);
        }

        [HttpGet("{id:int}", Name = "GetClassById")]
        public async Task<ActionResult> GetClassById(int Id)
        {
            var classes = await _mediator.Send(new GetClassByIdQuery(Id));

            return Ok(classes);
        }

        [HttpDelete("{id}")]
        public async Task<string> DeleteClassById(int Id)
        {
            return await _mediator.Send(new DeleteClassByIdCommand(Id));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateClassById(int Id, string classname)
        {
            return Ok(await _mediator.Send(new UpdateClassByIdCommand(Id, classname)));
        }

    }


}
