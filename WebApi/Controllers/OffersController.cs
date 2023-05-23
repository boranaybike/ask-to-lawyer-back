using Application.Features.Offers.Commands.Add;
using Application.Features.Offers.Commands.Delete;
using Application.Features.Offers.Commands.Update;
using Application.Features.Offers.Queries.GetAll;
using Application.Features.Offers.Queries.GetById;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class OffersController : ApiControllerBase
    {

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await Mediator.Send(new OfferGetByIdQuery(id)));
        }


        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAllAsync(OfferGetAllQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(OfferAddCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(OfferUpdateCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(OfferDeleteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

    }
}
