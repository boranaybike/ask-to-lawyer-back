namespace Application.Features.Answers.Queries.GetById
{
    public class AnswerGetByIdDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset OfferAcceptDate { get; set; }
        public int OfferId { get; set; }
    }
}
