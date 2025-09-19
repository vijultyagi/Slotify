using Microsoft.EntityFrameworkCore;
using Slotify.Application.Commands.CreateService;
using Slotify.Domain.Interfaces;
using Slotify.Infrastructure.Database.Context;
using Slotify.Infrastructure.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

builder.Services.AddDbContext<SlotifyDbContext>(options =>
    options.UseInMemoryDatabase("SlotifyDb"));

builder.Services.AddEndpointsApiExplorer(); // Required for API Explorer
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

await app.RunAsync();

