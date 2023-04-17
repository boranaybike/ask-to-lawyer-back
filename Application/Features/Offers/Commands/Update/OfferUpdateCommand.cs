using Domain.Common;
using MediatR;

namespace Application.Features.Offers.Commands.Update
{
    public class OfferUpdateCommand:IRequest<Response<int>>
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public bool IsAccepted { get; set; }

    }
}
