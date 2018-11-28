using System.ComponentModel.DataAnnotations;

namespace myApp.API.Dtos
{
    public class UserForLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}