using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppForUnitTesting.Core.Dtos;
using AppForUnitTesting.Core.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppForUnitTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        private readonly ICalculatorService calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        // GET: api/Calculator
        [HttpPost("Calculate")]
        public async Task<IActionResult> CalculateAsync([FromBody] Calculator calculator)
        {
            return Ok(calculatorService.Calculate(calculator));
        }

       
    }
}
