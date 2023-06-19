using Domain.Common;
using MediatR;

namespace Application.Features.Answers.Commands.Update
{
    public class AnswerUpdateCommand : IRequest<Response<int>>
    {
        public int? Id { get; set; }
        public DateTimeOffset? Date { get; set; }
        public DateTimeOffset? OfferAcceptDate { get; set; }
        public int? OfferId { get; set; }
    }
}
