using Application.Features.Answers.Commands.Add;
using Application.Features.Answers.Commands.Delete;
using Application.Features.Answers.Commands.Update;
using Application.Features.Answers.Queries.GetAll;
using Application.Features.Answers.Queries.GetById;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AnswersController : ApiControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await Mediator.Send(new AnswerGetByIdQuery(id)));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(AnswerGetAllQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(AnswerAddCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(AnswerUpdateCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteAsync(AnswerDeleteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
