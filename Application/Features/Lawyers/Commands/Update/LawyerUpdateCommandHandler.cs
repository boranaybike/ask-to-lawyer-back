using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Lawyers.Commands.Update
{
    public class LawyerUpdateCommandHandler : IRequestHandler<LawyerUpdateCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public LawyerUpdateCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(LawyerUpdateCommand request, CancellationToken cancellationToken)
        {
            var lawyer = await _context.Lawyers.FindAsync(request.Id);

            if (lawyer == null)
            {
                throw new ArgumentException();
            }

            lawyer.FirstName = request.FirstName;
            lawyer.LastName = request.LastName;
            lawyer.Email = request.Email;
            lawyer.Phone = request.Phone;
            lawyer.Password = request.Password;
            lawyer.BarNo = request.BarNo;
            lawyer.Bio = request.Bio;
            lawyer.Education = request.Education;
            lawyer.ExperienceDate = request.ExperienceDate;
            lawyer.AverageResponseTime = request.AverageResponseTime;
            lawyer.AverageRate = request.AverageRate;
            lawyer.Bar = request.Bar;

            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>("Lawyer updated successfully.", lawyer.Id);
        }
    }
}
