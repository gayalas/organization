using Microsoft.EntityFrameworkCore;
using OrganizationApi.Application.Interfaces;
using OrganizationApi.Application.Services;
using OrganizationApi.Infraestructure.Data;
using OrganizationApi.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<OrganizationDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IOrganizationRepository, OrganizationRepository>();
builder.Services.AddScoped<IOrganizationService, OrganizationService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();