using PeopleService.Contracts.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleService.Domain.Entities;
using PeopleService.Application.UseCases.EmployeeUseCases.CustomFilters;


namespace PeopleService.Application.UseCases.EmployeeUseCases
{
    public class GetAllEmployeesHandler : IGetAllEmployeesHandler
    {
        public Task<IEnumerable<EmployeeResponse>> HandleAsync(GetAllEmployeesQuery query)
        {
            var employees = new List<Employee>
        {
            new() { Id = Guid.NewGuid(), FullName = "João Silva", Email = "joao@empresa.com" },
            new() { Id = Guid.NewGuid(), FullName = "Maria Souza", Email = "maria@empresa.com" }
        };

            return Task.FromResult(employees.Select(e => new EmployeeResponse
            {
                Id = e.Id,
                FullName = e.FullName,
                Email = e.Email
            }));
        }
    }
}
