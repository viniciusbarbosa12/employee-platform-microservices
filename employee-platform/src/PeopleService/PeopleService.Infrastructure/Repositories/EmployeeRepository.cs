using PeopleService.Domain.Entities;
using PeopleService.Domain.Interfaces;

namespace PeopleService.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            var employees = new List<Employee>
        {
            new() { Id = Guid.NewGuid(), FullName = "João Silva", Email = "joao@empresa.com" },
            new() { Id = Guid.NewGuid(), FullName = "Maria Souza", Email = "maria@empresa.com" }
        };

            return Task.FromResult(employees.AsEnumerable());
        }
    }
}
