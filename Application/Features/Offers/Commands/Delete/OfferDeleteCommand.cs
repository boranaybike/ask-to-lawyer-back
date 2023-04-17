using Domain.Common;
using MediatR;
namespace Application.Features.Offers.Commands.Delete
{
    public class OfferDeleteCommand:IRequest<Response<int>>
    {
        public int Id { get; set; }
    }
}
