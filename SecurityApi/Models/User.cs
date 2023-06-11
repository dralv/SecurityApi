using Microsoft.AspNetCore.Identity;

namespace SecurityApi.Models
{
    public class User:IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public User():base(){}
    }
}
