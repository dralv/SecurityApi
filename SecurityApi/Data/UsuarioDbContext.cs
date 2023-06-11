using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecurityApi.Models;

namespace SecurityApi.Data
{
    public class UsuarioDbContext:IdentityDbContext<User>
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options):base(options){}
    }
}
