﻿using Domain.Common;
using MediatR;

namespace Application.Features.Questions.Commands.Update
{
    public class QuestionUpdateCommand:IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? MaxPrice { get; set; }
        public int? MinPrice { get; set; }
        public int ClientId { get; set; }
        public bool? HasOffer { get; set; }
        public bool? HasAnswer { get; set; }

    }
}
