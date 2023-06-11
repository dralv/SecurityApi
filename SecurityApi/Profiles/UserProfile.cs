using AutoMapper;
using SecurityApi.Dtos;
using SecurityApi.Models;

namespace SecurityApi.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, CreateUserDto>().ReverseMap();
        }
    }
}
