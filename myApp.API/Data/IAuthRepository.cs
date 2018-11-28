using System.Threading.Tasks;
using myApp.API.Models;

namespace myApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> RegisterAsync(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}