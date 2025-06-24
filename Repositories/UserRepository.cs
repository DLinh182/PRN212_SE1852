using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class UserRepository : IUserRepositoty
    {
        public List<User> GetAllUsers()
        {
            UserDAO userDAO = new UserDAO();
            userDAO.InitializeDataset();
            return userDAO.GetAllUsers();
        }
    }
}
