using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    [ApiController]
    [Route("api/veiculos")]
    public class VeiculosController : ControllerBase
    {
        [Authorize] // Exige autenticação para acessar essa rota
        [HttpGet]
        public IActionResult GetVeiculos()
        {
            return Ok(new { message = "Acesso permitido!" });
        }
    }
}
