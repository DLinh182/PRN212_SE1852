using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class UserDAO
    {

        static List<User> users = new List<User>();
        public void InitializeDataset()
        {
            users.Add(new User() { Name = "Tèo", Email = "a", Phone = "123" });
            users.Add(new User() { Name = "tí", Email = "linh", Phone = "1234" });
            users.Add(new User() { Name = "hí", Email = "ba", Phone = "1234563" });
            users.Add(new User() { Name = "haha", Email = "ac", Phone = "0987123" });
            users.Add(new User() { Name = "momeo", Email = "ad", Phone = "2345123" });
            users.Add(new User() { Name = "gâu gâu", Email = "ass", Phone = "23456123" });
            users.Add(new User() { Name = "huỳnh", Email = "aio", Phone = "235123" });
            users.Add(new User() { Name = "llalaa", Email = "afff", Phone = "15678923" });
        }
        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
