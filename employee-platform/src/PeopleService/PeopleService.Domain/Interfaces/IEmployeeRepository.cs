using PeopleService.Domain.Entities;

namespace PeopleService.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();

    }
}
