using AuthenticationServer.API.Models;

namespace AuthenticationServer.API.Services.UserRepositories
{
    public class InMemoryUserRepositories : IUserRepository
    {

        //Store our users in a list
        private readonly List<User> _users = new List<User>();

        public Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid();

            _users.Add(user);

            return Task.FromResult(user);
        }

        public Task<User> GetByEmail(string email)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Email == email));
        }

        public Task<User> GetByUsername(string username)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Username == username));
        }

        public Task<User> GetById(Guid UserId) 
        {
        return Task.FromResult(_users.FirstOrDefault(u => u.Id == UserId));
        }



    }
}
