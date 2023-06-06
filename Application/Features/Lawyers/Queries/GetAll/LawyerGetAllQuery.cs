using MediatR;

namespace Application.Features.Lawyers.Queries.GetAll
{
    public class LawyerGetAllQuery : IRequest<List<LawyerGetAllDto>>
    {
    }
}