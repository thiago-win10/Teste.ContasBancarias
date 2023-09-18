using ContasBancarias.Application.DTOs.Request;
using ContasBancarias.Application.DTOs.Response;
using ContasBancarias.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContasBancarias.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IIDentityService _identityService;

        public UsuarioController(IIDentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("cadastro")]
        public async Task<ActionResult<UsuarioCadastroResponse>> Cadastrar(UsuarioCadastroRequest cadastroRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _identityService.RegisterUsuario(cadastroRequest);
            if (result.Sucesso)
                return Ok(result);

            else if (result.Erros.Count > 0)
                return BadRequest(result);

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UsuarioCadastroResponse>> Login(UsuarioLoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _identityService.Login(loginRequest);
            if (result.Sucesso)
                return Ok(result);

            return Unauthorized(result);

        }
    }
}
