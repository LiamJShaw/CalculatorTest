using CalculatorTest.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorTest.Api.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController(ISimpleCalculator calculator) : ControllerBase
    {
        private readonly ISimpleCalculator _calculator = calculator;

        [HttpGet("add")]
        public ActionResult<int> Add([FromQuery] int start, [FromQuery] int amount)
        {
            try
            {
                return Ok(_calculator.Add(start, amount));
            }
            catch (OverflowException)
            {
                return BadRequest("ERROR: Calculation resulted in an integer overflow");
            }
        }

        [HttpGet("subtract")]
        public ActionResult<int> Subtract([FromQuery] int start, [FromQuery] int amount)
        {
            try
            {
                return Ok(_calculator.Subtract(start, amount));
            }
            catch (OverflowException)
            {
                return BadRequest("ERROR: Calculation resulted in an integer overflow");
            }
        }
    }
}
