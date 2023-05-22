using MediatR;
using System.Collections.Generic;

namespace Application.Features.Clients.Queries.GetAll
{
    public class ClientGetAllQuery : IRequest<List<ClientGetAllDto>>
    {
    }
}
