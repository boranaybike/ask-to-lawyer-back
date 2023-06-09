﻿using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Questions.Commands.Add
{
    public class QuestionAddCommandHandler : IRequestHandler<QuestionAddCommand, Response<int>>
    {

        private readonly IApplicationDbContext _context;
        public QuestionAddCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task<Response<int>> Handle(QuestionAddCommand request, CancellationToken cancellationToken)
        {
            var question = new Question
            {
                Title = request.Title,
                Description = request.Description,
                MaxPrice = request.MaxPrice,
                MinPrice = request.MinPrice,
                ClientId = request.ClientId,
                IsDeleted = false,
                CreatedOn = DateTimeOffset.Now,
                CreatedByUserId = null,
                HasAnswer = request.HasAnswer,
                HasOffer = request.HasOffer,
            };

            await _context.Questions.AddAsync(question, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>($"The new addres named \"{question.Title}\" was successfully added.", question.Id);
        }
    }
}
