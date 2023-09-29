
using Fitness.Domain.Entities;
using Fitness.Service.Interfaces.Auth;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Fitness.Service.Helpers;

namespace Fitness.Service.Services.Auth;

public class TokenService : ITokenService
{
    private readonly IConfiguration _config;
    public TokenService(IConfiguration configuration)
    {
        this._config = configuration.GetSection("Jwt");

    }
  
    public string GenerateToken(User user)
    {
        var identityClaims = new Claim[]
       {
            new Claim("Id", user.Id.ToString()),
            new Claim("FirstName", user.Firtsname),
            new Claim("Lastname", user.Lastname),
            new Claim("Email", user.Email),
            new Claim(ClaimTypes.Role, user.Role.ToString())
       };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecurityKey"]!));
        var keyCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        int expiresHours = int.Parse(_config["Lifetime"]!);
        var token = new JwtSecurityToken(
            issuer: _config["Issuer"],
            audience: _config["Audience"],
            claims: identityClaims,
            expires: TimeHelper.GetDateTime().AddHours(expiresHours),
            signingCredentials: keyCredentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

