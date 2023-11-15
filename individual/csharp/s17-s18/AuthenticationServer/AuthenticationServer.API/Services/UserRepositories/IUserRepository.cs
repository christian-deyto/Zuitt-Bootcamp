using AuthenticationServer.API.Models;

namespace AuthenticationServer.API.Services.UserRepositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmail(string email);

        Task<User> GetByUsername(string username);

        //Added
        Task<User> Create(User user);

        Task<User> GetById(Guid userId);

    }
}
