namespace Application.Features.Answers.Queries.GetAll
{
    public class AnswerGetAllDto
    {
        public int Id { get; set; }
        public string? MessageBody { get; set; }
        public DateTimeOffset? Date { get; set; }
        public DateTimeOffset? OfferAcceptDate { get; set; }
        public int? OfferId { get; set; }
        public int? ClientId { get; set; }
        public int? LawyerId { get; set; }
        public bool? FromClient { get; set; }
        public bool? FromLawyer { get; set; }
    }
}
