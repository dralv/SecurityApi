using System.ComponentModel.DataAnnotations;

namespace SecurityApi.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
