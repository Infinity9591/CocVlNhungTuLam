using CocVl.Commands;
using CocVl.Models;
using CocVl.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CocVl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            var students = await _mediator.Send(new GetStudentsQuery());

            return Ok(students);    
        }

        [HttpGet("{studentId:int}", Name = "GetStudentById")]
        public async Task<ActionResult> GetStudentById(int studentId)
        {
            var student = await _mediator.Send(new GetStudentByIdQuery(studentId));

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult> AddStudentById(Students _Student)
        {
            var student = await _mediator.Send(new AddStudentCommand(_Student));

            return Ok(student);
        }

        [HttpDelete("{id:int}", Name = "DeleteStudentById")]
        public async Task<Students> DeteleStudentById(int Id)
        {
            var student = await _mediator.Send(new DeleteStudentByIdCommand(Id));

            return student;
        }

        [HttpPut]
        public async Task<ActionResult> UpdateStudentById(int Id, Students _Student)
        {
            var student = await _mediator.Send(new UpdateStudentByIdCommand(Id, _Student));

            return Ok(student);
        }
    }
}
