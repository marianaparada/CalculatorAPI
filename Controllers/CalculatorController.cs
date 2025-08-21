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
            return Ok(new { a, b, result });
        }
        [HttpGet(template: "resta")]
        public IActionResult GetResta([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new { a, b, result });
        }
        [HttpGet(template: "product")]
        public IActionResult GetProduct([FromQuery] int a, [FromQuery] int b)
        {
            var result = a * b;
            return Ok(new { a, b, result });
        }
        [HttpGet(template: "division")]
        public IActionResult GetDivision([FromQuery] double a, [FromQuery] double b)
        {
            if (a == 0 || b == 0)
            {
                return BadRequest();
            }
            else
            {
                var result = a / b;
                            return Ok(new { a, b, result });
            }
                
        }
    }
}

