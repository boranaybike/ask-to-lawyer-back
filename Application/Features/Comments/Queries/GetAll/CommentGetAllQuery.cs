using MediatR;
using System.Collections.Generic;

namespace Application.Features.Comments.Queries.GetAll
{
    public class CommentGetAllQuery : IRequest<List<CommentGetAllDto>>
    {
    }
}
