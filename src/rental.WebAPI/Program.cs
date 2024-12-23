using rental.Domain.Interfaces.Repositories;
using rental.Domain.Mappers;
using rental.Domain.Services.Realty.Interface;
using rental.Domain.Services.Realty;
using rental.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using rental.Persistence.Context;

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

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RentalDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddDbContext<RentalDbContext>();
builder.Services.AddScoped<DbContext, RentalDbContext>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();