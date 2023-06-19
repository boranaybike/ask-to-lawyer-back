using Application.Common.Interfaces;
using Application.Features.Clients.Commands.Add;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Lawyers.Commands.Add
{
    public class LawyerAddCommandHandler : IRequestHandler<LawyerAddCommand, LawyerRegisterDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IJwtService _jwtService;

        public LawyerAddCommandHandler(IApplicationDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;

        }

        public async Task<LawyerRegisterDto> Handle(LawyerAddCommand request, CancellationToken cancellationToken)
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

            var fullName = lawyer.FirstName + lawyer.LastName;


            await _context.Lawyers.AddAsync(lawyer, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            var jwtDto = _jwtService.Generate(lawyer.Id, request.Email, request.FirstName, request.LastName, "lawyer");
            return new LawyerRegisterDto(request.Email, fullName, jwtDto.AccessToken);
        }
    }
}
