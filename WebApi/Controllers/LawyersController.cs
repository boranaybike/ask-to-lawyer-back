using Application.Features.Lawyers.Commands.Add;
using Application.Features.Lawyers.Commands.Delete;
using Application.Features.Lawyers.Commands.Update;
using Application.Features.Lawyers.Queries.GetAll;
using Application.Features.Lawyers.Queries.GetById;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class LawyersController : ApiControllerBase
    {

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await Mediator.Send(new LawyerGetByIdQuery(id)));
        }


        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAllAsync(LawyerGetAllQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(LawyerAddCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(LawyerUpdateCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(LawyerDeleteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

    }
}
