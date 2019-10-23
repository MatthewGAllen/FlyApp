using System.Threading.Tasks;
using FlyApp.API.Models;

namespace FlyApp.API.Data
{
    public interface IUserRepository
    {
         Task<bool> SaveAll();

         Task<User> GetUser(int id);

    }
}