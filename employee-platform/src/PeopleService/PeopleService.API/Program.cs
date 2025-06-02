
using PeopleService.Application.UseCases.EmployeeUseCases;
using PeopleService.Domain.Interfaces;
using PeopleService.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DI
builder.Services.AddScoped<IGetAllEmployeesHandler, GetAllEmployeesHandler>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();
