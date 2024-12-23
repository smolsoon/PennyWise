﻿using Microsoft.IdentityModel.JsonWebTokens;
using PennyWise.Modules.Users.Core.DTO;
using PennyWise.Modules.Users.Core.Entities;
using PennyWise.Modules.Users.Core.Exceptions;
using PennyWise.Modules.Users.Core.Repositories;

namespace PennyWise.Modules.Users.Core.Services;

internal class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<UserDto?> GetAsync(Guid id)
    {
        var user = await userRepository.GetAsync(id);
        
        return user is null ? null : new UserDto(user.Id, user.Email, user.Role, user.CreatedAt);
    }

    public async Task<IEnumerable<UserDto>> BrowseAsync()
    {
        var users = await userRepository.BrowseAsync();

        return users.Select(user => new UserDto(user.Id, user.Email, user.Role, user.CreatedAt)).ToList();
    }

    public Task<JsonWebToken> SignInAsync(SignInDto signInDto)
    {
        throw new NotImplementedException();
    }

    public async Task SignUpAsync(SignUpDto signUpDto)
    {
        signUpDto.Id = Guid.NewGuid();
        var email = signUpDto.Email.ToLowerInvariant();
        var user = await userRepository.GetAsync(email);
        
        if (user is not null)
        {
            throw new EmailInUseException();
        }
        
        user = new User(signUpDto.Name, signUpDto.Lastname, signUpDto.Email, signUpDto.Password, signUpDto.Role);
        
        await userRepository.AddAsync(user);
    }
    
    
}