using Application.Features.Clients.Commands.Add;
using Application.Features.Clients.Commands.Delete;
using Application.Features.Clients.Commands.Update;
using Application.Features.Clients.Queries.GetAll;
using Application.Features.Clients.Queries.GetById;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class ClientsController : ApiControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await Mediator.Send(new ClientGetByIdQuery(id)));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(ClientGetAllQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(ClientAddCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(ClientUpdateCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(ClientDeleteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
