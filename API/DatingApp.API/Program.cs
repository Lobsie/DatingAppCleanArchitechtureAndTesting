using DatingApp.API.Core.Interfaces.Mapping;
using DatingApp.API.Core.Interfaces.Repositories;
using DatingApp.API.Core.Interfaces.Services;
using DatingApp.API.Core.Mapping;
using DatingApp.API.Core.Services;
using DatingApp.API.Infrastructure.Data;
using DatingApp.API.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IAppUserRepository, UserRepository>();

builder.Services.AddScoped<IMapFromAppUserToAppUserDto, MapFromAppUserToAppUserDto>();

builder.Services.AddScoped<IAppUserService, AppUserService>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
