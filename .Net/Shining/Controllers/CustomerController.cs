using System.Text.Json;
using System.Threading.Tasks;
using DTOs.Actor;
using DTOs.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.QueryStringParameters;

namespace Shining.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CustomerController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _serviceManager.CustomerService.GetAll();

            return Ok(customers);
        }
        

        [Authorize(Roles = "User,Administrator")]
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetCustomerByUserId(string userId)
        {
            var customerDTO = await _serviceManager.CustomerService.GetByUserId(userId);

            return Ok(customerDTO);
        }



        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerForCreationDTO customerForCreationDTO)
        {
            var customerDTO = await _serviceManager.CustomerService.Create(customerForCreationDTO);


            return CreatedAtAction(nameof(CreateCustomer), customerDTO);
        }


        [Authorize(Roles = "User,Administrator")]
        [HttpPut("{customerId}")]
        public async Task<IActionResult> UpdateCustomer(int customerId, [FromBody] CustomerForUpdateDTO customerForUpdateDTO)
        {
            await _serviceManager.CustomerService.Update(customerId, customerForUpdateDTO);

            return NoContent();
        }

        [Authorize(Roles = "User,Administrator")]
        [HttpDelete("{customerId}")]
        public async Task<IActionResult> DeleteCustomer(int customerId)
        {
            await _serviceManager.CustomerService.Delete(customerId);

            return NoContent();
        }

    }
    
}