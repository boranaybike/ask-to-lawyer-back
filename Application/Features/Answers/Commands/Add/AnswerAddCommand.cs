using Domain.Common;
using MediatR;

namespace Application.Features.Answers.Commands.Add
{
    public class AnswerAddCommand : IRequest<Response<int>>
    {
        public string? MessageBody { get; set; }
        public DateTimeOffset? Date { get; set; }
        public DateTimeOffset? OfferAcceptDate { get; set; }
        public int? OfferId { get; set; }
        public int? ClientId { get; set; }
        public int? LawyerId { get; set; }
        public bool? FromClient { get; set; } = false;
        public bool? FromLawyer { get; set; } = false;
    }
}
