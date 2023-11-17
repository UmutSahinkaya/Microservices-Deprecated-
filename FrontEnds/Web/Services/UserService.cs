using System.Threading.Tasks;
using Web.Models;
using Web.Services.Interfaces;

namespace Web.Services
{
    public class UserService : IUserService
    {
        public Task<UserViewModel> GetUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
