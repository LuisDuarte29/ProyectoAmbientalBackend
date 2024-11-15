using Microsoft.AspNetCore.Mvc;

namespace ProyectoAmbientalBackend.Controllers
{
    [ApiController]

    [Route("api/[controller]")] // Ruta base para el controlador
    public class GetController : ControllerBase
    {
        // Definir una acción GET que responda a la ruta "api/Get"
        [HttpGet]
        public IActionResult GetMessage()
        {
            var data = new List<string> { "Hello", "World", "from", "ASP.NET API" };
            return Ok(data);
        }
    }
}
