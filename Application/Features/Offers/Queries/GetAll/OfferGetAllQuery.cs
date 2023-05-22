using MediatR;

namespace Application.Features.Offers.Queries.GetAll
{
    public class OfferGetAllQuery : IRequest<List<OfferGetAllDto>>
    {
    }
}
