using UserWebApplication.Database;
using UserWebApplication.Models;

namespace UserWebApplication.Repositories
{

    public class UserRepository : IUserRepository
    {

        public readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool addMultipleUsers(List<User> users)
        {
            users.ForEach(users =>
            {
                if (!_db.Users.Contains(users))
                {
                    _db.Users.Add(users);
                }
            });

            _db.SaveChanges();
            return true;
        }

        public bool addUser(User user)
        {
            if (_db.Users.Contains(user))
            {
                return false;
            }

            _db.Users.Add(user);
            _db.SaveChanges();
            return true;
        }

        public List<User> getAllUsers()
        {
            return _db.Users.ToList();
        }

        public User getUserByUsername(string username)
        {
            if(_db.Users.Any(u => u.Username == username))
            {
                return _db.Users.First(u => u.Username == username);
            }

            return null;
        }

        public bool removeUser(string username)
        {
            if (!_db.Users.Any(u => u.Username == username))
            {
                return false;
            }
            _db.Users.Remove(getUserByUsername(username));
            _db.SaveChanges();
            return true;
        }
    }
}
