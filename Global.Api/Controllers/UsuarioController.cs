using ExemploApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ExemploApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly IConfiguration _configuration;

        public UsuarioController(UsuarioRepository usuarioRepository, IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository;
            _configuration = configuration;
        }

        [HttpPost("BuscarUsuarios")]
        public async Task<IActionResult> BuscarUsuarios()
        {
            var usuarios = await _usuarioRepository.BuscarUsuarios();
            return Ok(usuarios);
        }

        [HttpPost("BuscarUsuariosDB")]
        public async Task<IActionResult> BuscarUsuariosDB()
        {
            var usuarios = await _usuarioRepository.BuscarUsuariosDB();
            return Ok(usuarios);
        }
    }
}
