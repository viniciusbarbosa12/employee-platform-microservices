using PeopleService.Application.UseCases.EmployeeUseCases.CustomFilters;
using PeopleService.Contracts.Contracts.Responses;

namespace PeopleService.Application.UseCases.EmployeeUseCases
{
    public interface IGetAllEmployeesHandler
    {
        Task<IEnumerable<EmployeeResponse>> HandleAsync(GetAllEmployeesQuery query);
    }
}