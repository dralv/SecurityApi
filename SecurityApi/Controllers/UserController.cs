using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SecurityApi.Dtos;
using SecurityApi.Services;

namespace SecurityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Rota para cadastrar um novo usuário
        /// </summary>
        /// <param name="dto">Informações do usuãrio a ser cadastrado</param>
        /// <returns></returns>
        [HttpPost("cadastrar-usuario")]
        public async Task<IActionResult> CadastrarNovoUsuário([FromBody]CreateUserDto dto)
        {
            await _userService.CadastrarUser(dto);
            return Ok("Usuário cadastrado com sucesso");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUsuarioDto dto)
        {
            var token = await _userService.Login(dto);
            return Ok(token);
        }
    }
}
