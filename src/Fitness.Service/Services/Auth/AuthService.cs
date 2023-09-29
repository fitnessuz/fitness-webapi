using AutoMapper;
using Fitness.DataAccess.UnitOfWork;
using Fitness.Domain.Entities;
using Fitness.Service.Common.Security;
using Fitness.Service.DTOs;
using Fitness.Service.DTOs.Users;
using Fitness.Service.Exceptions.Auth;
using Fitness.Service.Exceptions.User;
using Fitness.Service.Interfaces.Auth;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;
using System.Numerics;

namespace Fitness.Service.Services.Auth;

public class AuthService : IAuthService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ITokenService _tokenService;
    public AuthService(IUnitOfWork unitOfWork,
                       IMapper mapper,
                       ITokenService tokenService)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
        this._tokenService = tokenService;
    }
    public async Task<(bool Result, string Token)> LoginAsync(UserLoginDto dto)
    {
        var user = await _unitOfWork.UserRepository.SelectAsync(x => x.Email == dto.Email);
        if (user is null) throw new UserNotFoundException();

        var hasherResult = PasswordHasher.Verify(dto.Password, user.Password);
        if (hasherResult == false) throw new PasswordNotMatchException();

        //var planResultDto = _mapper.Map<PlanResultDto>(user.Plan);
        //var techerResultDto = _mapper.Map<TeacherResultDto>(user.Teacher);
        //var attachmentResultDto=_mapper.Map<AttachmentResultDto>(user.Attachment);
        //UserResultDto userResultDto = new UserResultDto()
        //{
        //    Id = user.Id,
        //    Firtsname = user.Firtsname,
        //    Lastname = user.Lastname,
        //    Email = user.Email,
        //    DateOfBirth = user.DateOfBirth,
        //    Gender=user.Gender,
        //    Plan= planResultDto,
        //    Teacher= techerResultDto,
        //    Attachment= attachmentResultDto
        //};

        var Dbrole = await _unitOfWork.UserRepository.SelectAsync(x => x.Id == user.Id);

        string token = _tokenService.GenerateToken(user);

        return (Result: true, Token: token);
    }

    public Task<(bool Result, int CachedMinutes)> RegisterAsync(UserCreationDto dto)
    {
        throw new NotImplementedException();
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
