using Microsoft.AspNetCore.Mvc;

namespace ProyectoAmbientalBackend.Controllers
{
    [ApiController]
  

    public class GetController : ControllerBase
    {
        // Definir una acción GET que responda a la ruta "api/Get"
        [Route("api/GetMessage")] // Ruta base para el controlador
        [HttpGet]
        public IActionResult GetMessage()
        {
            var data = new List<string> { "Hello", "World", "from", "ASP.NET API" };

            return Ok(data);
        }
        [Route("api/GetUsuarios")] // Ruta base para el controlador
        [HttpGet]
        public IActionResult GetUsuarios(string username, string password)
        {
            return Ok();
        }
        
        
    }
}
