using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SecurityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "MaiorDeIdade")]
        public async Task<IActionResult> Acesso()
        {
            return Ok("Usuário com acesso, maior de 18 anos");
        }
    }
}
