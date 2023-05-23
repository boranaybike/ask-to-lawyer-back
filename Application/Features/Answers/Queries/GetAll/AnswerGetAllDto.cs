using System;

namespace Application.Features.Answers.Queries.GetAll
{
    public class AnswerGetAllDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset OfferAcceptDate { get; set; }
        public int OfferId { get; set; }
    }
}
