using MediatR;

namespace Application.Features.Offers.Queries.GetById
{
    public class OfferGetByIdQuery : IRequest<OfferGetByIdDto>
    {
        public int Id { get; set; }

        public OfferGetByIdQuery(int id)
        {
            Id = id;
        }
    }
}
