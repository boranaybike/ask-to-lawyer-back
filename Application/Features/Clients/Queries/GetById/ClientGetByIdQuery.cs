using MediatR;

namespace Application.Features.Clients.Queries.GetById
{
    public class ClientGetByIdQuery : IRequest<ClientGetByIdDto>
    {
        public int Id { get; set; }

        public ClientGetByIdQuery(int id)
        {
            Id = id;
        }
    }
}
