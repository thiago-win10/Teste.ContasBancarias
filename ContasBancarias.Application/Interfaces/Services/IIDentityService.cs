using ContasBancarias.Application.DTOs.Request;
using ContasBancarias.Application.DTOs.Response;

namespace ContasBancarias.Application.Interfaces.Services
{
    public interface IIDentityService
    {
        Task<UsuarioCadastroResponse> RegisterUsuario(UsuarioCadastroRequest usuarioRequest);
        Task<UsuarioLoginResponse> Login(UsuarioLoginRequest loginRequest);
    }
}
