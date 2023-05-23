using Domain.Common;
using MediatR;

namespace Application.Features.Answers.Commands.Add
{
    public class AnswerAddCommand : IRequest<Response<int>>
    {
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset OfferAcceptDate { get; set; }
        public int OfferId { get; set; }
    }
}
