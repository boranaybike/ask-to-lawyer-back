namespace Application.Features.Offers.Queries.GetById
{
    public class OfferGetByIdDto
    {
        public int Id { get; set; }
        public int? LawyerId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public int? Price { get; set; }
        public bool? IsAccepted { get; set; }
    }
}
