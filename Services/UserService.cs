using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;


namespace Services

{
    public class UserService : IUserService
    {
        private readonly IUserRepositoty _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
