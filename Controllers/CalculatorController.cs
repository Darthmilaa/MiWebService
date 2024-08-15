     using Microsoft.AspNetCore.Mvc;

    namespace MiWebService.Controllers;

     [ApiController]
     [Route("api/[controller]")]
     public class CalculatorController : ControllerBase
     {
         [HttpGet("add")]
         public IActionResult Suma(int a, int b)
         {
             int resultado = a + b;
             return Ok(resultado);
         }
        [HttpGet("substract")]
         public IActionResult Resta(int a, int b)
         {
             int resultado = a + b;
             return Ok(resultado);
         }

     }
     
