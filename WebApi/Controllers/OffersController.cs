using Application.Features.Offers.Commands.Add;
using Application.Features.Offers.Commands.Delete;
using Application.Features.Offers.Commands.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); 

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
