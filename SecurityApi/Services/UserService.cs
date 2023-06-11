using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SecurityApi.Dtos;
using SecurityApi.Models;

namespace SecurityApi.Services
{
    public class UserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly TokenService _tokenService;

        public UserService(UserManager<User> userManager, IMapper mapper, SignInManager<User> signInManager, TokenService tokenService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task CadastrarUser(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);

            var resultado = await _userManager.CreateAsync(user,dto.Password);

            if (!resultado.Succeeded) throw new ApplicationException("Falha ao cadastra o usuário");
            
        }

        public async Task Login(LoginUsuarioDto dto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password,false,false);

            if (!resultado.Succeeded) throw new ApplicationException("Usuário não autenticado");

            var usuario = _signInManager.UserManager.Users.FirstOrDefault(user => user.NormalizedUserName == dto.Username.ToUpper()) ;
            var token = _tokenService.GenerateToken(usuario);

        }

    }
}
