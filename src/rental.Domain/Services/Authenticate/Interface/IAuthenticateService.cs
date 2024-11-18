using rental.Domain.Interfaces.Commands;
using rental.Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace rental.Domain.Services.Authenticate.Interface;

public interface IAuthenticateService
{
    Task<IResult> LoginAsync(LoginModel model);
    Task<IResult> RegisterAsync(RegisterModel model);
    JwtSecurityToken GetToken(List<Claim> authClaims);
}