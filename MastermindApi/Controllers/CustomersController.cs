using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MastermindApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MastermindApi.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly MastermindContext _context;

        public CustomersController(MastermindContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
