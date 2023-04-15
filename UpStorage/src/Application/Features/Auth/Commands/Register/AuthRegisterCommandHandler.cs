﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models.Auth;
using Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Auth.Commands.Register
{
    public class AuthRegisterCommandHandler : IRequestHandler<AuthRegisterCommand, AuthRegisterDto>
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthRegisterCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<AuthRegisterDto> Handle(AuthRegisterCommand request, CancellationToken cancellationToken)
        {
            var createUserDto = new CreateUserDto(request.FirstName, request.LastName, request.Email, request.Password);

            var userId = await _authenticationService.CreateUserAsync(createUserDto, cancellationToken);

            var emailToken = await _authenticationService.GenerateEmailActivationTokenAsync(userId, cancellationToken);

            var fullName = $"{request.FirstName} {request.LastName}";

            return new AuthRegisterDto(request.Email, fullName, emailToken);
        }
    }
}