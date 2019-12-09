using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         //register user
         Task<User> Register(User user, string password);
         //login
         Task<User> Login(string username, string password);
         //userExists
         Task<bool> UserExists(string username);
    }
}