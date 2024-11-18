using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using rental.Domain.Interfaces.Commands;
using rental.Domain.Models;
using rental.Domain.Services.Authenticate.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace rental.Domain.Services.Authenticate;

public class AuthenticateService : IAuthenticateService
{
    private readonly IConfiguration _configuration;

    public AuthenticateService(IConfiguration configuration)
    {
        _configuration = configuration;
    }    

    public Task<IResult> LoginAsync(LoginModel model)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> RegisterAsync(RegisterModel model)
    {
        throw new NotImplementedException();
    }

    public JwtSecurityToken GetToken(List<Claim> authClaims)
    {
        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

        var token = new JwtSecurityToken(
            issuer: _configuration["JWT:ValidIssuer"],
            audience: _configuration["JWT:ValidAudience"],
            expires: DateTime.Now.AddHours(3),
            claims: authClaims,
            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

        return token;
    }
}
