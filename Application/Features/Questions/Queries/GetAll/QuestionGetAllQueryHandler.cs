using Application.Common.Interfaces;
using Application.Features.Lawyers.Queries.GetAll;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Questions.Queries.GetAll
{
    public class QuestionGetAllQueryHandler : IRequestHandler<QuestionGetAllQuery, List<QuestionGetAllDto>>
    {
        private readonly IApplicationDbContext _context;

        public QuestionGetAllQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<QuestionGetAllDto>> Handle(QuestionGetAllQuery request, CancellationToken cancellationToken)
        {

            var questions = await _context.Questions
                .Select(question => new QuestionGetAllDto
                {
                    Id = question.Id,
                    Title = question.Title,
                    Description = question.Description,
                    MaxPrice = question.MaxPrice,
                    MinPrice = question.MinPrice,
                    ClientName = question.Client.FirstName,
                    ClientId = question.ClientId,
                })
                .ToListAsync(cancellationToken);

            return questions;

        }

    }
}
