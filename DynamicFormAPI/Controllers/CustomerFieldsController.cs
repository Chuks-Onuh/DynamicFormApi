using DynamicFormAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicFormAPI.Controllers
{
    [ApiController]
    [Route("api/customer-fields")]
    public class CustomerFieldsController : ControllerBase
    {
        private readonly ICustomerFieldService _service;

        public CustomerFieldsController(ICustomerFieldService service)
        {
            _service = service;
        }

        [HttpGet("{accountNumber}")]
        public IActionResult GetCustomerFields(string accountNumber)
        {
            var fields = _service.GetFieldsByAccountNumber(accountNumber);
            if (fields == null)
                return NotFound();

            return Ok(fields);
        }
    }
}
