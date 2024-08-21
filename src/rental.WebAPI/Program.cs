using Microsoft.AspNetCore.Authentication.BearerToken;
using rental.Domain.Interfaces.Repositories;
using rental.Domain.Mappers;
using rental.Domain.Services.Realty.Interface;
using rental.Domain.Services.Realty;
using rental.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using rental.Persistence.Context;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
        .AddAuthentication()
        .AddBearerToken();
builder.Services.AddAuthorization();

builder.Services.AddDbContext<RentalContext>();
builder.Services.AddScoped<DbContext, RentalContext>();
builder.Services.AddAutoMapper(typeof(RentalProfile).Assembly);

builder.Services.AddScoped<IRealtyService, RealtyService>();
builder.Services.AddScoped<IRealtyRepository, RealtyRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/login", (string username) =>
{
    var claimsPrincipal = new ClaimsPrincipal(
      new ClaimsIdentity(
        new[] { new Claim(ClaimTypes.Name, username) },
            BearerTokenDefaults.AuthenticationScheme
      )
    );
    return Results.SignIn(claimsPrincipal);
});

app.MapGet("/user", (ClaimsPrincipal user) =>
{
    return Results.Ok($"Bem-Vindo {user.Identity?.Name}!");
})
.RequireAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();