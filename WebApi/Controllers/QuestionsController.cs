using Application.Features.Questions.Commands.Add;
using Application.Features.Questions.Commands.Delete;
using Application.Features.Questions.Commands.Update;
using Application.Features.Questions.Queries.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ApiControllerBase
    {

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(QuestionAddCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await Mediator.Send(new QuestionGetAllQuery(id, false)));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(QuestionDeleteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(QuestionUpdateCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

    }
}
