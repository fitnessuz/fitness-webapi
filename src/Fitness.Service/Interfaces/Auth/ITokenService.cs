
using Fitness.Domain.Entities;

namespace Fitness.Service.Interfaces.Auth;

public interface ITokenService
{
    public string GenerateToken(User user);
}
