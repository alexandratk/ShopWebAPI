using Application.Queries.GetProductCategoriesByCustomerId;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class ProductCategoryController(IMediator _mediator) : ControllerBase
    {
        [HttpGet("list")]
        public async Task<IActionResult> GetProductCategoriesByCustomerId([FromQuery] Guid customerId)
        {
            GetProductCategoriesByCustomerIdQuery query = new() { CustomerId = customerId };

            return Ok(await _mediator.Send(query));
        }
    }
}
