using Microsoft.AspNetCore.Mvc;
using SeuProjeto.Models;
using SeuProjeto.Services;

namespace SeuProjeto.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController()
        {
            _tokenService = new TokenService();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            // Simulação de login (idealmente, buscaria no banco de dados)
            if (user.Email == "teste@email.com" && user.PasswordHash == "123456") // Simulação
            {
                var token = _tokenService.GenerateToken(user.Email);
                return Ok(new { token });
            }
            return Unauthorized("Usuário ou senha inválidos.");
        }
    }
}
