namespace Application.Features.Offers.Queries.GetAll
{
    public class OfferGetAllDto
    {
        public int Id { get; set; }
        public int? LawyerId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public int? Price { get; set; }
        public bool? IsAccepted { get; set; }
        public string LawyerLastName { get; set; }
        public string? LawyerFirstName { get; set; }
        public string? LawyerBar { get; set; }
    }
}