using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Lawyers.Queries.GetAll
{
    public class LawyerGetAllQueryHandler : IRequestHandler<LawyerGetAllQuery, List<LawyerGetAllDto>>
    {
        private readonly IApplicationDbContext _context;

        public LawyerGetAllQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<LawyerGetAllDto>> Handle(LawyerGetAllQuery request, CancellationToken cancellationToken)
        {
            var lawyers = await _context.Lawyers
                .Select(lawyer => new LawyerGetAllDto
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
                    Bar = lawyer.Bar,
                    Category = lawyer.Category,

                })
                .ToListAsync(cancellationToken);

            return lawyers;
        }
    }
}