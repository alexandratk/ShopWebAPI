using Application.Queries.GetCustomersByDateOfBirth;
using Application.Queries.GetCustomersByLastPurchaseDays;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class CustomerController(IMediator _mediator) : ControllerBase
    {
        [HttpGet("dateofbirth")]
        public async Task<IActionResult> GetCustomersByDateOfBirth([FromQuery] DateTime dateOfBirth)
        {
            GetCustomersByDateOfBirthQuery query = new() { DateOfBirth = dateOfBirth };

            return Ok(await _mediator.Send(query));
        }

        [HttpGet("last")]
        public async Task<IActionResult> GetCustomersByLastPurchaseDays([FromQuery] int numberOfDays)
        {
            GetCustomersByLastPurchaseDaysQuery query = new() { NumberOfDays = numberOfDays };

            return Ok(await _mediator.Send(query));
        }
    }
}
