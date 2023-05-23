using MediatR;
using System.Collections.Generic;

namespace Application.Features.Lawyers.Queries.GetAll
{
    public class LawyerGetAllQuery : IRequest<List<LawyerGetAllDto>>
    {
    }
}