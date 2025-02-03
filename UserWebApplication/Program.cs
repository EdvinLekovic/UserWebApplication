using Microsoft.EntityFrameworkCore;
using UserWebApplication.Database;
using UserWebApplication.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add database context

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add dependencies
builder.Services.AddScoped<IUserRepository, UserRepository>();


// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
