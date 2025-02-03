using UserWebApplication.Models;

namespace UserWebApplication.Repositories
{
    public interface IUserRepository
    {
        public List<User> getAllUsers();
        public User getUserByUsername(string username);
        public bool addMultipleUsers(List<User> users);
        public bool addUser(User user);
        public bool removeUser(string username);
    }
}
