using Microsoft.AspNetCore.Mvc;
using PeopleService.Application.UseCases.EmployeeUseCases;
using PeopleService.Application.UseCases.EmployeeUseCases.CustomFilters;

namespace PeopleService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IGetAllEmployeesHandler _handler;

        public EmployeesController(IGetAllEmployeesHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _handler.HandleAsync(new GetAllEmployeesQuery());
            return Ok(result);
        }
    }
}
