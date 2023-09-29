﻿using Fitness.DataAccess.UnitOfWork;
using Fitness.Service.DTOs;
using Fitness.Service.DTOs.Users;
using Fitness.Service.Interfaces.Auth;

namespace Fitness.Service.Services.Auth;

public class AuthService : IAuthService
{
    private readonly IUnitOfWork _unitOfWork;
    public AuthService(IUnitOfWork unitOfWork)
    {
        this._unitOfWork = unitOfWork;
    }
    public Task<(bool Result, string Token)> LoginAsync(UserLoginDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<(bool Result, int CachedMinutes)> RegisterAsync(UserCreationDto dto)
    {
        var user = await _userRepository.GetByEmailAsync(dto.IdentityProvider);
        if (user is not null)
            throw new UserAlreadyExsistExceptions();

        if (_memoryCache.TryGetValue(REGISTER_CACHE_KEY + dto.IdentityProvider, out RegisterDto registrDto))
        {
            registrDto.IdentityProvider = registrDto.IdentityProvider;
            _memoryCache.Remove(dto.IdentityProvider);
        }
        else
        {
            _memoryCache.Set(REGISTER_CACHE_KEY + dto.IdentityProvider, dto, TimeSpan.FromMinutes(CACHED_FOR_MINUTS_REGISTER));
        }
        return (Result: true, CachedMinutes: CACHED_FOR_MINUTS_REGISTER);
    }

    public Task<(bool Result, int CachedMinutes)> ResetPasswordAsync(ForgotPasswordDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<(bool Result, int CachedVerificationMinutes)> SendCodeForRegisterAsync(string phoneNumber)
    {
        throw new NotImplementedException();
    }

    public Task<(bool Result, string Token)> VerifyRegisterAsync(string phoneNumber, int code)
    {
        throw new NotImplementedException();
    }

    public Task<(bool Result, string Token)> VerifyResetPasswordAsync(string phoneNumber, int code)
    {
        throw new NotImplementedException();
    }
}
