using MediatR;

namespace Application.Features.Lawyers.Queries.GetById
{
    public class LawyerGetByIdQuery : IRequest<LawyerGetByIdDto>
    {
        public int Id { get; set; }
        public LawyerGetByIdQuery(int id)
        {
            Id = id;
        }
    }
}
