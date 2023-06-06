using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Lawyers.Commands.Add
{
    public class LawyerAddCommandHandler : IRequestHandler<LawyerAddCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public LawyerAddCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(LawyerAddCommand request, CancellationToken cancellationToken)
        {
            var lawyer = new Lawyer
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                Password = request.Password,
                BarNo = request.BarNo,
                Bar= request.Bar,
                Bio = request.Bio,
                Education = request.Education,
                ExperienceDate = request.ExperienceDate,
                AverageResponseTime = request.AverageResponseTime,
                AverageRate = request.AverageRate

            };

            await _context.Lawyers.AddAsync(lawyer, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>("Lawyer added successfully.", lawyer.Id);
        }
    }
}
