using Domain.Common;
using MediatR;
namespace Application.Features.Offers.Commands.Add
{
    public class OfferAddCommand: IRequest<Response<int>>
    {
        public int Id { get; set; }
        public int LawyerId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int Price { get; set; }
        public bool IsAccepted { get; set; }
        public DateTimeOffset AcceptDate { get; set; }

    }
}
