using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(template: "sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok( new {a, b,result} );}
        }
    }
