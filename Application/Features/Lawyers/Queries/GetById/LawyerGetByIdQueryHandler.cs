using Application.Common.Interfaces;
using MediatR;

namespace Application.Features.Lawyers.Queries.GetById
{
    public class LawyerGetByIdQueryHandler : IRequestHandler<LawyerGetByIdQuery, LawyerGetByIdDto>
    {
        private readonly IApplicationDbContext _context;

        public LawyerGetByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<LawyerGetByIdDto> Handle(LawyerGetByIdQuery request, CancellationToken cancellationToken)
        {
            var lawyer = await _context.Lawyers.FindAsync(request.Id);

            if (lawyer == null)
            {
                return null;
            }

            var lawyerdDto = new LawyerGetByIdDto
            {
                Id = lawyer.Id,
                FirstName = lawyer.FirstName,
                LastName = lawyer.LastName,
                Email = lawyer.Email,
                Phone = lawyer.Phone,
                Password = lawyer.Password,
                BarNo = lawyer.BarNo,
                Bio = lawyer.Bio,
                Education = lawyer.Education,
                ExperienceDate = lawyer.ExperienceDate,
                AverageResponseTime = lawyer.AverageResponseTime,
                AverageRate = lawyer.AverageRate,
                Bar = lawyer.Bar
            };

            return lawyerdDto;
        }
    }
}