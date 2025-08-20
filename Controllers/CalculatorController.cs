using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public ActionResult<double> Sum([FromQuery] double a, [FromQuery] double b)
        {
            return Ok(a + b);
        }
    }
}