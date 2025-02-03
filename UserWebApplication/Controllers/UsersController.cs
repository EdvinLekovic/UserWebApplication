using Microsoft.AspNetCore.Mvc;
using UserWebApplication.Models;
using UserWebApplication.Repositories;

namespace UserWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UsersController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public List<User> getAllUsers()
        {
            return this.userRepository.getAllUsers();
        }

        [HttpGet("{username}")]
        public User GetUserByUsername(string username)
        {
            return this.userRepository.getUserByUsername(username);
        }

        [HttpPost("add-user")]
        public bool AddUser(User user)
        {
            return this.userRepository.addUser(user);
        }

        [HttpPost("add-multiple-users")]
        public bool AddMultipleUsers(List<User> users)
        {
            return this.userRepository.addMultipleUsers(users);
        }

        [HttpDelete("remove-user/{username}")]
        public bool RemoveUser(string username)
        {
            return this.userRepository.removeUser(username);
        }
    }
}
