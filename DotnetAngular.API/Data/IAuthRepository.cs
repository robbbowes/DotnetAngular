using System.Threading.Tasks;
using DotnetAngular.API.Models;

namespace DotnetAngular.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}