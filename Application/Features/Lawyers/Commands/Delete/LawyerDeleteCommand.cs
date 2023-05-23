using Domain.Common;
using MediatR;

namespace Application.Features.Lawyers.Commands.Delete
{
    public class LawyerDeleteCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
    }
}
