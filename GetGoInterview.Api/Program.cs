using Microsoft.EntityFrameworkCore;
using GetGoInterview.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Add DB Context using Sqlite Driver
builder.Services.AddDbContext<GetGoInterviewDbContext>(
    options =>
    {
        var directory = Directory.GetCurrentDirectory();
        options.UseSqlite($"Data Source={directory}/getgointerview.db");
    }
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
