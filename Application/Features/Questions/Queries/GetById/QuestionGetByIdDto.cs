﻿namespace Application.Features.Questions.Queries.GetById
{
    public class QuestionGetByIdDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Categories { get; set; }
        public int? MaxPrice { get; set; }
        public int? MinPrice { get; set; }
        public int? ClientId { get; set; }
        public string? ClientName { get; set; }
        public bool IsDeleted { get; set; }

    }
}
