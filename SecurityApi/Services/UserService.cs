using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SecurityApi.Dtos;
using SecurityApi.Models;

namespace SecurityApi.Services
{
    public class UserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task CadastrarUser(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            

        }

        
    }
}
