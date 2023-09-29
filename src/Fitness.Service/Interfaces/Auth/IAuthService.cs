using Fitness.Service.DTOs;
using Fitness.Service.DTOs.Users;

namespace Fitness.Service.Interfaces.Auth;

public interface IAuthService
{
    public Task<(bool Result, int CachedMinutes)> RegisterAsync(UserCreationDto dto);
    public Task<(bool Result, int CachedVerificationMinutes)> SendCodeForRegisterAsync(string phoneNumber);
    public Task<(bool Result, string Token)> VerifyRegisterAsync(string phoneNumber, int code);
    public Task<(bool Result, string Token)> LoginAsync(UserLoginDto dto);
    public Task<(bool Result, int CachedMinutes)> ResetPasswordAsync(ForgotPasswordDto dto);
    public Task<(bool Result, string Token)> VerifyResetPasswordAsync(string phoneNumber, int code);
}
