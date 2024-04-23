using ExemploApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ExemploApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
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
