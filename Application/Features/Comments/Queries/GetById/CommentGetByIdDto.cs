namespace Application.Features.Comments.Queries.GetById
{
    public class CommentGetByIdDto
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int LawyerId { get; set; }
    }
}
