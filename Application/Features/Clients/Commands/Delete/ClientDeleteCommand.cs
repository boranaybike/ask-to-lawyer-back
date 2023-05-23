using Domain.Common;
using MediatR;

namespace Application.Features.Clients.Commands.Delete
{
    public class ClientDeleteCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
    }
}
