﻿using MediatR;

namespace Application.Features.Clients.Commands.Add
{
    public class ClientAddCommand : IRequest<ClientRegisterDto>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
